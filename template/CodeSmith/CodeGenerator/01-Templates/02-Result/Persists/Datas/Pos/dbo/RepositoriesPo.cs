using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 持久化对象
    /// </summary>
    public class RepositoriesPo : PersistentObjectBase<long>{
        /// <summary>
        /// 
        /// </summary>  
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool IsPrivate { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool AllowAnonymousRead { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool AllowAnonymousWrite { get; set; }
    }
}