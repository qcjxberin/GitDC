using Ding;
using GitDC.Domain.Models;
using Ding.Maps;

namespace GitDC.Data.Pos.dbo.Extensions {
    /// <summary>
    /// 持久化对象扩展
    /// </summary>
    public static partial class Extension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        public static UserRepositoryRole ToEntity( this UserRepositoryRolePo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new UserRepositoryRole( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static UserRepositoryRole ToEntity2( this UserRepositoryRolePo po ) {
            if( po == null )
                return null;
            return new UserRepositoryRole( po.Id ) {
                UserID = po.UserID,
                RepositoryID = po.RepositoryID,
                AllowRead = po.AllowRead,
                AllowWrite = po.AllowWrite,
                IsOwner = po.IsOwner,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static UserRepositoryRolePo ToPo(this UserRepositoryRole entity) {
            if( entity == null )
                return null;
            return entity.MapTo<UserRepositoryRolePo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static UserRepositoryRolePo ToPo2( this UserRepositoryRole entity ) {
            if( entity == null )
                return null;
            return new UserRepositoryRolePo {
                Id = entity.Id,
                UserID = entity.UserID,
                RepositoryID = entity.RepositoryID,
                AllowRead = entity.AllowRead,
                AllowWrite = entity.AllowWrite,
                IsOwner = entity.IsOwner,
            };
        }
    }
}
