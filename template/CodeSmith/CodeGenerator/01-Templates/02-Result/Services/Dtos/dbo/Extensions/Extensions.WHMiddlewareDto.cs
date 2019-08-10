using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 网络勾子中转表数据传输对象扩展
    /// </summary>
    public static class WHMiddlewareDtoExtension {
        /// <summary>
        /// 转换为网络勾子中转表实体
        /// </summary>
        /// <param name="dto">网络勾子中转表数据传输对象</param>
        public static WHMiddleware ToEntity( this WHMiddlewareDto dto ) {
            if ( dto == null )
                return new WHMiddleware();
            return dto.MapTo( new WHMiddleware( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为网络勾子中转表实体
        /// </summary>
        /// <param name="dto">网络勾子中转表数据传输对象</param>
        public static WHMiddleware ToEntity2( this WHMiddlewareDto dto ) {
            if( dto == null )
                return new WHMiddleware();
            return new WHMiddleware( dto.Id.ToGuid() ) {
                Token = dto.Token,
                Source = dto.Source,
                Push = dto.Push,
                PushUrl = dto.PushUrl,
                PushToken = dto.PushToken,
                CreationTime = dto.CreationTime,
                CreatId = dto.CreatId,
                LastModifiTime = dto.LastModifiTime,
                LastModifiId = dto.LastModifiId,
                    IsDeleted = dto.IsDeleted.SafeValue(),
                Version = dto.Version,
            };
        }
        
        ///// <summary>
        ///// 转换为网络勾子中转表实体
        ///// </summary>
        ///// <param name="dto">网络勾子中转表数据传输对象</param>
        //public static WHMiddleware ToEntity3( this WHMiddlewareDto dto ) {
        //    if( dto == null )
        //        return new WHMiddleware();
        //    return WHMiddlewareFactory.Create(
        //        
        //        
        //        id : dto.Id.ToGuid(),
        //        
        //        
        //        token : dto.Token,
        //        
        //        
        //        source : dto.Source,
        //        
        //        
        //        push : dto.Push,
        //        
        //        
        //        pushUrl : dto.PushUrl,
        //        
        //        
        //        pushToken : dto.PushToken,
        //        
        //        
        //        creationTime : dto.CreationTime,
        //        
        //        
        //        creatId : dto.CreatId,
        //        
        //        
        //        lastModifiTime : dto.LastModifiTime,
        //        
        //        
        //        lastModifiId : dto.LastModifiId,
        //        
        //        
        //        isDeleted : dto.IsDeleted,
        //        
        //        
        //        version : dto.Version
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为网络勾子中转表数据传输对象
        /// </summary>
        /// <param name="entity">网络勾子中转表实体</param>
        public static WHMiddlewareDto ToDto(this WHMiddleware entity) {
            if( entity == null )
                return new WHMiddlewareDto();
            return entity.MapTo<WHMiddlewareDto>();
        }

        ///// <summary>
        ///// 转换为网络勾子中转表数据传输对象
        ///// </summary>
        ///// <param name="entity">网络勾子中转表实体</param>
        //public static WHMiddlewareDto ToDto2( this WHMiddleware entity ) {
        //    if( entity == null )
        //        return new WHMiddlewareDto();
        //    return new WHMiddlewareDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        Token = entity.Token,
        //        
        //        
        //        Source = entity.Source,
        //        
        //        
        //        Push = entity.Push,
        //        
        //        
        //        PushUrl = entity.PushUrl,
        //        
        //        
        //        PushToken = entity.PushToken,
        //        
        //        
        //        CreationTime = entity.CreationTime,
        //        
        //        
        //        CreatId = entity.CreatId,
        //        
        //        
        //        LastModifiTime = entity.LastModifiTime,
        //        
        //        
        //        LastModifiId = entity.LastModifiId,
        //        
        //        
        //        IsDeleted = entity.IsDeleted,
        //        
        //        
        //        Version = entity.Version,
        //        
        //    };
        //}
    }
}