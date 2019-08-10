using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 仓储
    /// </summary>
    public class TeamsRepository : RepositoryBase<Teams,long>, ITeamsRepository {
        /// <summary>
        /// 初始化仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public TeamsRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}