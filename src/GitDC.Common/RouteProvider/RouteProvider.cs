using Ding.Log;
using Ding.Mvc.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace GitDC.Common
{
    /// <summary>
    /// 表示提供基本路由的提供程序
    /// </summary>
    public partial class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// 获取路由提供程序的优先级
        /// </summary>
        public int Priority
        {
            get { return 0; }
        }

        /// <summary>
        /// 注册路由
        /// </summary>
        /// <param name="routeBuilder">路由构建器</param>
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            //重新排序路由，以便最常用的路线位于顶部。 它可以提高性能

            //区域
            routeBuilder.MapRoute(name: "areaRoute", template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            #region GitController
            routeBuilder.MapRoute(name: "Git.git", template: "git/{project}.git/{*verb}", defaults: new { controller = "Git", action = "Smart" });
            routeBuilder.MapRoute(name: "Git", template: "git/{project}/{*verb}", defaults: new { controller = "Git", action = "Smart" });
            #endregion

            #region RepositoryController
            routeBuilder.MapRoute(name: "Repository", template: "Repository/{action}/{name}/{*path}", defaults: new { controller = "Repository", path = "" });
            #endregion

            //var BspBannedipsService = Ioc.Create<IBspBannedipsService>();
            //Console.WriteLine("测试测试测试" + BspBannedipsService.CheckIP(Web.Ip).Result);
        }
    }
}
