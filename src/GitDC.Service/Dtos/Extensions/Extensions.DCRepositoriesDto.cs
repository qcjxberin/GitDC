using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 仓库表数据传输对象扩展
    /// </summary>
    public static class DCRepositoriesDtoExtension {
        /// <summary>
        /// 转换为仓库表实体
        /// </summary>
        /// <param name="dto">仓库表数据传输对象</param>
        public static DCRepositories ToEntity( this DCRepositoriesDto dto ) {
            if ( dto == null )
                return new DCRepositories();
            return dto.MapTo( new DCRepositories( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为仓库表实体
        /// </summary>
        /// <param name="dto">仓库表数据传输对象</param>
        public static DCRepositories ToEntity2( this DCRepositoriesDto dto ) {
            if( dto == null )
                return new DCRepositories();
            return new DCRepositories( dto.Id.ToGuid() ) {
                DefaultBranch = dto.DefaultBranch,
                Description = dto.Description,
                    IsMirror = dto.IsMirror.SafeValue(),
                    IsPrivate = dto.IsPrivate.SafeValue(),
                Name = dto.Name,
                NumIssues = dto.NumIssues,
                NumOpenIssues = dto.NumOpenIssues,
                NumOpenPulls = dto.NumOpenPulls,
                NumPulls = dto.NumPulls,
                Size = dto.Size,
                UserID = dto.UserID,
                UserName = dto.UserName,
                CreationTime = dto.CreationTime,
                LastModifiTime = dto.LastModifiTime,
                    IsDeleted = dto.IsDeleted.SafeValue(),
                Version = dto.Version,
            };
        }
        
        ///// <summary>
        ///// 转换为仓库表实体
        ///// </summary>
        ///// <param name="dto">仓库表数据传输对象</param>
        //public static DCRepositories ToEntity3( this DCRepositoriesDto dto ) {
        //    if( dto == null )
        //        return new DCRepositories();
        //    return DCRepositoriesFactory.Create(
        //        
        //        
        //        id : dto.Id.ToGuid(),
        //        
        //        
        //        defaultBranch : dto.DefaultBranch,
        //        
        //        
        //        description : dto.Description,
        //        
        //        
        //        isMirror : dto.IsMirror,
        //        
        //        
        //        isPrivate : dto.IsPrivate,
        //        
        //        
        //        name : dto.Name,
        //        
        //        
        //        numIssues : dto.NumIssues,
        //        
        //        
        //        numOpenIssues : dto.NumOpenIssues,
        //        
        //        
        //        numOpenPulls : dto.NumOpenPulls,
        //        
        //        
        //        numPulls : dto.NumPulls,
        //        
        //        
        //        size : dto.Size,
        //        
        //        
        //        userID : dto.UserID,
        //        
        //        
        //        userName : dto.UserName,
        //        
        //        
        //        creationTime : dto.CreationTime,
        //        
        //        
        //        lastModifiTime : dto.LastModifiTime,
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
        /// 转换为仓库表数据传输对象
        /// </summary>
        /// <param name="entity">仓库表实体</param>
        public static DCRepositoriesDto ToDto(this DCRepositories entity) {
            if( entity == null )
                return new DCRepositoriesDto();
            return entity.MapTo<DCRepositoriesDto>();
        }

        ///// <summary>
        ///// 转换为仓库表数据传输对象
        ///// </summary>
        ///// <param name="entity">仓库表实体</param>
        //public static DCRepositoriesDto ToDto2( this DCRepositories entity ) {
        //    if( entity == null )
        //        return new DCRepositoriesDto();
        //    return new DCRepositoriesDto {
        //        
        //        
        //        Id = entity.Id.ToString(),
        //        
        //        
        //        DefaultBranch = entity.DefaultBranch,
        //        
        //        
        //        Description = entity.Description,
        //        
        //        
        //        IsMirror = entity.IsMirror,
        //        
        //        
        //        IsPrivate = entity.IsPrivate,
        //        
        //        
        //        Name = entity.Name,
        //        
        //        
        //        NumIssues = entity.NumIssues,
        //        
        //        
        //        NumOpenIssues = entity.NumOpenIssues,
        //        
        //        
        //        NumOpenPulls = entity.NumOpenPulls,
        //        
        //        
        //        NumPulls = entity.NumPulls,
        //        
        //        
        //        Size = entity.Size,
        //        
        //        
        //        UserID = entity.UserID,
        //        
        //        
        //        UserName = entity.UserName,
        //        
        //        
        //        CreationTime = entity.CreationTime,
        //        
        //        
        //        LastModifiTime = entity.LastModifiTime,
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