using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class TeamRepositoryRoleDto : DtoBase {
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
        [Required(ErrorMessage = "RepositoryID不能为空")]
        [Column( "RepositoryID" )]
        [Display( Name = "" )]
        public long RepositoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "AllowRead" )]
        [Display( Name = "" )]
        public bool? AllowRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "AllowWrite" )]
        [Display( Name = "" )]
        public bool? AllowWrite { get; set; }
    }
}