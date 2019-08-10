using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using Ding.Datas.Ef.Core;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 网络勾子推送内容日志仓储
    /// </summary>
    public class WHLogsRepository : RepositoryBase<WHLogs>, IWHLogsRepository {
        /// <summary>
        /// 初始化网络勾子推送内容日志仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public WHLogsRepository( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}