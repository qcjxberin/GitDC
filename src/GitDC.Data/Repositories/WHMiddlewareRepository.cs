using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 网络勾子中转表仓储
    /// </summary>
    public class WHMiddlewareRepository : RepositoryBase<WHMiddleware>, IWHMiddlewareRepository {
        /// <summary>
        /// 初始化网络勾子中转表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public WHMiddlewareRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}