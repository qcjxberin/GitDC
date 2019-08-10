using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 持久化对象
    /// </summary>
    public class UserTeamRolePo : PersistentObjectBase<Guid>{
        /// <summary>
        /// 
        /// </summary>  
        public long UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public long TeamID { get; set; }
        /// <summary>
        /// 
        /// </summary>  
        public bool IsAdministrator { get; set; }
    }
}