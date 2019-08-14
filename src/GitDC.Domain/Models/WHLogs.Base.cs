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
    /// 网络勾子推送内容日志
    /// </summary>
    [DisplayName( "网络勾子推送内容日志" )]
    public partial class WHLogs : AggregateRoot<WHLogs>,IDelete {
        /// <summary>
        /// 初始化网络勾子推送内容日志
        /// </summary>
        public WHLogs() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化网络勾子推送内容日志
        /// </summary>
        /// <param name="id">网络勾子推送内容日志标识</param>
        public WHLogs( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 勾子编号
        /// </summary>
        [DisplayName( "勾子编号" )]
        [StringLength( 36, ErrorMessage = "勾子编号输入过长，不能超过36位" )]
        [Column( "WhId" )]
        public string WhId { get; set; }
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>
        [DisplayName( "是为中转，否为非中转" )]
        [Column( "WHTypes" )]
        public bool WHTypes { get; set; }
        /// <summary>
        /// 请求头部
        /// </summary>
        [DisplayName( "请求头部" )]
        [StringLength( 2000, ErrorMessage = "请求头部输入过长，不能超过2000位" )]
        [Column( "RequestTop" )]
        public string RequestTop { get; set; }
        /// <summary>
        /// 推送内容
        /// </summary>
        [DisplayName( "推送内容" )]
        [Column( "Content" )]
        public string Content { get; set; }
        /// <summary>
        /// 响应头部
        /// </summary>
        [DisplayName( "响应头部" )]
        [StringLength( 2000, ErrorMessage = "响应头部输入过长，不能超过2000位" )]
        [Column( "ResponseTop" )]
        public string ResponseTop { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>
        [DisplayName( "响应内容" )]
        [Column( "ResponseContent" )]
        public string ResponseContent { get; set; }
        /// <summary>
        /// 响应结果
        /// </summary>
        [DisplayName( "响应结果" )]
        [StringLength( 2000, ErrorMessage = "响应结果输入过长，不能超过2000位" )]
        [Column( "ResponseBody" )]
        public string ResponseBody { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        [Column( "CreationTime" )]
        public DateTime? CreationTime { get; set; }
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
            AddDescription( t => t.WhId );
            AddDescription( t => t.WHTypes );
            AddDescription( t => t.RequestTop );
            AddDescription( t => t.Content );
            AddDescription( t => t.ResponseTop );
            AddDescription( t => t.ResponseContent );
            AddDescription( t => t.ResponseBody );
            AddDescription( t => t.CreationTime );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( WHLogs other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.WhId, other.WhId );
            AddChange( t => t.WHTypes, other.WHTypes );
            AddChange( t => t.RequestTop, other.RequestTop );
            AddChange( t => t.Content, other.Content );
            AddChange( t => t.ResponseTop, other.ResponseTop );
            AddChange( t => t.ResponseContent, other.ResponseContent );
            AddChange( t => t.ResponseBody, other.ResponseBody );
            AddChange( t => t.CreationTime, other.CreationTime );
        }
    }
}