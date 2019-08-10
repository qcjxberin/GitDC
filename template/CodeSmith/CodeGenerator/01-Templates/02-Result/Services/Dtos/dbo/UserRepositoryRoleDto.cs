using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class UserRepositoryRoleDto : DtoBase {
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
        /// <summary>
        /// 
        /// </summary>
        [Column( "IsOwner" )]
        [Display( Name = "" )]
        public bool? IsOwner { get; set; }
    }
}