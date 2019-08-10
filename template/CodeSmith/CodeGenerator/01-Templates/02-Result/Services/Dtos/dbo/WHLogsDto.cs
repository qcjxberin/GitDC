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
        [Required(ErrorMessage = "是为中转，否为非中转不能为空")]
        [StringLength( 1, ErrorMessage = "是为中转，否为非中转输入过长，不能超过1位" )]
        [Column( "WHTypes" )]
        [Display( Name = "是为中转，否为非中转" )]
        public string WHTypes { get; set; }
        /// <summary>
        /// 推送内容
        /// </summary>
        [StringLength( 2000, ErrorMessage = "推送内容输入过长，不能超过2000位" )]
        [Column( "Content" )]
        [Display( Name = "推送内容" )]
        public string Content { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [Column( "CreatId" )]
        [Display( Name = "创建人编号" )]
        public int? CreatId { get; set; }
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