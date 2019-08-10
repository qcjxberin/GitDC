using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 网络勾子推送内容日志数据传输对象扩展
    /// </summary>
    public static class WHLogsDtoExtension {
        /// <summary>
        /// 转换为网络勾子推送内容日志实体
        /// </summary>
        /// <param name="dto">网络勾子推送内容日志数据传输对象</param>
        public static WHLogs ToEntity( this WHLogsDto dto ) {
            if ( dto == null )
                return new WHLogs();
            return dto.MapTo( new WHLogs( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为网络勾子推送内容日志实体
        /// </summary>
        /// <param name="dto">网络勾子推送内容日志数据传输对象</param>
        public static WHLogs ToEntity2( this WHLogsDto dto ) {
            if( dto == null )
                return new WHLogs();
            return new WHLogs( dto.Id.ToGuid() ) {
                    WHTypes = dto.WHTypes.SafeValue(),
                Content = dto.Content,
                CreationTime = dto.CreationTime,
                    IsDeleted = dto.IsDeleted.SafeValue(),
                Version = dto.Version,
            };
        }
        
        ///// <summary>
        ///// 转换为网络勾子推送内容日志实体
        ///// </summary>
        ///// <param name="dto">网络勾子推送内容日志数据传输对象</param>
        //public static WHLogs ToEntity3( this WHLogsDto dto ) {
        //    if( dto == null )
        //        return new WHLogs();
        //    return WHLogsFactory.Create(
        //        
        //        
        //        id : dto.Id.ToGuid(),
        //        
        //        
        //        wHTypes : dto.WHTypes,
        //        
        //        
        //        content : dto.Content,
        //        
        //        
        //        creationTime : dto.CreationTime,
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
        /// 转换为网络勾子推送内容日志数据传输对象
        /// </summary>
        /// <param name="entity">网络勾子推送内容日志实体</param>
        public static WHLogsDto ToDto(this WHLogs entity) {
            if( entity == null )
                return new WHLogsDto();
            return entity.MapTo<WHLogsDto>();
        }

        ///// <summary>
        ///// 转换为网络勾子推送内容日志数据传输对象
        ///// </summary>
        ///// <param name="entity">网络勾子推送内容日志实体</param>
        //public static WHLogsDto ToDto2( this WHLogs entity ) {
        //    if( entity == null )
        //        return new WHLogsDto();
        //    return new WHLogsDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        WHTypes = entity.WHTypes,
        //        
        //        
        //        Content = entity.Content,
        //        
        //        
        //        CreationTime = entity.CreationTime,
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