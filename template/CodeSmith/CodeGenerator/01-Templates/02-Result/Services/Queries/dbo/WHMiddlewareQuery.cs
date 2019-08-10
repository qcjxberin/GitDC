using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 网络勾子中转表查询参数
    /// </summary>
    public class WHMiddlewareQuery : QueryParameter {
        /// <summary>
        /// 编号
        /// </summary>
        [Display( Name = "编号" )]
        public Guid? Id { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称
        /// </summary>
        [Display( Name = "名称" )]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _summary = string.Empty;
        /// <summary>
        /// 介绍
        /// </summary>
        [Display( Name = "介绍" )]
        public string Summary {
            get => _summary == null ? string.Empty : _summary.Trim();
            set => _summary = value;
        }
        
        private string _token = string.Empty;
        /// <summary>
        /// 令牌
        /// </summary>
        [Display( Name = "令牌" )]
        public string Token {
            get => _token == null ? string.Empty : _token.Trim();
            set => _token = value;
        }
        /// <summary>
        /// 1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea
        /// </summary>
        [Display( Name = "1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea" )]
        public short? Source { get; set; }
        /// <summary>
        /// 1.钉钉，2为企业微信
        /// </summary>
        [Display( Name = "1.钉钉，2为企业微信" )]
        public short? Push { get; set; }
        
        private string _pushUrl = string.Empty;
        /// <summary>
        /// 推送Url
        /// </summary>
        [Display( Name = "推送Url" )]
        public string PushUrl {
            get => _pushUrl == null ? string.Empty : _pushUrl.Trim();
            set => _pushUrl = value;
        }
        
        private string _pushToken = string.Empty;
        /// <summary>
        /// 推送令牌
        /// </summary>
        [Display( Name = "推送令牌" )]
        public string PushToken {
            get => _pushToken == null ? string.Empty : _pushToken.Trim();
            set => _pushToken = value;
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
        /// 创建人编号
        /// </summary>
        [Display( Name = "创建人编号" )]
        public int? CreatId { get; set; }
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
        /// <summary>
        /// 最后修改人编号
        /// </summary>
        [Display( Name = "最后修改人编号" )]
        public int? LastModifiId { get; set; }
    }
}