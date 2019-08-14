using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 网络勾子推送内容日志查询参数
    /// </summary>
    public class WHLogsQuery : QueryParameter {
        /// <summary>
        /// 编号
        /// </summary>
        [Display( Name = "编号" )]
        public Guid? Id { get; set; }
        
        private string _whId = string.Empty;
        /// <summary>
        /// 勾子编号
        /// </summary>
        [Display( Name = "勾子编号" )]
        public string WhId {
            get => _whId == null ? string.Empty : _whId.Trim();
            set => _whId = value;
        }
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>
        [Display( Name = "是为中转，否为非中转" )]
        public bool? WHTypes { get; set; }
        
        private string _requestTop = string.Empty;
        /// <summary>
        /// 请求头部
        /// </summary>
        [Display( Name = "请求头部" )]
        public string RequestTop {
            get => _requestTop == null ? string.Empty : _requestTop.Trim();
            set => _requestTop = value;
        }
        
        private string _content = string.Empty;
        /// <summary>
        /// 推送内容
        /// </summary>
        [Display( Name = "推送内容" )]
        public string Content {
            get => _content == null ? string.Empty : _content.Trim();
            set => _content = value;
        }
        
        private string _responseTop = string.Empty;
        /// <summary>
        /// 响应头部
        /// </summary>
        [Display( Name = "响应头部" )]
        public string ResponseTop {
            get => _responseTop == null ? string.Empty : _responseTop.Trim();
            set => _responseTop = value;
        }
        
        private string _responseContent = string.Empty;
        /// <summary>
        /// 响应内容
        /// </summary>
        [Display( Name = "响应内容" )]
        public string ResponseContent {
            get => _responseContent == null ? string.Empty : _responseContent.Trim();
            set => _responseContent = value;
        }
        
        private string _responseBody = string.Empty;
        /// <summary>
        /// 响应结果
        /// </summary>
        [Display( Name = "响应结果" )]
        public string ResponseBody {
            get => _responseBody == null ? string.Empty : _responseBody.Trim();
            set => _responseBody = value;
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
    }
}