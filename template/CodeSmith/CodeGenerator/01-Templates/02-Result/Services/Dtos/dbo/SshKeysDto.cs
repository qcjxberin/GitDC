using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Ding.Applications.Dtos;

namespace GitDC.Service.Dtos.dbo {
    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class SshKeysDto : DtoBase {
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
        [Required(ErrorMessage = "KeyType不能为空")]
        [StringLength( 20, ErrorMessage = "KeyType输入过长，不能超过20位" )]
        [Column( "KeyType" )]
        [Display( Name = "" )]
        public string KeyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Fingerprint不能为空")]
        [StringLength( 47, ErrorMessage = "Fingerprint输入过长，不能超过47位" )]
        [Column( "Fingerprint" )]
        [Display( Name = "" )]
        public string Fingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "PublicKey不能为空")]
        [StringLength( 600, ErrorMessage = "PublicKey输入过长，不能超过600位" )]
        [Column( "PublicKey" )]
        [Display( Name = "" )]
        public string PublicKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "ImportData不能为空")]
        [Column( "ImportData" )]
        [Display( Name = "" )]
        public DateTime ImportData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "LastUse不能为空")]
        [Column( "LastUse" )]
        [Display( Name = "" )]
        public DateTime LastUse { get; set; }
    }
}