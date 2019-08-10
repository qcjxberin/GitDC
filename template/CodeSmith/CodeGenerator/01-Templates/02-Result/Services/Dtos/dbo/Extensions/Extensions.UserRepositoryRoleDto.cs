using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class UserRepositoryRoleDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static UserRepositoryRole ToEntity( this UserRepositoryRoleDto dto ) {
            if ( dto == null )
                return new UserRepositoryRole();
            return dto.MapTo( new UserRepositoryRole( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static UserRepositoryRole ToEntity2( this UserRepositoryRoleDto dto ) {
            if( dto == null )
                return new UserRepositoryRole();
            return new UserRepositoryRole( dto.Id.ToGuid() ) {
                UserID = dto.UserID,
                RepositoryID = dto.RepositoryID,
                    AllowRead = dto.AllowRead.SafeValue(),
                    AllowWrite = dto.AllowWrite.SafeValue(),
                    IsOwner = dto.IsOwner.SafeValue(),
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static UserRepositoryRole ToEntity3( this UserRepositoryRoleDto dto ) {
        //    if( dto == null )
        //        return new UserRepositoryRole();
        //    return UserRepositoryRoleFactory.Create(
        //        
        //        
        //        id : dto.Id.ToGuid(),
        //        
        //        
        //        userID : dto.UserID,
        //        
        //        
        //        repositoryID : dto.RepositoryID,
        //        
        //        
        //        allowRead : dto.AllowRead,
        //        
        //        
        //        allowWrite : dto.AllowWrite,
        //        
        //        
        //        isOwner : dto.IsOwner
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static UserRepositoryRoleDto ToDto(this UserRepositoryRole entity) {
            if( entity == null )
                return new UserRepositoryRoleDto();
            return entity.MapTo<UserRepositoryRoleDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static UserRepositoryRoleDto ToDto2( this UserRepositoryRole entity ) {
        //    if( entity == null )
        //        return new UserRepositoryRoleDto();
        //    return new UserRepositoryRoleDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        UserID = entity.UserID,
        //        
        //        
        //        RepositoryID = entity.RepositoryID,
        //        
        //        
        //        AllowRead = entity.AllowRead,
        //        
        //        
        //        AllowWrite = entity.AllowWrite,
        //        
        //        
        //        IsOwner = entity.IsOwner,
        //        
        //    };
        //}
    }
}