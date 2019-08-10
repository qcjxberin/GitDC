using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class AuthorizationLogDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static AuthorizationLog ToEntity( this AuthorizationLogDto dto ) {
            if ( dto == null )
                return new AuthorizationLog();
            return dto.MapTo( new AuthorizationLog( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static AuthorizationLog ToEntity2( this AuthorizationLogDto dto ) {
            if( dto == null )
                return new AuthorizationLog();
            return new AuthorizationLog( dto.Id.ToGuid() ) {
                UserID = dto.UserID,
                IssueDate = dto.IssueDate,
                Expires = dto.Expires,
                IssueIp = dto.IssueIp,
                LastIp = dto.LastIp,
                    IsValid = dto.IsValid.SafeValue(),
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static AuthorizationLog ToEntity3( this AuthorizationLogDto dto ) {
        //    if( dto == null )
        //        return new AuthorizationLog();
        //    return AuthorizationLogFactory.Create(
        //        
        //        
        //        authCode : dto.Id.ToGuid(),
        //        
        //        
        //        userID : dto.UserID,
        //        
        //        
        //        issueDate : dto.IssueDate,
        //        
        //        
        //        expires : dto.Expires,
        //        
        //        
        //        issueIp : dto.IssueIp,
        //        
        //        
        //        lastIp : dto.LastIp,
        //        
        //        
        //        isValid : dto.IsValid
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static AuthorizationLogDto ToDto(this AuthorizationLog entity) {
            if( entity == null )
                return new AuthorizationLogDto();
            return entity.MapTo<AuthorizationLogDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static AuthorizationLogDto ToDto2( this AuthorizationLog entity ) {
        //    if( entity == null )
        //        return new AuthorizationLogDto();
        //    return new AuthorizationLogDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        UserID = entity.UserID,
        //        
        //        
        //        IssueDate = entity.IssueDate,
        //        
        //        
        //        Expires = entity.Expires,
        //        
        //        
        //        IssueIp = entity.IssueIp,
        //        
        //        
        //        LastIp = entity.LastIp,
        //        
        //        
        //        IsValid = entity.IsValid,
        //        
        //    };
        //}
    }
}