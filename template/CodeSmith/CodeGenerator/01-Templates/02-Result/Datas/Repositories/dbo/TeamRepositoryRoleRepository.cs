using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 仓储
    /// </summary>
    public class TeamRepositoryRoleRepository : RepositoryBase<TeamRepositoryRole>, ITeamRepositoryRoleRepository {
        /// <summary>
        /// 初始化仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public TeamRepositoryRoleRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}