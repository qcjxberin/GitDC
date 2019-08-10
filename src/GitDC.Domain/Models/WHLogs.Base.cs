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
        /// 是为中转，否为非中转
        /// </summary>
        [DisplayName( "是为中转，否为非中转" )]
        [Required(ErrorMessage = "是为中转，否为非中转不能为空")]
        [StringLength( 1, ErrorMessage = "是为中转，否为非中转输入过长，不能超过1位" )]
        [Column( "WHTypes" )]
        public string WHTypes { get; set; }
        /// <summary>
        /// 推送内容
        /// </summary>
        [DisplayName( "推送内容" )]
        [StringLength( 2000, ErrorMessage = "推送内容输入过长，不能超过2000位" )]
        [Column( "Content" )]
        public string Content { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [DisplayName( "创建人编号" )]
        [Column( "CreatId" )]
        public int? CreatId { get; set; }
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
            AddDescription( t => t.WHTypes );
            AddDescription( t => t.Content );
            AddDescription( t => t.CreatId );
            AddDescription( t => t.CreationTime );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( WHLogs other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.WHTypes, other.WHTypes );
            AddChange( t => t.Content, other.Content );
            AddChange( t => t.CreatId, other.CreatId );
            AddChange( t => t.CreationTime, other.CreationTime );
        }
    }
}