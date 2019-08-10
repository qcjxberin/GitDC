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
    public partial class TeamRepositoryRole : AggregateRoot<TeamRepositoryRole> {
        /// <summary>
        /// 初始化
        /// </summary>
        public TeamRepositoryRole() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id">标识</param>
        public TeamRepositoryRole( Guid id ) : base( id ) {
        }

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
        [ForeignKey( "ID" )]
        public Repositories RepositoryRepositories { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey( "ID" )]
        public Teams TeamTeams { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.TeamID );
            AddDescription( t => t.RepositoryID );
            AddDescription( t => t.AllowRead );
            AddDescription( t => t.AllowWrite );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( TeamRepositoryRole other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.TeamID, other.TeamID );
            AddChange( t => t.RepositoryID, other.RepositoryID );
            AddChange( t => t.AllowRead, other.AllowRead );
            AddChange( t => t.AllowWrite, other.AllowWrite );
        }
    }
}