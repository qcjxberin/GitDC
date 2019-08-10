using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ding;
using Ding.Domains;
using Ding.Domains.Auditing;
using Ding.Domains.Tenants;

namespace GitDC.Domain.Models {
    /// <summary>
    /// 
    /// </summary>
    [DisplayName( "" )]
    public partial class SshKeys : AggregateRoot<SshKeys,long> {
        /// <summary>
        /// 初始化
        /// </summary>
        public SshKeys() : this( 0 ) {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id">标识</param>
        public SshKeys( long id ) : base( id ) {
        }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "UserID不能为空")]
        [Column( "UserID" )]
        public long UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "KeyType不能为空")]
        [StringLength( 20, ErrorMessage = "KeyType输入过长，不能超过20位" )]
        [Column( "KeyType" )]
        public string KeyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "Fingerprint不能为空")]
        [StringLength( 47, ErrorMessage = "Fingerprint输入过长，不能超过47位" )]
        [Column( "Fingerprint" )]
        public string Fingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "PublicKey不能为空")]
        [StringLength( 600, ErrorMessage = "PublicKey输入过长，不能超过600位" )]
        [Column( "PublicKey" )]
        public string PublicKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "ImportData不能为空")]
        [Column( "ImportData" )]
        public DateTime ImportData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "LastUse不能为空")]
        [Column( "LastUse" )]
        public DateTime LastUse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey( "ID" )]
        public Users UserUsers { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.UserID );
            AddDescription( t => t.KeyType );
            AddDescription( t => t.Fingerprint );
            AddDescription( t => t.PublicKey );
            AddDescription( t => t.ImportData );
            AddDescription( t => t.LastUse );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( SshKeys other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.UserID, other.UserID );
            AddChange( t => t.KeyType, other.KeyType );
            AddChange( t => t.Fingerprint, other.Fingerprint );
            AddChange( t => t.PublicKey, other.PublicKey );
            AddChange( t => t.ImportData, other.ImportData );
            AddChange( t => t.LastUse, other.LastUse );
        }
    }
}