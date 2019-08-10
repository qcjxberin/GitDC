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
    /// 用户名
    /// </summary>
    [DisplayName( "用户名" )]
    public partial class Users : AggregateRoot<Users,long>,IDelete {
        /// <summary>
        /// 初始化用户名
        /// </summary>
        public Users() : this( 0 ) {
        }

        /// <summary>
        /// 初始化用户名
        /// </summary>
        /// <param name="id">用户名标识</param>
        public Users( long id ) : base( id ) {
        }

        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName( "用户名" )]
        [StringLength( 20, ErrorMessage = "用户名输入过长，不能超过20位" )]
        [Column( "Name" )]
        public string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [DisplayName( "昵称" )]
        [StringLength( 20, ErrorMessage = "昵称输入过长，不能超过20位" )]
        [Column( "NickName" )]
        public string NickName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [DisplayName( "邮箱" )]
        [StringLength( 50, ErrorMessage = "邮箱输入过长，不能超过50位" )]
        [Column( "Email" )]
        public string Email { get; set; }
        /// <summary>
        /// 密码版本
        /// </summary>
        [DisplayName( "密码版本" )]
        [Column( "PasswordVersion" )]
        public short? PasswordVersion { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName( "密码" )]
        [StringLength( 32, ErrorMessage = "密码输入过长，不能超过32位" )]
        [Column( "Password" )]
        public string Password { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName( "描述" )]
        [StringLength( 500, ErrorMessage = "描述输入过长，不能超过500位" )]
        [Column( "Description" )]
        public string Description { get; set; }
        /// <summary>
        /// 是否系统管理员
        /// </summary>
        [DisplayName( "是否系统管理员" )]
        [Column( "IsSystemAdministrator" )]
        public bool? IsSystemAdministrator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        [Column( "CreationTime" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [DisplayName( "创建人编号" )]
        [Column( "CreatId" )]
        public int? CreatId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName( "最后修改时间" )]
        [Column( "LastModifiTime" )]
        public DateTime? LastModifiTime { get; set; }
        /// <summary>
        /// 最后修改人编号
        /// </summary>
        [DisplayName( "最后修改人编号" )]
        [Column( "LastModifiId" )]
        public int? LastModifiId { get; set; }
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>
        [DisplayName( "软删除，数据不会被物理删除" )]
        [Column( "IsDeleted" )]
        public bool IsDeleted { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Name );
            AddDescription( t => t.NickName );
            AddDescription( t => t.Email );
            AddDescription( t => t.PasswordVersion );
            AddDescription( t => t.Password );
            AddDescription( t => t.Description );
            AddDescription( t => t.IsSystemAdministrator );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatId );
            AddDescription( t => t.LastModifiTime );
            AddDescription( t => t.LastModifiId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Users other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.NickName, other.NickName );
            AddChange( t => t.Email, other.Email );
            AddChange( t => t.PasswordVersion, other.PasswordVersion );
            AddChange( t => t.Password, other.Password );
            AddChange( t => t.Description, other.Description );
            AddChange( t => t.IsSystemAdministrator, other.IsSystemAdministrator );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatId, other.CreatId );
            AddChange( t => t.LastModifiTime, other.LastModifiTime );
            AddChange( t => t.LastModifiId, other.LastModifiId );
        }
    }
}