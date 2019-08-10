using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 持久化对象
    /// </summary>
    public class SshKeysPo : PersistentObjectBase<long>{
        /// <summary>
        /// 
        /// </summary>  
        public long UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public string KeyType { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public string Fingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public string PublicKey { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public DateTime ImportData { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public DateTime LastUse { get; set; }
    }
}