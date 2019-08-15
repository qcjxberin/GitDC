using Ding.Webs.Controllers;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Apis.dbo {
    /// <summary>
    /// 仓库表控制器
    /// </summary>
    public class DCRepositoriesController : CrudControllerBase<DCRepositoriesDto, DCRepositoriesQuery> {
        /// <summary>
        /// 初始化仓库表控制器
        /// </summary>
        /// <param name="service">仓库表服务</param>
        public DCRepositoriesController( IDCRepositoriesService service ) : base( service ) {
            DCRepositoriesService = service;
        }

        /// <summary>
        /// 仓库表服务
        /// </summary>
        public IDCRepositoriesService DCRepositoriesService { get; }
    }
}