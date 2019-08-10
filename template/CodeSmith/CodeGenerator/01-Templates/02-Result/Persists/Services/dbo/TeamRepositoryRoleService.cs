using Ding;
using Ding.Maps;
using Ding.Domains.Repositories;
using Ding.Datas.Queries;
using Ding.Applications;
using GitDC.Data;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Service.Implements.dbo {
    /// <summary>
    /// 服务
    /// </summary>
    public class TeamRepositoryRoleService : CrudServiceBase<TeamRepositoryRolePo, TeamRepositoryRoleDto, TeamRepositoryRoleQuery>, ITeamRepositoryRoleService {
        /// <summary>
        /// 初始化服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="teamRepositoryRoleStore">存储器</param>
        public TeamRepositoryRoleService( IGitDCUnitOfWork unitOfWork, ITeamRepositoryRolePoStore teamRepositoryRoleStore )
            : base( unitOfWork, teamRepositoryRoleStore ) {
            TeamRepositoryRoleStore = teamRepositoryRoleStore;
        }
        
        /// <summary>
        /// 存储器
        /// </summary>
        public ITeamRepositoryRolePoStore TeamRepositoryRoleStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<TeamRepositoryRolePo> CreateQuery( TeamRepositoryRoleQuery param ) {
            return new Query<TeamRepositoryRolePo>( param );
        }
    }
}