using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class UserTeamRoleDto : DtoBase {
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
        [Required(ErrorMessage = "TeamID不能为空")]
        [Column( "TeamID" )]
        [Display( Name = "" )]
        public long TeamID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "IsAdministrator" )]
        [Display( Name = "" )]
        public bool? IsAdministrator { get; set; }
    }
}