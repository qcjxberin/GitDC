using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 网络勾子推送内容日志测试数据
    /// </summary>
    public partial class WHLogsTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 编号
        /// </summary>
        public static readonly Guid Id = "edd29716-2c9b-470c-ba8f-331a64cf593a".ToGuid();
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>
        public static readonly bool WHTypes = true;
        /// <summary>
        /// 推送内容
        /// </summary>
        public static readonly string Content = "Content";
        /// <summary>
        /// 创建时间
        /// </summary>
        public static readonly DateTime? CreationTime = "CreationTime";
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>
        public static readonly bool IsDeleted = false;
        /// <summary>
        /// 处理并发问题
        /// </summary>
        public static readonly Byte[] Version = Ding.Helpers.Convert.ToBytes( "1" );
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 编号
        /// </summary>
        public static readonly Guid Id2 = "deb41dac-b081-40ce-a0cd-947bae544eaa".ToGuid();
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>
        public static readonly bool WHTypes2 = true;
        /// <summary>
        /// 推送内容
        /// </summary>
        public static readonly string Content2 = "Content2";
        /// <summary>
        /// 创建时间
        /// </summary>
        public static readonly DateTime? CreationTime2 = "CreationTime2";
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>
        public static readonly bool IsDeleted = false;
        /// <summary>
        /// 处理并发问题
        /// </summary>
        public static readonly Byte[] Version2 = Ding.Helpers.Convert.ToBytes( "2" );
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建网络勾子推送内容日志实体
        /// </summary>
        public static WHLogs Create(string id = "") {
            return new WHLogs( id.ToGuid() ) {
                WHTypes = WHTypes,
                Content = Content,
                CreationTime = CreationTime,
                IsDeleted = IsDeleted,
                Version = Version,
            };
        }
        
        /// <summary>
        /// 创建网络勾子推送内容日志实体2
        /// </summary>
        /// <param name="id">网络勾子推送内容日志编号</param>
        public static WHLogs Create2( string id = "" ) {
            return new WHLogs( id.ToGuid() ) {
                WHTypes = WHTypes2,
                Content = Content2,
                CreationTime = CreationTime2,
                IsDeleted = IsDeleted2,
                Version = Version2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<WHLogs> CreateList() {
            return new List<WHLogs>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}