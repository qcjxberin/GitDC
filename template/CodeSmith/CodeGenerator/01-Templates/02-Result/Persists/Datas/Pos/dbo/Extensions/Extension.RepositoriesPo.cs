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
        public static Repositories ToEntity( this RepositoriesPo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new Repositories( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static Repositories ToEntity2( this RepositoriesPo po ) {
            if( po == null )
                return null;
            return new Repositories( po.Id ) {
                Name = po.Name,
                Description = po.Description,
                CreationDate = po.CreationDate,
                IsPrivate = po.IsPrivate,
                AllowAnonymousRead = po.AllowAnonymousRead,
                AllowAnonymousWrite = po.AllowAnonymousWrite,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static RepositoriesPo ToPo(this Repositories entity) {
            if( entity == null )
                return null;
            return entity.MapTo<RepositoriesPo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static RepositoriesPo ToPo2( this Repositories entity ) {
            if( entity == null )
                return null;
            return new RepositoriesPo {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                CreationDate = entity.CreationDate,
                IsPrivate = entity.IsPrivate,
                AllowAnonymousRead = entity.AllowAnonymousRead,
                AllowAnonymousWrite = entity.AllowAnonymousWrite,
            };
        }
    }
}
