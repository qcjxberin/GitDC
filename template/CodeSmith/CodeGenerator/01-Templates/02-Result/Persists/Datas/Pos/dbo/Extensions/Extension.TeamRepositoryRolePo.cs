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
        public static TeamRepositoryRole ToEntity( this TeamRepositoryRolePo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new TeamRepositoryRole( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static TeamRepositoryRole ToEntity2( this TeamRepositoryRolePo po ) {
            if( po == null )
                return null;
            return new TeamRepositoryRole( po.Id ) {
                TeamID = po.TeamID,
                RepositoryID = po.RepositoryID,
                AllowRead = po.AllowRead,
                AllowWrite = po.AllowWrite,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static TeamRepositoryRolePo ToPo(this TeamRepositoryRole entity) {
            if( entity == null )
                return null;
            return entity.MapTo<TeamRepositoryRolePo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static TeamRepositoryRolePo ToPo2( this TeamRepositoryRole entity ) {
            if( entity == null )
                return null;
            return new TeamRepositoryRolePo {
                Id = entity.Id,
                TeamID = entity.TeamID,
                RepositoryID = entity.RepositoryID,
                AllowRead = entity.AllowRead,
                AllowWrite = entity.AllowWrite,
            };
        }
    }
}
