using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class UserTeamRoleTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id = "9f3c3b50-1d20-46c7-bc83-5d1779026de4".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID = "UserID";
        /// <summary>
        /// 
        /// </summary>
        public static readonly long TeamID = "TeamID";
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsAdministrator = true;
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id2 = "c5add026-0e5d-4ef9-a2da-71afe36d7db5".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID2 = "UserID2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly long TeamID2 = "TeamID2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsAdministrator2 = true;
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static UserTeamRole Create(string id = "") {
            return new UserTeamRole( id.ToGuid() ) {
                UserID = UserID,
                TeamID = TeamID,
                IsAdministrator = IsAdministrator,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static UserTeamRole Create2( string id = "" ) {
            return new UserTeamRole( id.ToGuid() ) {
                UserID = UserID2,
                TeamID = TeamID2,
                IsAdministrator = IsAdministrator2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<UserTeamRole> CreateList() {
            return new List<UserTeamRole>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}