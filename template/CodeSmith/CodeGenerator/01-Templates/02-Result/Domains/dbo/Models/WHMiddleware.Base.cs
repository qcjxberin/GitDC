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
    /// 网络勾子中转表
    /// </summary>
    [DisplayName( "网络勾子中转表" )]
    public partial class WHMiddleware : AggregateRoot<WHMiddleware>,IDelete {
        /// <summary>
        /// 初始化网络勾子中转表
        /// </summary>
        public WHMiddleware() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化网络勾子中转表
        /// </summary>
        /// <param name="id">网络勾子中转表标识</param>
        public WHMiddleware( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 令牌
        /// </summary>
        [DisplayName( "令牌" )]
        [StringLength( 100, ErrorMessage = "令牌输入过长，不能超过100位" )]
        [Column( "Token" )]
        public string Token { get; set; }
        /// <summary>
        /// 1.腾讯云开发者中心项目
        /// </summary>
        [DisplayName( "1.腾讯云开发者中心项目" )]
        [Column( "Source" )]
        public short? Source { get; set; }
        /// <summary>
        /// 1.钉钉
        /// </summary>
        [DisplayName( "1.钉钉" )]
        [Column( "Push" )]
        public short? Push { get; set; }
        /// <summary>
        /// 推送Url
        /// </summary>
        [DisplayName( "推送Url" )]
        [StringLength( 250, ErrorMessage = "推送Url输入过长，不能超过250位" )]
        [Column( "PushUrl" )]
        public string PushUrl { get; set; }
        /// <summary>
        /// 推送令牌
        /// </summary>
        [DisplayName( "推送令牌" )]
        [StringLength( 100, ErrorMessage = "推送令牌输入过长，不能超过100位" )]
        [Column( "PushToken" )]
        public string PushToken { get; set; }
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
            AddDescription( t => t.Token );
            AddDescription( t => t.Source );
            AddDescription( t => t.Push );
            AddDescription( t => t.PushUrl );
            AddDescription( t => t.PushToken );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatId );
            AddDescription( t => t.LastModifiTime );
            AddDescription( t => t.LastModifiId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( WHMiddleware other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Token, other.Token );
            AddChange( t => t.Source, other.Source );
            AddChange( t => t.Push, other.Push );
            AddChange( t => t.PushUrl, other.PushUrl );
            AddChange( t => t.PushToken, other.PushToken );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatId, other.CreatId );
            AddChange( t => t.LastModifiTime, other.LastModifiTime );
            AddChange( t => t.LastModifiId, other.LastModifiId );
        }
    }
}