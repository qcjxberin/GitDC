using Ding;
using GitDC.Domain.Models;
using Ding.Maps;

namespace GitDC.Data.Pos.dbo.Extensions {
    /// <summary>
    /// 持久化对象扩展
    /// </summary>
    public static partial class Extension {
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        public static SshKeys ToEntity( this SshKeysPo po ) {
            if ( po == null )
                return null;
            return po.MapTo( new SshKeys( po.Id ) );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        private static SshKeys ToEntity2( this SshKeysPo po ) {
            if( po == null )
                return null;
            return new SshKeys( po.Id ) {
                UserID = po.UserID,
                KeyType = po.KeyType,
                Fingerprint = po.Fingerprint,
                PublicKey = po.PublicKey,
                ImportData = po.ImportData,
                LastUse = po.LastUse,
            };
        }
        
        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        public static SshKeysPo ToPo(this SshKeys entity) {
            if( entity == null )
                return null;
            return entity.MapTo<SshKeysPo>();
        }

        /// <summary>
        /// 转换为持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        private static SshKeysPo ToPo2( this SshKeys entity ) {
            if( entity == null )
                return null;
            return new SshKeysPo {
                Id = entity.Id,
                UserID = entity.UserID,
                KeyType = entity.KeyType,
                Fingerprint = entity.Fingerprint,
                PublicKey = entity.PublicKey,
                ImportData = entity.ImportData,
                LastUse = entity.LastUse,
            };
        }
    }
}
