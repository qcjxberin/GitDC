using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class TeamsDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static Teams ToEntity( this TeamsDto dto ) {
            if ( dto == null )
                return new Teams();
            return dto.MapTo( new Teams( dto.Id.ToLong() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static Teams ToEntity2( this TeamsDto dto ) {
            if( dto == null )
                return new Teams();
            return new Teams( dto.Id.ToLong() ) {
                Name = dto.Name,
                Description = dto.Description,
                CreationDate = dto.CreationDate,
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static Teams ToEntity3( this TeamsDto dto ) {
        //    if( dto == null )
        //        return new Teams();
        //    return TeamsFactory.Create(
        //        
        //        
        //        id : dto.Id.ToLong(),
        //        
        //        
        //        name : dto.Name,
        //        
        //        
        //        description : dto.Description,
        //        
        //        
        //        creationDate : dto.CreationDate
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static TeamsDto ToDto(this Teams entity) {
            if( entity == null )
                return new TeamsDto();
            return entity.MapTo<TeamsDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static TeamsDto ToDto2( this Teams entity ) {
        //    if( entity == null )
        //        return new TeamsDto();
        //    return new TeamsDto {
        //        
        //        
        //        Id = entity.Id,
        //        
        //        
        //        Name = entity.Name,
        //        
        //        
        //        Description = entity.Description,
        //        
        //        
        //        CreationDate = entity.CreationDate,
        //        
        //    };
        //}
    }
}