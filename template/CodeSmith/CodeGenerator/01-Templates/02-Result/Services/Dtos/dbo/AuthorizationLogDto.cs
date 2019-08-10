using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class AuthorizationLogDto : DtoBase {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "UserID不能为空")]
        [Column( "UserID" )]
        [Display( Name = "" )]
        public long UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "IssueDate不能为空")]
        [Column( "IssueDate" )]
        [Display( Name = "" )]
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Expires不能为空")]
        [Column( "Expires" )]
        [Display( Name = "" )]
        public DateTime Expires { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "IssueIp不能为空")]
        [StringLength( 40, ErrorMessage = "IssueIp输入过长，不能超过40位" )]
        [Column( "IssueIp" )]
        [Display( Name = "" )]
        public string IssueIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "LastIp不能为空")]
        [StringLength( 40, ErrorMessage = "LastIp输入过长，不能超过40位" )]
        [Column( "LastIp" )]
        [Display( Name = "" )]
        public string LastIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "IsValid" )]
        [Display( Name = "" )]
        public bool? IsValid { get; set; }
    }
}