using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 仓库表仓储
    /// </summary>
    public class DCRepositoriesRepository : RepositoryBase<DCRepositories>, IDCRepositoriesRepository {
        /// <summary>
        /// 初始化仓库表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DCRepositoriesRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}