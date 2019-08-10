using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class RepositoriesDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static Repositories ToEntity( this RepositoriesDto dto ) {
            if ( dto == null )
                return new Repositories();
            return dto.MapTo( new Repositories( dto.Id.ToLong() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static Repositories ToEntity2( this RepositoriesDto dto ) {
            if( dto == null )
                return new Repositories();
            return new Repositories( dto.Id.ToLong() ) {
                Name = dto.Name,
                Description = dto.Description,
                CreationDate = dto.CreationDate,
                    IsPrivate = dto.IsPrivate.SafeValue(),
                    AllowAnonymousRead = dto.AllowAnonymousRead.SafeValue(),
                    AllowAnonymousWrite = dto.AllowAnonymousWrite.SafeValue(),
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static Repositories ToEntity3( this RepositoriesDto dto ) {
        //    if( dto == null )
        //        return new Repositories();
        //    return RepositoriesFactory.Create(
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
        //        creationDate : dto.CreationDate,
        //        
        //        
        //        isPrivate : dto.IsPrivate,
        //        
        //        
        //        allowAnonymousRead : dto.AllowAnonymousRead,
        //        
        //        
        //        allowAnonymousWrite : dto.AllowAnonymousWrite
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static RepositoriesDto ToDto(this Repositories entity) {
            if( entity == null )
                return new RepositoriesDto();
            return entity.MapTo<RepositoriesDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static RepositoriesDto ToDto2( this Repositories entity ) {
        //    if( entity == null )
        //        return new RepositoriesDto();
        //    return new RepositoriesDto {
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
        //        
        //        IsPrivate = entity.IsPrivate,
        //        
        //        
        //        AllowAnonymousRead = entity.AllowAnonymousRead,
        //        
        //        
        //        AllowAnonymousWrite = entity.AllowAnonymousWrite,
        //        
        //    };
        //}
    }
}