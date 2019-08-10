using Ding.Webs.Controllers;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Apis.dbo {
    /// <summary>
    /// 网络勾子中转表控制器
    /// </summary>
    public class WHMiddlewareController : CrudControllerBase<WHMiddlewareDto, WHMiddlewareQuery> {
        /// <summary>
        /// 初始化网络勾子中转表控制器
        /// </summary>
        /// <param name="service">网络勾子中转表服务</param>
        public WHMiddlewareController( IWHMiddlewareService service ) : base( service ) {
            WHMiddlewareService = service;
        }

        /// <summary>
        /// 网络勾子中转表服务
        /// </summary>
        public IWHMiddlewareService WHMiddlewareService { get; }
    }
}