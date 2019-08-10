using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 查询参数
    /// </summary>
    public class RepositoriesQuery : QueryParameter {
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? Id { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _description = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string Description {
            get => _description == null ? string.Empty : _description.Trim();
            set => _description = value;
        }
        /// <summary>
        /// 起始
        /// </summary>
        [Display( Name = "起始" )]
        public DateTime? BeginCreationDate { get; set; }
        /// <summary>
        /// 结束
        /// </summary>
        [Display( Name = "结束" )]
        public DateTime? EndCreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? AllowAnonymousRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? AllowAnonymousWrite { get; set; }
    }
}