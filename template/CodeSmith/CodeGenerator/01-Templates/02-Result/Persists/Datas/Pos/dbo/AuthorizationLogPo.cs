using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 持久化对象
    /// </summary>
    public class AuthorizationLogPo : PersistentObjectBase<Guid>{
        /// <summary>
        /// 
        /// </summary>  
        public long UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public DateTime Expires { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public string IssueIp { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public string LastIp { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool IsValid { get; set; }
    }
}