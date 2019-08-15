using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 仓库表查询参数
    /// </summary>
    public class DCRepositoriesQuery : QueryParameter {
        /// <summary>
        /// 编号
        /// </summary>
        [Display( Name = "编号" )]
        public Guid? Id { get; set; }
        
        private string _defaultBranch = string.Empty;
        /// <summary>
        /// 默认分支
        /// </summary>
        [Display( Name = "默认分支" )]
        public string DefaultBranch {
            get => _defaultBranch == null ? string.Empty : _defaultBranch.Trim();
            set => _defaultBranch = value;
        }
        
        private string _description = string.Empty;
        /// <summary>
        /// 描述
        /// </summary>
        [Display( Name = "描述" )]
        public string Description {
            get => _description == null ? string.Empty : _description.Trim();
            set => _description = value;
        }
        /// <summary>
        /// 是否镜像
        /// </summary>
        [Display( Name = "是否镜像" )]
        public bool? IsMirror { get; set; }
        /// <summary>
        /// 是否私人
        /// </summary>
        [Display( Name = "是否私人" )]
        public bool? IsPrivate { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 项目名称
        /// </summary>
        [Display( Name = "项目名称" )]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        /// <summary>
        /// 问题数量
        /// </summary>
        [Display( Name = "问题数量" )]
        public int? NumIssues { get; set; }
        /// <summary>
        /// 未关闭的问题数量
        /// </summary>
        [Display( Name = "未关闭的问题数量" )]
        public int? NumOpenIssues { get; set; }
        /// <summary>
        /// 未关闭的合并请求数量
        /// </summary>
        [Display( Name = "未关闭的合并请求数量" )]
        public int? NumOpenPulls { get; set; }
        /// <summary>
        /// 合并请求数量
        /// </summary>
        [Display( Name = "合并请求数量" )]
        public int? NumPulls { get; set; }
        /// <summary>
        /// 大小
        /// </summary>
        [Display( Name = "大小" )]
        public decimal? Size { get; set; }
        /// <summary>
        /// 归属用户
        /// </summary>
        [Display( Name = "归属用户" )]
        public long? UserID { get; set; }
        
        private string _userName = string.Empty;
        /// <summary>
        /// 用户名称
        /// </summary>
        [Display( Name = "用户名称" )]
        public string UserName {
            get => _userName == null ? string.Empty : _userName.Trim();
            set => _userName = value;
        }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModifiTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModifiTime { get; set; }
    }
}