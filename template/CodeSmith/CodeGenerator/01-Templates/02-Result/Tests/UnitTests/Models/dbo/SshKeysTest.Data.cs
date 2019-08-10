using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class SshKeysTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly long Id = "b575a713-eab3-46cd-8493-edfde353d84d".ToLong();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID = "UserID";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string KeyType = "KeyType";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Fingerprint = "Fingerprint";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string PublicKey = "PublicKey";
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime ImportData = "2019/8/1 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime LastUse = "2019/8/1 21:48:52".ToDate();
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly long Id2 = "af549e3b-8bb2-42d1-b2cb-eba75e70d3cf".ToLong();
        /// <summary>
        /// 
        /// </summary>
        public static readonly long UserID2 = "UserID2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string KeyType2 = "KeyType2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Fingerprint2 = "Fingerprint2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string PublicKey2 = "PublicKey2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime ImportData2 = "2019/8/2 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime LastUse2 = "2019/8/2 21:48:52".ToDate();
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static SshKeys Create(string id = "") {
            return new SshKeys( id.ToLong() ) {
                UserID = UserID,
                KeyType = KeyType,
                Fingerprint = Fingerprint,
                PublicKey = PublicKey,
                ImportData = ImportData,
                LastUse = LastUse,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static SshKeys Create2( string id = "" ) {
            return new SshKeys( id.ToLong() ) {
                UserID = UserID2,
                KeyType = KeyType2,
                Fingerprint = Fingerprint2,
                PublicKey = PublicKey2,
                ImportData = ImportData2,
                LastUse = LastUse2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<SshKeys> CreateList() {
            return new List<SshKeys>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}