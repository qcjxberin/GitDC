using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class TeamRepositoryRoleTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id = "87f4ea27-05f3-473b-9861-5088a672dfa3".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long TeamID = "TeamID";
        /// <summary>
        /// 
        /// </summary>
        public static readonly long RepositoryID = "RepositoryID";
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowRead = true;
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowWrite = true;
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id2 = "10eacbbe-adcd-4fc6-9c7f-6f5497777f24".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long TeamID2 = "TeamID2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly long RepositoryID2 = "RepositoryID2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowRead2 = true;
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowWrite2 = true;
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static TeamRepositoryRole Create(string id = "") {
            return new TeamRepositoryRole( id.ToGuid() ) {
                TeamID = TeamID,
                RepositoryID = RepositoryID,
                AllowRead = AllowRead,
                AllowWrite = AllowWrite,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static TeamRepositoryRole Create2( string id = "" ) {
            return new TeamRepositoryRole( id.ToGuid() ) {
                TeamID = TeamID2,
                RepositoryID = RepositoryID2,
                AllowRead = AllowRead2,
                AllowWrite = AllowWrite2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<TeamRepositoryRole> CreateList() {
            return new List<TeamRepositoryRole>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}