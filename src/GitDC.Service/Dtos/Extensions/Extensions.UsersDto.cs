using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 用户名数据传输对象扩展
    /// </summary>
    public static class UsersDtoExtension {
        /// <summary>
        /// 转换为用户名实体
        /// </summary>
        /// <param name="dto">用户名数据传输对象</param>
        public static Users ToEntity( this UsersDto dto ) {
            if ( dto == null )
                return new Users();
            return dto.MapTo( new Users( dto.Id.ToLong() ) );
        }
        
        /// <summary>
        /// 转换为用户名实体
        /// </summary>
        /// <param name="dto">用户名数据传输对象</param>
        public static Users ToEntity2( this UsersDto dto ) {
            if( dto == null )
                return new Users();
            return new Users( dto.Id.ToLong() ) {
                Name = dto.Name,
                NickName = dto.NickName,
                Email = dto.Email,
                PasswordVersion = dto.PasswordVersion,
                Password = dto.Password,
                Description = dto.Description,
                    IsSystemAdministrator = dto.IsSystemAdministrator.SafeValue(),
                CreationTime = dto.CreationTime,
                CreatId = dto.CreatId,
                LastModifiTime = dto.LastModifiTime,
                LastModifiId = dto.LastModifiId,
                    IsDeleted = dto.IsDeleted.SafeValue(),
                Version = dto.Version,
            };
        }
        
        ///// <summary>
        ///// 转换为用户名实体
        ///// </summary>
        ///// <param name="dto">用户名数据传输对象</param>
        //public static Users ToEntity3( this UsersDto dto ) {
        //    if( dto == null )
        //        return new Users();
        //    return UsersFactory.Create(
        //        
        //        
        //        id : dto.Id.ToLong(),
        //        
        //        
        //        name : dto.Name,
        //        
        //        
        //        nickName : dto.NickName,
        //        
        //        
        //        email : dto.Email,
        //        
        //        
        //        passwordVersion : dto.PasswordVersion,
        //        
        //        
        //        password : dto.Password,
        //        
        //        
        //        description : dto.Description,
        //        
        //        
        //        isSystemAdministrator : dto.IsSystemAdministrator,
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
        /// 转换为用户名数据传输对象
        /// </summary>
        /// <param name="entity">用户名实体</param>
        public static UsersDto ToDto(this Users entity) {
            if( entity == null )
                return new UsersDto();
            return entity.MapTo<UsersDto>();
        }

        ///// <summary>
        ///// 转换为用户名数据传输对象
        ///// </summary>
        ///// <param name="entity">用户名实体</param>
        //public static UsersDto ToDto2( this Users entity ) {
        //    if( entity == null )
        //        return new UsersDto();
        //    return new UsersDto {
        //        
        //        
        //        Id = entity.Id,
        //        
        //        
        //        Name = entity.Name,
        //        
        //        
        //        NickName = entity.NickName,
        //        
        //        
        //        Email = entity.Email,
        //        
        //        
        //        PasswordVersion = entity.PasswordVersion,
        //        
        //        
        //        Password = entity.Password,
        //        
        //        
        //        Description = entity.Description,
        //        
        //        
        //        IsSystemAdministrator = entity.IsSystemAdministrator,
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