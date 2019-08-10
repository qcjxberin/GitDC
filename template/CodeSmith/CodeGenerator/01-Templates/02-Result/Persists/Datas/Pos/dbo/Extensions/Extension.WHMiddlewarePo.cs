using Ding;
using GitDC.Domain.Models;
using Ding.Maps;

namespace GitDC.Data.Pos.dbo.Extensions {
    /// <summary>
    /// 网络勾子中转表持久化对象扩展
    /// </summary>
    public static partial class Extension {
        /// <summary>
        /// 转换为网络勾子中转表实体
        /// </summary>
        /// <param name="po">网络勾子中转表持久化对象</param>
        public static WHMiddleware ToEntity( this WHMiddlewarePo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new WHMiddleware( po.Id ) );
        }
        
        /// <summary>
        /// 转换为网络勾子中转表实体
        /// </summary>
        /// <param name="po">网络勾子中转表持久化对象</param>
        private static WHMiddleware ToEntity2( this WHMiddlewarePo po ) {
            if( po == null )
                return null;
            return new WHMiddleware( po.Id ) {
                Name = po.Name,
                Summary = po.Summary,
                Token = po.Token,
                Source = po.Source,
                Push = po.Push,
                PushUrl = po.PushUrl,
                PushToken = po.PushToken,
                CreationTime = po.CreationTime,
                CreatId = po.CreatId,
                LastModifiTime = po.LastModifiTime,
                LastModifiId = po.LastModifiId,
                IsDeleted = po.IsDeleted,
                Version = po.Version,
            };
        }
        
        /// <summary>
        /// 转换为网络勾子中转表持久化对象
        /// </summary>
        /// <param name="entity">网络勾子中转表实体</param>
        public static WHMiddlewarePo ToPo(this WHMiddleware entity) {
            if( entity == null )
                return null;
            return entity.MapTo<WHMiddlewarePo>();
        }

        /// <summary>
        /// 转换为网络勾子中转表持久化对象
        /// </summary>
        /// <param name="entity">网络勾子中转表实体</param>
        private static WHMiddlewarePo ToPo2( this WHMiddleware entity ) {
            if( entity == null )
                return null;
            return new WHMiddlewarePo {
                Id = entity.Id,
                Name = entity.Name,
                Summary = entity.Summary,
                Token = entity.Token,
                Source = entity.Source,
                Push = entity.Push,
                PushUrl = entity.PushUrl,
                PushToken = entity.PushToken,
                CreationTime = entity.CreationTime,
                CreatId = entity.CreatId,
                LastModifiTime = entity.LastModifiTime,
                LastModifiId = entity.LastModifiId,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}
