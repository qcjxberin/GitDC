using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class TeamRepositoryRoleDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static TeamRepositoryRole ToEntity( this TeamRepositoryRoleDto dto ) {
            if ( dto == null )
                return new TeamRepositoryRole();
            return dto.MapTo( new TeamRepositoryRole( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static TeamRepositoryRole ToEntity2( this TeamRepositoryRoleDto dto ) {
            if( dto == null )
                return new TeamRepositoryRole();
            return new TeamRepositoryRole( dto.Id.ToGuid() ) {
                TeamID = dto.TeamID,
                RepositoryID = dto.RepositoryID,
                    AllowRead = dto.AllowRead.SafeValue(),
                    AllowWrite = dto.AllowWrite.SafeValue(),
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static TeamRepositoryRole ToEntity3( this TeamRepositoryRoleDto dto ) {
        //    if( dto == null )
        //        return new TeamRepositoryRole();
        //    return TeamRepositoryRoleFactory.Create(
        //        
        //        
        //        id : dto.Id.ToGuid(),
        //        
        //        
        //        teamID : dto.TeamID,
        //        
        //        
        //        repositoryID : dto.RepositoryID,
        //        
        //        
        //        allowRead : dto.AllowRead,
        //        
        //        
        //        allowWrite : dto.AllowWrite
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static TeamRepositoryRoleDto ToDto(this TeamRepositoryRole entity) {
            if( entity == null )
                return new TeamRepositoryRoleDto();
            return entity.MapTo<TeamRepositoryRoleDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static TeamRepositoryRoleDto ToDto2( this TeamRepositoryRole entity ) {
        //    if( entity == null )
        //        return new TeamRepositoryRoleDto();
        //    return new TeamRepositoryRoleDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        TeamID = entity.TeamID,
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
        //    };
        //}
    }
}