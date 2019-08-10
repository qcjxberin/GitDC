using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 用户名数据传输对象扩展
    /// </summary>
    public static class DCUsersDtoExtension {
        /// <summary>
        /// 转换为用户名实体
        /// </summary>
        /// <param name="dto">用户名数据传输对象</param>
        public static DCUsers ToEntity( this DCUsersDto dto ) {
            if ( dto == null )
                return new DCUsers();
            return dto.MapTo( new DCUsers( dto.Id.ToLong() ) );
        }
        
        /// <summary>
        /// 转换为用户名实体
        /// </summary>
        /// <param name="dto">用户名数据传输对象</param>
        public static DCUsers ToEntity2( this DCUsersDto dto ) {
            if( dto == null )
                return new DCUsers();
            return new DCUsers( dto.Id.ToLong() ) {
                Name = dto.Name,
                NickName = dto.NickName,
                Email = dto.Email,
                PasswordVersion = dto.PasswordVersion,
                Password = dto.Password,
                Salt = dto.Salt,
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
        //public static DCUsers ToEntity3( this DCUsersDto dto ) {
        //    if( dto == null )
        //        return new DCUsers();
        //    return DCUsersFactory.Create(
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
        //        salt : dto.Salt,
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
        public static DCUsersDto ToDto(this DCUsers entity) {
            if( entity == null )
                return new DCUsersDto();
            return entity.MapTo<DCUsersDto>();
        }

        ///// <summary>
        ///// 转换为用户名数据传输对象
        ///// </summary>
        ///// <param name="entity">用户名实体</param>
        //public static DCUsersDto ToDto2( this DCUsers entity ) {
        //    if( entity == null )
        //        return new DCUsersDto();
        //    return new DCUsersDto {
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
        //        Salt = entity.Salt,
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