using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 查询参数
    /// </summary>
    public class SshKeysQuery : QueryParameter {
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public long? UserID { get; set; }
        
        private string _keyType = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string KeyType {
            get => _keyType == null ? string.Empty : _keyType.Trim();
            set => _keyType = value;
        }
        
        private string _fingerprint = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string Fingerprint {
            get => _fingerprint == null ? string.Empty : _fingerprint.Trim();
            set => _fingerprint = value;
        }
        
        private string _publicKey = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        [Display( Name = "" )]
        public string PublicKey {
            get => _publicKey == null ? string.Empty : _publicKey.Trim();
            set => _publicKey = value;
        }
        /// <summary>
        /// 起始
        /// </summary>
        [Display( Name = "起始" )]
        public DateTime? BeginImportData { get; set; }
        /// <summary>
        /// 结束
        /// </summary>
        [Display( Name = "结束" )]
        public DateTime? EndImportData { get; set; }
        /// <summary>
        /// 起始
        /// </summary>
        [Display( Name = "起始" )]
        public DateTime? BeginLastUse { get; set; }
        /// <summary>
        /// 结束
        /// </summary>
        [Display( Name = "结束" )]
        public DateTime? EndLastUse { get; set; }
    }
}