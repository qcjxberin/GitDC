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
    /// 仓库表
    /// </summary>
    [DisplayName( "仓库表" )]
    public partial class DCRepositories : AggregateRoot<DCRepositories>,IDelete {
        /// <summary>
        /// 初始化仓库表
        /// </summary>
        public DCRepositories() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化仓库表
        /// </summary>
        /// <param name="id">仓库表标识</param>
        public DCRepositories( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 默认分支
        /// </summary>
        [DisplayName( "默认分支" )]
        [StringLength( 100, ErrorMessage = "默认分支输入过长，不能超过100位" )]
        [Column( "DefaultBranch" )]
        public string DefaultBranch { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName( "描述" )]
        [StringLength( 512, ErrorMessage = "描述输入过长，不能超过512位" )]
        [Column( "Description" )]
        public string Description { get; set; }
        /// <summary>
        /// 是否镜像
        /// </summary>
        [DisplayName( "是否镜像" )]
        [Column( "IsMirror" )]
        public bool? IsMirror { get; set; }
        /// <summary>
        /// 是否私人
        /// </summary>
        [DisplayName( "是否私人" )]
        [Column( "IsPrivate" )]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [DisplayName( "项目名称" )]
        [StringLength( 250, ErrorMessage = "项目名称输入过长，不能超过250位" )]
        [Column( "Name" )]
        public string Name { get; set; }
        /// <summary>
        /// 问题数量
        /// </summary>
        [DisplayName( "问题数量" )]
        [Column( "NumIssues" )]
        public int? NumIssues { get; set; }
        /// <summary>
        /// 未关闭的问题数量
        /// </summary>
        [DisplayName( "未关闭的问题数量" )]
        [Column( "NumOpenIssues" )]
        public int? NumOpenIssues { get; set; }
        /// <summary>
        /// 未关闭的合并请求数量
        /// </summary>
        [DisplayName( "未关闭的合并请求数量" )]
        [Column( "NumOpenPulls" )]
        public int? NumOpenPulls { get; set; }
        /// <summary>
        /// 合并请求数量
        /// </summary>
        [DisplayName( "合并请求数量" )]
        [Column( "NumPulls" )]
        public int? NumPulls { get; set; }
        /// <summary>
        /// 大小
        /// </summary>
        [DisplayName( "大小" )]
        [Column( "Size" )]
        public decimal? Size { get; set; }
        /// <summary>
        /// 归属用户
        /// </summary>
        [DisplayName( "归属用户" )]
        [Column( "UserID" )]
        public long? UserID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        [DisplayName( "用户名称" )]
        [StringLength( 50, ErrorMessage = "用户名称输入过长，不能超过50位" )]
        [Column( "UserName" )]
        public string UserName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        [Column( "CreationTime" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName( "最后修改时间" )]
        [Column( "LastModifiTime" )]
        public DateTime? LastModifiTime { get; set; }
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
            AddDescription( t => t.DefaultBranch );
            AddDescription( t => t.Description );
            AddDescription( t => t.IsMirror );
            AddDescription( t => t.IsPrivate );
            AddDescription( t => t.Name );
            AddDescription( t => t.NumIssues );
            AddDescription( t => t.NumOpenIssues );
            AddDescription( t => t.NumOpenPulls );
            AddDescription( t => t.NumPulls );
            AddDescription( t => t.Size );
            AddDescription( t => t.UserID );
            AddDescription( t => t.UserName );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.LastModifiTime );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( DCRepositories other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.DefaultBranch, other.DefaultBranch );
            AddChange( t => t.Description, other.Description );
            AddChange( t => t.IsMirror, other.IsMirror );
            AddChange( t => t.IsPrivate, other.IsPrivate );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.NumIssues, other.NumIssues );
            AddChange( t => t.NumOpenIssues, other.NumOpenIssues );
            AddChange( t => t.NumOpenPulls, other.NumOpenPulls );
            AddChange( t => t.NumPulls, other.NumPulls );
            AddChange( t => t.Size, other.Size );
            AddChange( t => t.UserID, other.UserID );
            AddChange( t => t.UserName, other.UserName );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.LastModifiTime, other.LastModifiTime );
        }
    }
}