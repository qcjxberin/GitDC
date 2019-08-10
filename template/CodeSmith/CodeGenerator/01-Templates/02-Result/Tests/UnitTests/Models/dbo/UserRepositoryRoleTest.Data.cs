using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class UserRepositoryRoleTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id = "e96a92ac-63b8-4ab3-ab37-2ca7db4a1ba0".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID = "UserID";
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
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsOwner = true;
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id2 = "ef6aea46-74ef-423c-9920-4acde704785f".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID2 = "UserID2";
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
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsOwner2 = true;
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static UserRepositoryRole Create(string id = "") {
            return new UserRepositoryRole( id.ToGuid() ) {
                UserID = UserID,
                RepositoryID = RepositoryID,
                AllowRead = AllowRead,
                AllowWrite = AllowWrite,
                IsOwner = IsOwner,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static UserRepositoryRole Create2( string id = "" ) {
            return new UserRepositoryRole( id.ToGuid() ) {
                UserID = UserID2,
                RepositoryID = RepositoryID2,
                AllowRead = AllowRead2,
                AllowWrite = AllowWrite2,
                IsOwner = IsOwner2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<UserRepositoryRole> CreateList() {
            return new List<UserRepositoryRole>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}