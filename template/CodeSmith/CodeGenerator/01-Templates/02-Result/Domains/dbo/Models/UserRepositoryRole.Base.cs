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
    public partial class UserRepositoryRole : AggregateRoot<UserRepositoryRole> {
        /// <summary>
        /// 初始化
        /// </summary>
        public UserRepositoryRole() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id">标识</param>
        public UserRepositoryRole( Guid id ) : base( id ) {
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
        [Required(ErrorMessage = "RepositoryID不能为空")]
        [Column( "RepositoryID" )]
        public long RepositoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Column( "AllowRead" )]
        public bool AllowRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Column( "AllowWrite" )]
        public bool AllowWrite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Column( "IsOwner" )]
        public bool IsOwner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey( "ID" )]
        public Repositories RepositoryRepositories { get; set; }
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
            AddDescription( t => t.RepositoryID );
            AddDescription( t => t.AllowRead );
            AddDescription( t => t.AllowWrite );
            AddDescription( t => t.IsOwner );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( UserRepositoryRole other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.UserID, other.UserID );
            AddChange( t => t.RepositoryID, other.RepositoryID );
            AddChange( t => t.AllowRead, other.AllowRead );
            AddChange( t => t.AllowWrite, other.AllowWrite );
            AddChange( t => t.IsOwner, other.IsOwner );
        }
    }
}