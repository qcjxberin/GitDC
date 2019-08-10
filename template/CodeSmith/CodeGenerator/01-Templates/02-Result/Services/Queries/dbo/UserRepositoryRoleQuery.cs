using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 查询参数
    /// </summary>
    public class UserRepositoryRoleQuery : QueryParameter {
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public Guid? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? UserID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public bool? IsOwner { get; set; }
    }
}