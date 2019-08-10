using Ding;
using Ding.Biz.OAuthLogin.Extensions;
using Ding.Caches.EasyCaching;
using Ding.Captcha;
using Ding.Configs;
using Ding.Datas.Ef;
using Ding.Events.Default;
using Ding.Locks.Default;
using Ding.Logs.Extensions;
using Ding.MailKit.Extensions;
using Ding.Schedulers.Quartz;
using Ding.Sms.FengHuo;
using Ding.Swashbuckle.Filters.Operations;
using Ding.Webs.Extensions;
using Ding.Webs.Filters;
using EasyCaching.CSRedis;
using EasyCaching.InMemory;
using EasyCaching.Serialization.MessagePack;
using EasyCaching.SQLite;
using GitDC.Auth;
using GitDC.Common;
using GitDC.Data;
using GitDC.Filters;
using GitDC.SignalR;
using GitDC.SwaggerExtensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.WebEncoders;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace GitDC
{
    /// <summary>
    /// 启动配置
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 初始化启动配置
        /// </summary>
        /// <param name="configuration">配置</param>
        /// <param name="env">环境变量</param>
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            ConfigFileHelper.Set(env: env);
            Configuration = configuration;
        }

        /// <summary>
        /// 配置
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 配置服务
        /// </summary>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // 用于Razor引擎输出内容被编译的问题
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });
            //添加Mvc服务
            services.AddMvc(options => {
                options.Filters.Add<WebAttribute>();
                options.Filters.Add(new ValidationAttribute() { AllowNulls = true });
                //options.Filters.Add<ValidationAttribute>(); // 全局检查是否允许传入的值为空, true为如?id=&id1=或者空的实体这样的方式传入空值时不做检测并允许传入，否则如果当id没有值时，只能传入?id1=Url不能有id=  
                options.Filters.Add<ResultHandlerAttribute>(); // 对返回的结果进行全局处理
                options.ValueProviderFactories.Add(new JQueryQueryStringValueProviderFactory()); //处理数组接收中[]括号不识别问题
            }).AddJsonOptions(options => {
                // 解决json序列化时的循环引用问题,设置为不处理循环引用
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                // 对 JSON 数据使用混合大小写。跟属性名同样的大小.输出
                //options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                // 设置时间格式
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                // 实现所有非ASCII和控制字符(例如换行符)都被转义
                options.SerializerSettings.StringEscapeHandling = StringEscapeHandling.EscapeNonAscii;
            }).AddControllersAsServices()
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //添加NLog日志操作
            services.AddNLog();

            //注册缓存
            services.AddCache(option =>
            {
                option.UseInMemory("default");
                option.UseSQLite(config => {
                    config.DBConfig.FilePath = $@"{Directory.GetCurrentDirectory()}\wwwroot";
                    config.DBConfig.FileName = "cache.db";
                }, "lgb").WithMessagePack();
                //Redis缓存
                option.UseCSRedis(config =>
                {
                    config.DBConfig = new CSRedisDBOptions
                    {
                        ConnectionStrings = new List<string>
                        {
                            SiteSetting.Current.WebConfig.Redis_Configuration
                        }
                    };
                }, "redis1").WithMessagePack();//with messagepack serialization
                ;
                //option.UseRedis(config =>
                //{
                //    config.DBConfig.Endpoints.Add(new ServerEndPoint(Configuration["Redis:Ip"], Configuration["Redis:Port"].ToInt()));
                //}, "redis1").WithMessagePack();//with messagepack serialization
                //;
            });

            //添加业务锁
            services.AddLock();

            //注册CSRF令牌服务
            services.AddCsrfToken();

            //添加EF工作单元
            switch (SiteSetting.Current.DataProvider)
            {
                case "MSSQL2012":
                    //====== 支持Sql Server 2012+ ==========
                    services.AddUnitOfWork<IGitDCUnitOfWork, Data.SqlServer.GitDCUnitOfWork>(Configuration.GetConnectionString("DefaultConnection"), Configuration);
                    break;

                case "MSSQL2005":
                    //======= 支持Sql Server 2005+ ==========
                    services.AddUnitOfWork<IGitDCUnitOfWork, Data.SqlServer.GitDCUnitOfWork>(builder =>
                    {
                        builder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), option => option.UseRowNumberForPaging());
                    });
                    break;

                case "MySQL":
                    //======= 支持MySql =======
                    services.AddUnitOfWork<IGitDCUnitOfWork, Data.MySql.GitDCUnitOfWork>(Configuration.GetConnectionString("MySqlConnection"), Configuration);
                    break;

                case "PostgreSQL":
                default:
                    //======= 支持PgSql =======
                    services.AddUnitOfWork<IGitDCUnitOfWork, Data.PgSql.GitDCUnitOfWork>(Configuration.GetConnectionString("PgSqlConnection"), Configuration);
                    break;
            }

            //支持API多版本
            services.AddApiVersioning(option =>
            {
                option.ReportApiVersions = true;
                option.AssumeDefaultVersionWhenUnspecified = true;
                option.DefaultApiVersion = new ApiVersion(1, 0);
                option.ApiVersionReader = ApiVersionReader.Combine(new QueryStringApiVersionReader(), new HeaderApiVersionReader()
                {
                    HeaderNames = { "api-version" }
                });
            });

            //添加Swagger
            ConfigSwagger(services);

            #region 认证
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
            {
                o.LoginPath = new PathString("/Account/Login");
                o.AccessDeniedPath = new PathString("/Error/Forbidden");
            })
            .AddCookie(AdminAuthorizeAttribute.AdminAuthenticationScheme, o =>
            {
                o.LoginPath = new PathString($"/{SiteSetting.Current.WebConfig.AdminPath}/Login");
                o.AccessDeniedPath = new PathString("/Error/Forbidden");
            })
            .AddJwtBearer(JwtAuthorizeAttribute.JwtAuthenticationScheme, o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,//是否验证Issuer
                    ValidateAudience = true,//是否验证Audience
                    ValidateIssuerSigningKey = true,//是否验证SecurityKey
                    ValidateLifetime = true,//是否验证超时  当设置exp和nbf时有效 同时启用ClockSkew 
                    ClockSkew = TimeSpan.FromSeconds(30),//注意这是缓冲过期时间，总的有效时间等于这个时间加上jwt的过期时间，如果不配置，默认是5分钟
                    ValidAudience = SiteSetting.Current.JWT.Audience,//Audience
                    ValidIssuer = SiteSetting.Current.JWT.Issuer,//Issuer，这两项和前面签发jwt的设置一致
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SiteSetting.Current.JWT.JWTSecretKey))//拿到SecurityKey
                };
                o.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        // 如果过期，则把<是否过期>添加到，返回头信息中
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
            });
            #endregion

            #region 授权
            services.AddAuthorization(options =>
            {
                options.AddPolicy("App", policy => policy.RequireRole("App").Build());
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("AdminOrApp", policy => policy.RequireRole("Admin,App").Build());
            });
            #endregion

            // 添加Razor静态Html生成器
            services.AddRazorHtml();

            //添加事件总线
            services.AddEventBus();

            //添加Cap事件总线
            //services.AddEventBus( options => {
            //    options.UseDashboard();
            //    options.UseSqlServer( Configuration.GetConnectionString( "DefaultConnection" ) );
            //    options.UseRabbitMQ( "192.168.244.138" );
            //} );

            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });

            services.AddSignalR();  // 注册SignalR

            services.AddTimedJob(); //注册定时任务

            services.AddMemoryCache();//使用本地缓存必须添加
            services.AddSession();

            // 注册第三方登录
            services.AddLogin();

            //注册Cookie服务
            services.AddCookieManager(options =>
            {
                options.AllowEncryption = false;  //允许Cookie数据默认加密
                options.ThrowForPartialCookies = true;  //如果不是所有的 cookie 块在重新组装请求中都可用, 则抛出。
                options.ChunkSize = null;  //如果不允许在块中偏离，则设置为null
                options.DefaultExpireTimeInDays = 1;  //如果过期时间设置为空的 cookie，则默认 cookie 过期时间为1天
            });

            // 注册邮件
            services.AddMailKit(optionBuilder =>
            {
                optionBuilder.EmailConfig = new Ding.Net.Mail.Configs.EmailConfig()
                {
                    Host = SiteSetting.Current.Email.Host,
                    Port = SiteSetting.Current.Email.Port,
                    DisplayName = SiteSetting.Current.Email.FromName,
                    FromAddress = SiteSetting.Current.Email.From,
                    UserName = SiteSetting.Current.Email.UserName,
                    Password = SiteSetting.Current.Email.Password,
                    EnableSsl = SiteSetting.Current.Email.IsSSL
                };
                optionBuilder.MailKitConfig = new Ding.MailKit.Configs.MailKitConfig();
            });

            // 烽火短信
            services.AddFengHuoSms(o =>
            {
                o.SmsConfig.Name = SiteSetting.Current.Sms.FengHuoName;
                o.SmsConfig.PassWrod = SiteSetting.Current.Sms.FengHuoPassWord;
            });

            // 验证码
            services.AddCaptchaService(o => {
                o.SecretKey = SiteSetting.Current.CaptchaSecretKey;
            });
            services.AddTransient<VerificationCode>();

            //健康检查
            services.AddHealthChecks();

            //非控制器流程获取自身服务器地址，需要使用的地方依赖IServerAddressesFeature就好IServerAddressesFeature.Addresses.FirstOrDefault()就获取到绑定的基地址了
            services.AddSingleton(serviceProvider =>
            {
                var server = serviceProvider.GetRequiredService<IServer>();
                return server.Features.Get<IServerAddressesFeature>();
            });

            //注册自定义路由
            services.AddMvcRouting();

            services.AddMiniProfiler(options => options.RouteBasePath = "/profiler");  //使用"/profiler/results"来访问分析报告

            //注册IHttpClientFactory
            services.AddHttpClient();

            //添加Ding基础设施服务
            return services.AddDing();
        }

        /// <summary>
        /// 配置开发环境请求管道
        /// </summary>
        public void ConfigureDevelopment(IApplicationBuilder app, IHostingEnvironment env)
        {
            ConfigureBefore(app);

            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swagger, httpReq) => swagger.Host = httpReq.Host.Value);
            });
            var SwaggerRoutePrefix = "help";  //Swagger相对于根目录的目录
            app.UseSwaggerUI(config =>
            {
                config.IndexStream = () =>
                    GetType().GetTypeInfo().Assembly.GetManifestResourceStream("GitDC.Swagger.index.html");
                config.RoutePrefix = SwaggerRoutePrefix;
                config.ShowExtensions();
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "LiGongBang API v1");
                config.SwaggerEndpoint("/swagger/v2/swagger.json", "LiGongBang API v2");
                config.DisplayOperationId();
            });

            CommonConfig(app, env);
        }

        /// <summary>
        /// 配置生产环境请求管道
        /// </summary>
        public void ConfigureProduction(IApplicationBuilder app, IHostingEnvironment env)
        {
            ConfigureBefore(app);

            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
            app.UseHttpsRedirection();

            CommonConfig(app, env);
        }

        /// <summary>
        /// 公共配置前置
        /// </summary>
        /// <param name="app"></param>
        private void ConfigureBefore(IApplicationBuilder app)
        {
            app.UseMiniProfiler();
            app.UseResponseCompression();
        }

        /// <summary>
        /// 公共配置
        /// </summary>
        private void CommonConfig(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region 解决Ubuntu Nginx 代理不能获取IP问题
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            #endregion

            app.UseErrorLog();
            app.UseStaticFiles();
            app.UseSession();

            // Cookie策略设置
            app.UseCookiePolicy(new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Lax
            });

            app.UseCsrfToken();

            //健康检查
            app.UseHealthChecks("/health");

            ////注册第三方登录配置
            //app.RegisterThridLogin();

            app.UseAuthentication();
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatsHub>("/chathub");
            });

            ConfigRoute(app);

            app.UseTimedJob();
            Run().GetAwaiter().GetResult();
        }

        /// <summary>
        /// 路由配置,支持区域
        /// </summary>
        private void ConfigRoute(IApplicationBuilder app)
        {
            app.UseDingMvc();
            //app.UseMvc(routes => {
            //    routes.MapRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //    routes.MapRoute("api", "{controller}/{id?}");
            //});
        }

        /// <summary>
        /// 运行调度器
        /// </summary>
        private static async Task Run()
        {
            var scheduler = new Scheduler();

            //扫描添加任务
            await scheduler.ScanJobsAsync();

            //启动调度器
            await scheduler.StartAsync();
        }

        /// <summary>
        /// 配置Swagger
        /// </summary>
        /// <param name="services"></param>
        public void ConfigSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new Info { Version = "v1", Title = "GitDC API", Description = ".Net Core Git Server", Contact = new Contact() { Name = "丁川", Email = "100538511@qq.com", Url = "http://www.y-s.cc" } });
                options.SwaggerDoc("v2", new Info { Version = "v2", Title = "GitDC API", Description = ".Net Core Git Server", Contact = new Contact() { Name = "丁川", Email = "100538511@qq.com", Url = "http://www.y-s.cc" } });

                options.DocumentFilter<SetVersionInPaths>();
                options.DocInclusionPredicate((docName, apiDesc) =>
                {
                    if (!apiDesc.TryGetMethodInfo(out MethodInfo methodInfo)) return false;

                    var versions = methodInfo.DeclaringType
                        .GetCustomAttributes(true)
                        .OfType<ApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions);

                    return versions.Any(v => $"v{v.ToString()}" == docName);
                });

                options.OperationFilter<AddRequestHeaderOperationFilter>();
                options.OperationFilter<AddResponseHeadersOperationFilter>();
                options.OperationFilter<AddFileParameterOperationFilter>();

                // 授权组合
                options.OperationFilter<AddSecurityRequirementsOperationFilter>();
                options.OperationFilter<AddAppendAuthorizeToSummaryOperationFilter>();

                options.AddSecurityDefinition("oauth2", new ApiKeyScheme()
                {
                    Description = "Token令牌(数据将在请求头中进行传输) 参数结构: \"Authorization: Bearer {token}\"",
                    In = "header",
                    Name = "Authorization", // jwt默认的参数名称
                    Type = "apiKey",
                });
            });
            services.ConfigureSwaggerGen(options =>
            {
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "GitDC.xml"), true);  // 第二个参数是Controller的注释，默认为false
            });
        }
    }
}
