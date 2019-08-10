using Ding.Datas.Ef.Core;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Data.Stores.Implements.dbo{
    /// <summary>
    /// 网络勾子推送内容日志存储器
    /// </summary>
    public class WHLogsPoStore : StoreBase<WHLogsPo>, IWHLogsPoStore {
        /// <summary>
        /// 初始化网络勾子推送内容日志存储器
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public WHLogsPoStore( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}