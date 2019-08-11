using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 网络勾子中转表测试数据
    /// </summary>
    public partial class WHMiddlewareTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 编号
        /// </summary>
        public static readonly Guid Id = "377cfe61-cdbe-43bf-b6ae-48bfb5a55cca".ToGuid();
        /// <summary>
        /// 名称
        /// </summary>
        public static readonly string Name = "Name";
        /// <summary>
        /// 介绍
        /// </summary>
        public static readonly string Summary = "Summary";
        /// <summary>
        /// 令牌
        /// </summary>
        public static readonly string Token = "Token";
        /// <summary>
        /// 1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea
        /// </summary>
        public static readonly short Source = "Source";
        /// <summary>
        /// 1.钉钉，2为企业微信
        /// </summary>
        public static readonly short Push = "Push";
        /// <summary>
        /// 推送Url
        /// </summary>
        public static readonly string PushUrl = "PushUrl";
        /// <summary>
        /// 推送令牌
        /// </summary>
        public static readonly string PushToken = "PushToken";
        /// <summary>
        /// 创建时间
        /// </summary>
        public static readonly DateTime? CreationTime = "CreationTime";
        /// <summary>
        /// 创建人编号
        /// </summary>
        public static readonly int? CreatId = 1;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public static readonly DateTime? LastModifiTime = "LastModifiTime";
        /// <summary>
        /// 最后修改人编号
        /// </summary>
        public static readonly int? LastModifiId = 1;
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
        public static readonly Guid Id2 = "009768a1-ab40-4406-866a-806d3a6a2892".ToGuid();
        /// <summary>
        /// 名称
        /// </summary>
        public static readonly string Name2 = "Name2";
        /// <summary>
        /// 介绍
        /// </summary>
        public static readonly string Summary2 = "Summary2";
        /// <summary>
        /// 令牌
        /// </summary>
        public static readonly string Token2 = "Token2";
        /// <summary>
        /// 1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea
        /// </summary>
        public static readonly short Source2 = "Source2";
        /// <summary>
        /// 1.钉钉，2为企业微信
        /// </summary>
        public static readonly short Push2 = "Push2";
        /// <summary>
        /// 推送Url
        /// </summary>
        public static readonly string PushUrl2 = "PushUrl2";
        /// <summary>
        /// 推送令牌
        /// </summary>
        public static readonly string PushToken2 = "PushToken2";
        /// <summary>
        /// 创建时间
        /// </summary>
        public static readonly DateTime? CreationTime2 = "CreationTime2";
        /// <summary>
        /// 创建人编号
        /// </summary>
        public static readonly int? CreatId2 = 2;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public static readonly DateTime? LastModifiTime2 = "LastModifiTime2";
        /// <summary>
        /// 最后修改人编号
        /// </summary>
        public static readonly int? LastModifiId2 = 2;
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
        /// 创建网络勾子中转表实体
        /// </summary>
        public static WHMiddleware Create(string id = "") {
            return new WHMiddleware( id.ToGuid() ) {
                Name = Name,
                Summary = Summary,
                Token = Token,
                Source = Source,
                Push = Push,
                PushUrl = PushUrl,
                PushToken = PushToken,
                CreationTime = CreationTime,
                CreatId = CreatId,
                LastModifiTime = LastModifiTime,
                LastModifiId = LastModifiId,
                IsDeleted = IsDeleted,
                Version = Version,
            };
        }
        
        /// <summary>
        /// 创建网络勾子中转表实体2
        /// </summary>
        /// <param name="id">网络勾子中转表编号</param>
        public static WHMiddleware Create2( string id = "" ) {
            return new WHMiddleware( id.ToGuid() ) {
                Name = Name2,
                Summary = Summary2,
                Token = Token2,
                Source = Source2,
                Push = Push2,
                PushUrl = PushUrl2,
                PushToken = PushToken2,
                CreationTime = CreationTime2,
                CreatId = CreatId2,
                LastModifiTime = LastModifiTime2,
                LastModifiId = LastModifiId2,
                IsDeleted = IsDeleted2,
                Version = Version2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<WHMiddleware> CreateList() {
            return new List<WHMiddleware>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}