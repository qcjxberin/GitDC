using Autofac;
using GitDC.Data;
using GitDC.Data.MySql;
using Ding.Datas.Dapper;
using Ding.Datas.Dapper.MySql;
using Ding.Datas.Sql;
using Ding.Dependency;
using Ding.Events;
using Ding.Events.Default;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;

namespace GitDC.Service
{
    public class ServiceModule : Module, IConfig
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<GitDCUnitOfWork>()
                .As<IGitDCUnitOfWork>()
                .InstancePerDependency();

            builder
                .RegisterType<SqlQuery>()
                .As<ISqlQuery>()
                .InstancePerDependency();

            builder
                .RegisterType<EventBus>()
                .As<IEventBus>()
                .InstancePerDependency();

            builder
                .RegisterType<MySqlBuilder>()
                .As<ISqlBuilder>()
                .InstancePerDependency();


            builder.RegisterType<HostingEnvironment>().As<IHostingEnvironment>().SingleInstance();

            builder.Register<IConfiguration>(p =>
            {
                IHostingEnvironment env = p.Resolve<IHostingEnvironment>();
                var file = "appsettings.json";
                return new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile(file, true, true)
                         .AddJsonFile($"{file.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)[0]}.{env.EnvironmentName}.json", true)
                         .Build();
            }).SingleInstance();

            builder.AddDbContext<GitDCUnitOfWork>((options, configuration) =>
            {
                string connectionString = configuration["ConnectionStrings:MySqlConnection"];
                options.UseMySql(connectionString);
                options.ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning));
            });
        }
    }
}
