using Ding.Datas.Ef.Core;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Data.Stores.Implements.dbo{
    /// <summary>
    /// 用户名存储器
    /// </summary>
    public class DCUsersPoStore : StoreBase<DCUsersPo,long>, IDCUsersPoStore {
        /// <summary>
        /// 初始化用户名存储器
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DCUsersPoStore( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}