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
    public partial class AuthorizationLog : AggregateRoot<AuthorizationLog> {
        /// <summary>
        /// 初始化
        /// </summary>
        public AuthorizationLog() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id">标识</param>
        public AuthorizationLog( Guid id ) : base( id ) {
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
        [Required(ErrorMessage = "IssueDate不能为空")]
        [Column( "IssueDate" )]
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "Expires不能为空")]
        [Column( "Expires" )]
        public DateTime Expires { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "IssueIp不能为空")]
        [StringLength( 40, ErrorMessage = "IssueIp输入过长，不能超过40位" )]
        [Column( "IssueIp" )]
        public string IssueIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "LastIp不能为空")]
        [StringLength( 40, ErrorMessage = "LastIp输入过长，不能超过40位" )]
        [Column( "LastIp" )]
        public string LastIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Column( "IsValid" )]
        public bool IsValid { get; set; }
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
            AddDescription( t => t.IssueDate );
            AddDescription( t => t.Expires );
            AddDescription( t => t.IssueIp );
            AddDescription( t => t.LastIp );
            AddDescription( t => t.IsValid );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( AuthorizationLog other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.UserID, other.UserID );
            AddChange( t => t.IssueDate, other.IssueDate );
            AddChange( t => t.Expires, other.Expires );
            AddChange( t => t.IssueIp, other.IssueIp );
            AddChange( t => t.LastIp, other.LastIp );
            AddChange( t => t.IsValid, other.IsValid );
        }
    }
}