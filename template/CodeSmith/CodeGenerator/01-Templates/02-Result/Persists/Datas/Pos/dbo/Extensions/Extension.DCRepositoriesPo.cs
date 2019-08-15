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
        public static DCRepositories ToEntity( this DCRepositoriesPo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new DCRepositories( po.Id ) );
        }
        
        /// <summary>
        /// 转换为仓库表实体
        /// </summary>
        /// <param name="po">仓库表持久化对象</param>
        private static DCRepositories ToEntity2( this DCRepositoriesPo po ) {
            if( po == null )
                return null;
            return new DCRepositories( po.Id ) {
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
        public static DCRepositoriesPo ToPo(this DCRepositories entity) {
            if( entity == null )
                return null;
            return entity.MapTo<DCRepositoriesPo>();
        }

        /// <summary>
        /// 转换为仓库表持久化对象
        /// </summary>
        /// <param name="entity">仓库表实体</param>
        private static DCRepositoriesPo ToPo2( this DCRepositories entity ) {
            if( entity == null )
                return null;
            return new DCRepositoriesPo {
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
