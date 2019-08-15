using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 仓库表数据传输对象
    /// </summary>
    public class DCRepositoriesDto : DtoBase {
        /// <summary>
        /// 默认分支
        /// </summary>
        [StringLength( 100, ErrorMessage = "默认分支输入过长，不能超过100位" )]
        [Column( "DefaultBranch" )]
        [Display( Name = "默认分支" )]
        public string DefaultBranch { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [StringLength( 512, ErrorMessage = "描述输入过长，不能超过512位" )]
        [Column( "Description" )]
        [Display( Name = "描述" )]
        public string Description { get; set; }
        /// <summary>
        /// 是否镜像
        /// </summary>
        [Column( "IsMirror" )]
        [Display( Name = "是否镜像" )]
        public bool? IsMirror { get; set; }
        /// <summary>
        /// 是否私人
        /// </summary>
        [Column( "IsPrivate" )]
        [Display( Name = "是否私人" )]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [StringLength( 250, ErrorMessage = "项目名称输入过长，不能超过250位" )]
        [Column( "Name" )]
        [Display( Name = "项目名称" )]
        public string Name { get; set; }
        /// <summary>
        /// 问题数量
        /// </summary>
        [Column( "NumIssues" )]
        [Display( Name = "问题数量" )]
        public int? NumIssues { get; set; }
        /// <summary>
        /// 未关闭的问题数量
        /// </summary>
        [Column( "NumOpenIssues" )]
        [Display( Name = "未关闭的问题数量" )]
        public int? NumOpenIssues { get; set; }
        /// <summary>
        /// 未关闭的合并请求数量
        /// </summary>
        [Column( "NumOpenPulls" )]
        [Display( Name = "未关闭的合并请求数量" )]
        public int? NumOpenPulls { get; set; }
        /// <summary>
        /// 合并请求数量
        /// </summary>
        [Column( "NumPulls" )]
        [Display( Name = "合并请求数量" )]
        public int? NumPulls { get; set; }
        /// <summary>
        /// 大小
        /// </summary>
        [Column( "Size" )]
        [Display( Name = "大小" )]
        public decimal? Size { get; set; }
        /// <summary>
        /// 归属用户
        /// </summary>
        [Column( "UserID" )]
        [Display( Name = "归属用户" )]
        public long? UserID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        [StringLength( 50, ErrorMessage = "用户名称输入过长，不能超过50位" )]
        [Column( "UserName" )]
        [Display( Name = "用户名称" )]
        public string UserName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column( "CreationTime" )]
        [Display( Name = "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Column( "LastModifiTime" )]
        [Display( Name = "最后修改时间" )]
        public DateTime? LastModifiTime { get; set; }
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