using Ding;
using Ding.Maps;
using GitDC.Domain.Models;

namespace GitDC.Service.Dtos.dbo.Extensions {
    /// <summary>
    /// 数据传输对象扩展
    /// </summary>
    public static class SshKeysDtoExtension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static SshKeys ToEntity( this SshKeysDto dto ) {
            if ( dto == null )
                return new SshKeys();
            return dto.MapTo( new SshKeys( dto.Id.ToLong() ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="dto">数据传输对象</param>
        public static SshKeys ToEntity2( this SshKeysDto dto ) {
            if( dto == null )
                return new SshKeys();
            return new SshKeys( dto.Id.ToLong() ) {
                UserID = dto.UserID,
                KeyType = dto.KeyType,
                Fingerprint = dto.Fingerprint,
                PublicKey = dto.PublicKey,
                ImportData = dto.ImportData,
                LastUse = dto.LastUse,
            };
        }
        
        ///// <summary>
        ///// 转换为实体
        ///// </summary>
        ///// <param name="dto">数据传输对象</param>
        //public static SshKeys ToEntity3( this SshKeysDto dto ) {
        //    if( dto == null )
        //        return new SshKeys();
        //    return SshKeysFactory.Create(
        //        
        //        
        //        id : dto.Id.ToLong(),
        //        
        //        
        //        userID : dto.UserID,
        //        
        //        
        //        keyType : dto.KeyType,
        //        
        //        
        //        fingerprint : dto.Fingerprint,
        //        
        //        
        //        publicKey : dto.PublicKey,
        //        
        //        
        //        importData : dto.ImportData,
        //        
        //        
        //        lastUse : dto.LastUse
        //        
        //    );
        //}
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static SshKeysDto ToDto(this SshKeys entity) {
            if( entity == null )
                return new SshKeysDto();
            return entity.MapTo<SshKeysDto>();
        }

        ///// <summary>
        ///// 转换为数据传输对象
        ///// </summary>
        ///// <param name="entity">实体</param>
        //public static SshKeysDto ToDto2( this SshKeys entity ) {
        //    if( entity == null )
        //        return new SshKeysDto();
        //    return new SshKeysDto {
        //        
        //        
        //        Id = entity.Id,
        //        
        //        
        //        UserID = entity.UserID,
        //        
        //        
        //        KeyType = entity.KeyType,
        //        
        //        
        //        Fingerprint = entity.Fingerprint,
        //        
        //        
        //        PublicKey = entity.PublicKey,
        //        
        //        
        //        ImportData = entity.ImportData,
        //        
        //        
        //        LastUse = entity.LastUse,
        //        
        //    };
        //}
    }
}