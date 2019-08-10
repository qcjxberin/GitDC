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
    public partial class Teams : AggregateRoot<Teams,long> {
        /// <summary>
        /// 初始化
        /// </summary>
        public Teams() : this( 0 ) {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="id">标识</param>
        public Teams( long id ) : base( id ) {
            TeamTeamRepositoryRoles = new List<TeamRepositoryRole>();
            TeamUserTeamRoles = new List<UserTeamRole>();
        }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "Name不能为空")]
        [StringLength( 20, ErrorMessage = "Name输入过长，不能超过20位" )]
        [Column( "Name" )]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "Description不能为空")]
        [StringLength( 500, ErrorMessage = "Description输入过长，不能超过500位" )]
        [Column( "Description" )]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName( "" )]
        [Required(ErrorMessage = "CreationDate不能为空")]
        [Column( "CreationDate" )]
        public DateTime CreationDate { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Name );
            AddDescription( t => t.Description );
            AddDescription( t => t.CreationDate );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Teams other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Description, other.Description );
            AddChange( t => t.CreationDate, other.CreationDate );
        }
    }
}