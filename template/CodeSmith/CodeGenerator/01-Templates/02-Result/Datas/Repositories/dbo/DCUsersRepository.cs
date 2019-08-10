using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 用户名仓储
    /// </summary>
    public class DCUsersRepository : RepositoryBase<DCUsers,long>, IDCUsersRepository {
        /// <summary>
        /// 初始化用户名仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DCUsersRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}