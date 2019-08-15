using Ding.Log;
using Ding.Mvc.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;

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

            #region Routes for viewing the file tree
            routeBuilder.MapRoute(
                "RedirectGitLink",
                "{userName}/{repoName}.git",
                new { controller = "FileView", action = "RedirectGitLink" },
                new { method = new HttpMethodRouteConstraint("GET") }
            );

            routeBuilder.MapRoute(
                "GetRepositoryHomeView",
                "{userName}/{repoName}",
                new { controller = "FileView", action = "GetTreeView", id = "master", path = string.Empty },
                new { method = new HttpMethodRouteConstraint("GET") }
            );

            routeBuilder.MapRoute(
                "GetTreeView",
                "{userName}/{repoName}/tree/{id}/{*path}",
                new { controller = "FileView", action = "GetTreeView" },
                new { method = new HttpMethodRouteConstraint("GET") }
            );

            routeBuilder.MapRoute(
                "GetBlobView",
                "{userName}/{repoName}/blob/{id}/{*path}",
                new { controller = "FileView", action = "GetBlobView" },
                new { method = new HttpMethodRouteConstraint("GET") }
            );

            routeBuilder.MapRoute(
                "GetRawBlob",
                "{userName}/{repoName}/raw/{id}/{*path}",
                new { controller = "FileView", action = "GetRawBlob" },
                new { method = new HttpMethodRouteConstraint("GET") }
            );
            #endregion

            //var BspBannedipsService = Ioc.Create<IBspBannedipsService>();
            //Console.WriteLine("测试测试测试" + BspBannedipsService.CheckIP(Web.Ip).Result);
        }
    }
}
