using Ding.Mvc.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace GitDC.Common
{
    /// <summary>
    /// 表示提供通用路由的提供程序
    /// </summary>
    public partial class GenericUrlRouteProvider : IRouteProvider
    {
        /// <summary>
        /// 获取路由提供程序的优先级
        /// </summary>
        public int Priority
        {
            //应该是最后一条路由。 我们不将其设置为-int.MaxValue，因此可以覆盖它（如果需要）
            get { return -1000000; }
        }

        /// <summary>
        /// 注册路由
        /// </summary>
        /// <param name="routeBuilder">路由构建器</param>
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            // 默认路由
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");

            // 默认API路由
            routeBuilder.MapRoute("Api", "{controller}/{id?}");
        }
    }
}
