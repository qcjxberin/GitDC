using GitDC.Common;
using GitDC.Service.Abstractions.dbo;
using Ding.Dependency;
using Ding.Helpers;
using Ding.Schedulers.Quartz;
using Quartz;
using System;
using System.Threading.Tasks;

namespace GitDC.Jobs
{
    public class QuartzJob : JobBase
    {
        /// <summary>
        /// 获取重复执行间隔时间，单位：分钟
        /// </summary>
        public override int? GetIntervalInMinutes()
        {
            return 1;
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <remarks>请使用 scope 参数创建实例，不要使用 Ioc.Create 方法，可能导致生命周期错误</remarks>
        protected override async Task Execute(IJobExecutionContext context, IScope scope)
        {
            var result = await Web.Client().Post(SiteSetting.Current.Url + "/health")
                .ResultAsync();
            if (result == "Healthy")
            {
                Console.WriteLine("正常");
            }

            try
            {
                //var service = scope.Create<IBspLoginfaillogsService>();
                //Console.WriteLine("测试测试" + (await service.GetAllAsync()).Count);
                //var BspBannedipsService = scope.Create<IBspBannedipsService>();
                //Console.WriteLine("测试测试" + (await BspBannedipsService.CheckIP(Web.Ip)));
                //var SysRegionsService = Ioc.Create<ISysRegionsService>();
                //Console.WriteLine("获取城市的数量：" + (await SysRegionsService.GetAllAsync()).Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            await Task.FromResult(0);
        }
    }
}
