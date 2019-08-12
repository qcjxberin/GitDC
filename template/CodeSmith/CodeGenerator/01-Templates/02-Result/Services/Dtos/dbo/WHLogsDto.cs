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
        /// 请求头部
        /// </summary>
        [StringLength( 2000, ErrorMessage = "请求头部输入过长，不能超过2000位" )]
        [Column( "RequestTop" )]
        [Display( Name = "请求头部" )]
        public string RequestTop { get; set; }
        /// <summary>
        /// 推送内容
        /// </summary>
        [StringLength( 16, ErrorMessage = "推送内容输入过长，不能超过16位" )]
        [Column( "Content" )]
        [Display( Name = "推送内容" )]
        public string Content { get; set; }
        /// <summary>
        /// 响应头部
        /// </summary>
        [StringLength( 2000, ErrorMessage = "响应头部输入过长，不能超过2000位" )]
        [Column( "ResponseTop" )]
        [Display( Name = "响应头部" )]
        public string ResponseTop { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>
        [StringLength( 16, ErrorMessage = "响应内容输入过长，不能超过16位" )]
        [Column( "ResponseContent" )]
        [Display( Name = "响应内容" )]
        public string ResponseContent { get; set; }
        /// <summary>
        /// 响应结果
        /// </summary>
        [StringLength( 2000, ErrorMessage = "响应结果输入过长，不能超过2000位" )]
        [Column( "ResponseBody" )]
        [Display( Name = "响应结果" )]
        public string ResponseBody { get; set; }
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