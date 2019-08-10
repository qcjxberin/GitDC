using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 用户名数据传输对象
    /// </summary>
    public class DCUsersDto : DtoBase {
        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength( 20, ErrorMessage = "用户名输入过长，不能超过20位" )]
        [Column( "Name" )]
        [Display( Name = "用户名" )]
        public string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [StringLength( 20, ErrorMessage = "昵称输入过长，不能超过20位" )]
        [Column( "NickName" )]
        [Display( Name = "昵称" )]
        public string NickName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength( 50, ErrorMessage = "邮箱输入过长，不能超过50位" )]
        [Column( "Email" )]
        [Display( Name = "邮箱" )]
        public string Email { get; set; }
        /// <summary>
        /// 密码版本
        /// </summary>
        [Column( "PasswordVersion" )]
        [Display( Name = "密码版本" )]
        public short? PasswordVersion { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [StringLength( 32, ErrorMessage = "密码输入过长，不能超过32位" )]
        [Column( "Password" )]
        [Display( Name = "密码" )]
        public string Password { get; set; }
        /// <summary>
        /// 盐值
        /// </summary>
        [StringLength( 6, ErrorMessage = "盐值输入过长，不能超过6位" )]
        [Column( "Salt" )]
        [Display( Name = "盐值" )]
        public string Salt { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [StringLength( 500, ErrorMessage = "描述输入过长，不能超过500位" )]
        [Column( "Description" )]
        [Display( Name = "描述" )]
        public string Description { get; set; }
        /// <summary>
        /// 是否系统管理员
        /// </summary>
        [Column( "IsSystemAdministrator" )]
        [Display( Name = "是否系统管理员" )]
        public bool? IsSystemAdministrator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column( "CreationTime" )]
        [Display( Name = "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [Column( "CreatId" )]
        [Display( Name = "创建人编号" )]
        public int? CreatId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Column( "LastModifiTime" )]
        [Display( Name = "最后修改时间" )]
        public DateTime? LastModifiTime { get; set; }
        /// <summary>
        /// 最后修改人编号
        /// </summary>
        [Column( "LastModifiId" )]
        [Display( Name = "最后修改人编号" )]
        public int? LastModifiId { get; set; }
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>
        [Column( "IsDeleted" )]
        [Display( Name = "软删除，数据不会被物理删除" )]
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// 处理并发问题
        /// </summary>
        [Column( "Version" )]
        [Display( Name = "处理并发问题" )]
        public Byte[] Version { get; set; }
    }
}