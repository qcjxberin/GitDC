using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class AuthorizationLogTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id = "f87408e5-2fb7-4aa5-8156-38333752ab95".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID = "UserID";
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime IssueDate = "2019/8/1 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime Expires = "2019/8/1 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly string IssueIp = "IssueIp";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string LastIp = "LastIp";
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsValid = true;
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly Guid Id2 = "908eb1ea-1595-4668-b724-1a15bc34a050".ToGuid();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID2 = "UserID2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime IssueDate2 = "2019/8/2 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime Expires2 = "2019/8/2 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly string IssueIp2 = "IssueIp2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string LastIp2 = "LastIp2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsValid2 = true;
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static AuthorizationLog Create(string id = "") {
            return new AuthorizationLog( id.ToGuid() ) {
                UserID = UserID,
                IssueDate = IssueDate,
                Expires = Expires,
                IssueIp = IssueIp,
                LastIp = LastIp,
                IsValid = IsValid,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static AuthorizationLog Create2( string id = "" ) {
            return new AuthorizationLog( id.ToGuid() ) {
                UserID = UserID2,
                IssueDate = IssueDate2,
                Expires = Expires2,
                IssueIp = IssueIp2,
                LastIp = LastIp2,
                IsValid = IsValid2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<AuthorizationLog> CreateList() {
            return new List<AuthorizationLog>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}