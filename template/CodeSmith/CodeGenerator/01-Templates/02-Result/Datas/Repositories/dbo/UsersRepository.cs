using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 用户名仓储
    /// </summary>
    public class UsersRepository : RepositoryBase<Users,long>, IUsersRepository {
        /// <summary>
        /// 初始化用户名仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UsersRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}