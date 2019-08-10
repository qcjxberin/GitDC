using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class UserTeamRoleDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static UserTeamRole ToEntity( this UserTeamRoleDto dto ) {
            if ( dto == null )
                return new UserTeamRole();
            return dto.MapTo( new UserTeamRole( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static UserTeamRole ToEntity2( this UserTeamRoleDto dto ) {
            if( dto == null )
                return new UserTeamRole();
            return new UserTeamRole( dto.Id.ToGuid() ) {
                UserID = dto.UserID,
                TeamID = dto.TeamID,
                    IsAdministrator = dto.IsAdministrator.SafeValue(),
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static UserTeamRole ToEntity3( this UserTeamRoleDto dto ) {
        //    if( dto == null )
        //        return new UserTeamRole();
        //    return UserTeamRoleFactory.Create(
        //        
        //        
        //        id : dto.Id.ToGuid(),
        //        
        //        
        //        userID : dto.UserID,
        //        
        //        
        //        teamID : dto.TeamID,
        //        
        //        
        //        isAdministrator : dto.IsAdministrator
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static UserTeamRoleDto ToDto(this UserTeamRole entity) {
            if( entity == null )
                return new UserTeamRoleDto();
            return entity.MapTo<UserTeamRoleDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static UserTeamRoleDto ToDto2( this UserTeamRole entity ) {
        //    if( entity == null )
        //        return new UserTeamRoleDto();
        //    return new UserTeamRoleDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        UserID = entity.UserID,
        //        
        //        
        //        TeamID = entity.TeamID,
        //        
        //        
        //        IsAdministrator = entity.IsAdministrator,
        //        
        //    };
        //}
    }
}