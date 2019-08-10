using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 查询参数
    /// </summary>
    public class AuthorizationLogQuery : QueryParameter {
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public Guid? AuthCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? UserID { get; set; }
        /// <summary>
        /// 起始
        /// </summary>
        [Display( Name = "起始" )]
        public DateTime? BeginIssueDate { get; set; }
        /// <summary>
        /// 结束
        /// </summary>
        [Display( Name = "结束" )]
        public DateTime? EndIssueDate { get; set; }
        /// <summary>
        /// 起始
        /// </summary>
        [Display( Name = "起始" )]
        public DateTime? BeginExpires { get; set; }
        /// <summary>
        /// 结束
        /// </summary>
        [Display( Name = "结束" )]
        public DateTime? EndExpires { get; set; }
        
        private string _issueIp = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string IssueIp {
            get => _issueIp == null ? string.Empty : _issueIp.Trim();
            set => _issueIp = value;
        }
        
        private string _lastIp = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string LastIp {
            get => _lastIp == null ? string.Empty : _lastIp.Trim();
            set => _lastIp = value;
        }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? IsValid { get; set; }
    }
}