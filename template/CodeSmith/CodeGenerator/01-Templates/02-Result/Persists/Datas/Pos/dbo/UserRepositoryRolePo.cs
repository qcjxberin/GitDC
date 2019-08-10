using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 持久化对象
    /// </summary>
    public class UserRepositoryRolePo : PersistentObjectBase<Guid>{
        /// <summary>
        /// 
        /// </summary>  
        public long UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public long RepositoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool AllowRead { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool AllowWrite { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool IsOwner { get; set; }
    }
}