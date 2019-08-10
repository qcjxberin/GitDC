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
        public static UserTeamRole ToEntity( this UserTeamRolePo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new UserTeamRole( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static UserTeamRole ToEntity2( this UserTeamRolePo po ) {
            if( po == null )
                return null;
            return new UserTeamRole( po.Id ) {
                UserID = po.UserID,
                TeamID = po.TeamID,
                IsAdministrator = po.IsAdministrator,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static UserTeamRolePo ToPo(this UserTeamRole entity) {
            if( entity == null )
                return null;
            return entity.MapTo<UserTeamRolePo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static UserTeamRolePo ToPo2( this UserTeamRole entity ) {
            if( entity == null )
                return null;
            return new UserTeamRolePo {
                Id = entity.Id,
                UserID = entity.UserID,
                TeamID = entity.TeamID,
                IsAdministrator = entity.IsAdministrator,
            };
        }
    }
}
