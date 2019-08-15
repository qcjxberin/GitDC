using Ding;
using GitDC.Domain.Models;
using Ding.Maps;

namespace GitDC.Data.Pos.dbo.Extensions {
    /// <summary>
    /// 仓库表持久化对象扩展
    /// </summary>
    public static partial class Extension {
        /// <summary>
        /// 转换为仓库表实体
        /// </summary>
        /// <param name="po">仓库表持久化对象</param>
        public static Repositories ToEntity( this RepositoriesPo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new Repositories( po.Id ) );
        }
        
        /// <summary>
        /// 转换为仓库表实体
        /// </summary>
        /// <param name="po">仓库表持久化对象</param>
        private static Repositories ToEntity2( this RepositoriesPo po ) {
            if( po == null )
                return null;
            return new Repositories( po.Id ) {
                DefaultBranch = po.DefaultBranch,
                Description = po.Description,
                IsMirror = po.IsMirror,
                IsPrivate = po.IsPrivate,
                Name = po.Name,
                NumIssues = po.NumIssues,
                NumOpenIssues = po.NumOpenIssues,
                NumOpenPulls = po.NumOpenPulls,
                NumPulls = po.NumPulls,
                Size = po.Size,
                UserID = po.UserID,
                UserName = po.UserName,
                CreationTime = po.CreationTime,
                LastModifiTime = po.LastModifiTime,
                IsDeleted = po.IsDeleted,
                Version = po.Version,
            };
        }
        
        /// <summary>
        /// 转换为仓库表持久化对象
        /// </summary>
        /// <param name="entity">仓库表实体</param>
        public static RepositoriesPo ToPo(this Repositories entity) {
            if( entity == null )
                return null;
            return entity.MapTo<RepositoriesPo>();
        }

        /// <summary>
        /// 转换为仓库表持久化对象
        /// </summary>
        /// <param name="entity">仓库表实体</param>
        private static RepositoriesPo ToPo2( this Repositories entity ) {
            if( entity == null )
                return null;
            return new RepositoriesPo {
                Id = entity.Id,
                DefaultBranch = entity.DefaultBranch,
                Description = entity.Description,
                IsMirror = entity.IsMirror,
                IsPrivate = entity.IsPrivate,
                Name = entity.Name,
                NumIssues = entity.NumIssues,
                NumOpenIssues = entity.NumOpenIssues,
                NumOpenPulls = entity.NumOpenPulls,
                NumPulls = entity.NumPulls,
                Size = entity.Size,
                UserID = entity.UserID,
                UserName = entity.UserName,
                CreationTime = entity.CreationTime,
                LastModifiTime = entity.LastModifiTime,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}
