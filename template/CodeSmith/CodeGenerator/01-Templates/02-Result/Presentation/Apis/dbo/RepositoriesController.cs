using Ding.Webs.Controllers;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Apis.dbo {
    /// <summary>
    /// 仓库表控制器
    /// </summary>
    public class RepositoriesController : CrudControllerBase<RepositoriesDto, RepositoriesQuery> {
        /// <summary>
        /// 初始化仓库表控制器
        /// </summary>
        /// <param name="service">仓库表服务</param>
        public RepositoriesController( IRepositoriesService service ) : base( service ) {
            RepositoriesService = service;
        }

        /// <summary>
        /// 仓库表服务
        /// </summary>
        public IRepositoriesService RepositoriesService { get; }
    }
}