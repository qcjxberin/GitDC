using Ding.Webs.Controllers;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Apis.dbo {
    /// <summary>
    /// 网络勾子推送内容日志控制器
    /// </summary>
    public class WHLogsController : CrudControllerBase<WHLogsDto, WHLogsQuery> {
        /// <summary>
        /// 初始化网络勾子推送内容日志控制器
        /// </summary>
        /// <param name="service">网络勾子推送内容日志服务</param>
        public WHLogsController( IWHLogsService service ) : base( service ) {
            WHLogsService = service;
        }

        /// <summary>
        /// 网络勾子推送内容日志服务
        /// </summary>
        public IWHLogsService WHLogsService { get; }
    }
}