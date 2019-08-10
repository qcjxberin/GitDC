using Ding.Datas.Ef.Core;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Data.Stores.Implements.dbo{
    /// <summary>
    /// 网络勾子中转表存储器
    /// </summary>
    public class WHMiddlewarePoStore : StoreBase<WHMiddlewarePo>, IWHMiddlewarePoStore {
        /// <summary>
        /// 初始化网络勾子中转表存储器
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public WHMiddlewarePoStore( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}