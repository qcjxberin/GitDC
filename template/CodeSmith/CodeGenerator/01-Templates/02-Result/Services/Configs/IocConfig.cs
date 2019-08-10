using Autofac;
using Ding.Dependency;
using GitDC.Data;

namespace GitDC.Service.Configs {
    /// <summary>
    /// 依赖注入配置
    /// </summary>
    public class IocConfig : ConfigBase {
        /// <summary>
        /// 加载配置
        /// </summary>
        protected override void Load( ContainerBuilder builder ) {
            LoadInfrastructure( builder );
            LoadRepositories( builder );
            LoadDomainServices( builder );
            LoadApplicationServices( builder );
        }

        /// <summary>
        /// 加载基础设施
        /// </summary>
        protected virtual void LoadInfrastructure( ContainerBuilder builder ) {
            builder.AddScoped<IGitDCUnitOfWork, GitDCUnitOfWork>();
        }

        /// <summary>
        /// 加载仓储
        /// </summary>
        protected virtual void LoadRepositories( ContainerBuilder builder ) {
            builder.AddScoped<IDCUsersRepository,DCUsersRepository>();
            builder.AddScoped<IWHLogsRepository,WHLogsRepository>();
            builder.AddScoped<IWHMiddlewareRepository,WHMiddlewareRepository>();
        }
        
        /// <summary>
        /// 加载领域服务
        /// </summary>
        protected virtual void LoadDomainServices( ContainerBuilder builder ) {
        }
        
        /// <summary>
        /// 加载应用服务
        /// </summary>
        protected virtual void LoadApplicationServices( ContainerBuilder builder ) {
            builder.AddScoped<IDCUsersService,DCUsersService>().PropertiesAutowired();
            builder.AddScoped<IWHLogsService,WHLogsService>().PropertiesAutowired();
            builder.AddScoped<IWHMiddlewareService,WHMiddlewareService>().PropertiesAutowired();
        }
    }
}