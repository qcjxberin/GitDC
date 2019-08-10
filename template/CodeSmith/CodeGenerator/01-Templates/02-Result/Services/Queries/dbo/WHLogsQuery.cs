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
        
        private string _wHTypes = string.Empty;
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>
        [Display( Name = "是为中转，否为非中转" )]
        public string WHTypes {
            get => _wHTypes == null ? string.Empty : _wHTypes.Trim();
            set => _wHTypes = value;
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
        /// <summary>
        /// 创建人编号
        /// </summary>
        [Display( Name = "创建人编号" )]
        public int? CreatId { get; set; }
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