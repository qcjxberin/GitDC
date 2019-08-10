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
    public partial class UserTeamRole : AggregateRoot<UserTeamRole> {
        /// <summary>
        /// 初始化
        /// </summary>
        public UserTeamRole() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id">标识</param>
        public UserTeamRole( Guid id ) : base( id ) {
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
        [Required(ErrorMessage = "TeamID不能为空")]
        [Column( "TeamID" )]
        public long TeamID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Column( "IsAdministrator" )]
        public bool IsAdministrator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey( "ID" )]
        public Teams TeamTeams { get; set; }
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
            AddDescription( t => t.TeamID );
            AddDescription( t => t.IsAdministrator );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( UserTeamRole other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.UserID, other.UserID );
            AddChange( t => t.TeamID, other.TeamID );
            AddChange( t => t.IsAdministrator, other.IsAdministrator );
        }
    }
}