using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class UserRepositoryRoleFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userID"></param>
        /// <param name="repositoryID"></param>
        /// <param name="allowRead"></param>
        /// <param name="allowWrite"></param>
        /// <param name="isOwner"></param>
        public static UserRepositoryRole Create( 
            Guid id,
            long userID,
            long repositoryID,
            bool allowRead,
            bool allowWrite,
            bool isOwner
        ) {
            UserRepositoryRole result;
            result = new UserRepositoryRole( id );
            result.UserID = userID;
            result.RepositoryID = repositoryID;
            result.AllowRead = allowRead;
            result.AllowWrite = allowWrite;
            result.IsOwner = isOwner;
            return result;
        }
    }
}