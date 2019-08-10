using Ding.Webs.Controllers;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Apis.dbo {
    /// <summary>
    /// 控制器
    /// </summary>
    public class TeamsController : CrudControllerBase<TeamsDto, TeamsQuery> {
        /// <summary>
        /// 初始化控制器
        /// </summary>
        /// <param name="service">服务</param>
        public TeamsController( ITeamsService service ) : base( service ) {
            TeamsService = service;
        }

        /// <summary>
        /// 服务
        /// </summary>
        public ITeamsService TeamsService { get; }
    }
}