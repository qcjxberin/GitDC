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
        public static AuthorizationLog ToEntity( this AuthorizationLogPo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new AuthorizationLog( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static AuthorizationLog ToEntity2( this AuthorizationLogPo po ) {
            if( po == null )
                return null;
            return new AuthorizationLog( po.Id ) {
                UserID = po.UserID,
                IssueDate = po.IssueDate,
                Expires = po.Expires,
                IssueIp = po.IssueIp,
                LastIp = po.LastIp,
                IsValid = po.IsValid,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static AuthorizationLogPo ToPo(this AuthorizationLog entity) {
            if( entity == null )
                return null;
            return entity.MapTo<AuthorizationLogPo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static AuthorizationLogPo ToPo2( this AuthorizationLog entity ) {
            if( entity == null )
                return null;
            return new AuthorizationLogPo {
                Id = entity.Id,
                UserID = entity.UserID,
                IssueDate = entity.IssueDate,
                Expires = entity.Expires,
                IssueIp = entity.IssueIp,
                LastIp = entity.LastIp,
                IsValid = entity.IsValid,
            };
        }
    }
}
