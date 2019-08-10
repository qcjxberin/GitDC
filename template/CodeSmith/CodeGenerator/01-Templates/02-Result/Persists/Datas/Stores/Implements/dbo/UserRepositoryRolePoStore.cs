using Ding.Datas.Ef.Core;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Data.Stores.Implements.dbo{
    /// <summary>
    /// 存储器
    /// </summary>
    public class UserRepositoryRolePoStore : StoreBase<UserRepositoryRolePo>, IUserRepositoryRolePoStore {
        /// <summary>
        /// 初始化存储器
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UserRepositoryRolePoStore( IGitDCUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}