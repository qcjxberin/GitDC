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
        public static Teams ToEntity( this TeamsPo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new Teams( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static Teams ToEntity2( this TeamsPo po ) {
            if( po == null )
                return null;
            return new Teams( po.Id ) {
                Name = po.Name,
                Description = po.Description,
                CreationDate = po.CreationDate,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static TeamsPo ToPo(this Teams entity) {
            if( entity == null )
                return null;
            return entity.MapTo<TeamsPo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static TeamsPo ToPo2( this Teams entity ) {
            if( entity == null )
                return null;
            return new TeamsPo {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                CreationDate = entity.CreationDate,
            };
        }
    }
}
