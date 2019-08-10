using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class RepositoriesDto : DtoBase {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Name不能为空")]
        [StringLength( 50, ErrorMessage = "Name输入过长，不能超过50位" )]
        [Column( "Name" )]
        [Display( Name = "" )]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Description不能为空")]
        [StringLength( 500, ErrorMessage = "Description输入过长，不能超过500位" )]
        [Column( "Description" )]
        [Display( Name = "" )]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "CreationDate不能为空")]
        [Column( "CreationDate" )]
        [Display( Name = "" )]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "IsPrivate" )]
        [Display( Name = "" )]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "AllowAnonymousRead" )]
        [Display( Name = "" )]
        public bool? AllowAnonymousRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column( "AllowAnonymousWrite" )]
        [Display( Name = "" )]
        public bool? AllowAnonymousWrite { get; set; }
    }
}