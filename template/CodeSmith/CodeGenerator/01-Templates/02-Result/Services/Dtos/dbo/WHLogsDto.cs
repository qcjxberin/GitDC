using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 网络勾子推送内容日志数据传输对象
    /// </summary>
    public class WHLogsDto : DtoBase {
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>
        [Column( "WHTypes" )]
        [Display( Name = "是为中转，否为非中转" )]
        public bool? WHTypes { get; set; }
        /// <summary>
        /// 推送内容
        /// </summary>
        [StringLength( 16, ErrorMessage = "推送内容输入过长，不能超过16位" )]
        [Column( "Content" )]
        [Display( Name = "推送内容" )]
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column( "CreationTime" )]
        [Display( Name = "创建时间" )]
        public DateTime? CreationTime { get; set; }
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