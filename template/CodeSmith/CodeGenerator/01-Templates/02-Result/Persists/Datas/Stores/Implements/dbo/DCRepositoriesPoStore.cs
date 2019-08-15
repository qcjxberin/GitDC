using Ding.Datas.Ef.Core;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Data.Stores.Implements.dbo{
    /// <summary>
    /// 仓库表存储器
    /// </summary>
    public class DCRepositoriesPoStore : StoreBase<DCRepositoriesPo>, IDCRepositoriesPoStore {
        /// <summary>
        /// 初始化仓库表存储器
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DCRepositoriesPoStore( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}