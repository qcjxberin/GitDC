using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 查询参数
    /// </summary>
    public class TeamRepositoryRoleQuery : QueryParameter {
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public Guid? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? TeamID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? RepositoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? AllowRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? AllowWrite { get; set; }
    }
}