using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 仓库表测试数据
    /// </summary>
    public partial class RepositoriesTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 编号
        /// </summary>
        public static readonly Guid Id = "316302fc-000e-46d1-9ed1-9e30dc9942de".ToGuid();
        /// <summary>
        /// 默认分支
        /// </summary>
        public static readonly string DefaultBranch = "DefaultBranch";
        /// <summary>
        /// 描述
        /// </summary>
        public static readonly string Description = "Description";
        /// <summary>
        /// 是否镜像
        /// </summary>
        public static readonly bool? IsMirror = true;
        /// <summary>
        /// 是否私人
        /// </summary>
        public static readonly bool? IsPrivate = true;
        /// <summary>
        /// 项目名称
        /// </summary>
        public static readonly string Name = "Name";
        /// <summary>
        /// 问题数量
        /// </summary>
        public static readonly int? NumIssues = 1;
        /// <summary>
        /// 未关闭的问题数量
        /// </summary>
        public static readonly int? NumOpenIssues = 1;
        /// <summary>
        /// 未关闭的合并请求数量
        /// </summary>
        public static readonly int? NumOpenPulls = 1;
        /// <summary>
        /// 合并请求数量
        /// </summary>
        public static readonly int? NumPulls = 1;
        /// <summary>
        /// 大小
        /// </summary>
        public static readonly decimal? Size = 1;
        /// <summary>
        /// 归属用户
        /// </summary>
        public static readonly long? UserID = "UserID";
        /// <summary>
        /// 用户名称
        /// </summary>
        public static readonly string UserName = "UserName";
        /// <summary>
        /// 创建时间
        /// </summary>
        public static readonly DateTime? CreationTime = "CreationTime";
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public static readonly DateTime? LastModifiTime = "LastModifiTime";
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
        public static readonly Guid Id2 = "02be6b8f-15a8-467c-addf-347ca09acd76".ToGuid();
        /// <summary>
        /// 默认分支
        /// </summary>
        public static readonly string DefaultBranch2 = "DefaultBranch2";
        /// <summary>
        /// 描述
        /// </summary>
        public static readonly string Description2 = "Description2";
        /// <summary>
        /// 是否镜像
        /// </summary>
        public static readonly bool? IsMirror2 = true;
        /// <summary>
        /// 是否私人
        /// </summary>
        public static readonly bool? IsPrivate2 = true;
        /// <summary>
        /// 项目名称
        /// </summary>
        public static readonly string Name2 = "Name2";
        /// <summary>
        /// 问题数量
        /// </summary>
        public static readonly int? NumIssues2 = 2;
        /// <summary>
        /// 未关闭的问题数量
        /// </summary>
        public static readonly int? NumOpenIssues2 = 2;
        /// <summary>
        /// 未关闭的合并请求数量
        /// </summary>
        public static readonly int? NumOpenPulls2 = 2;
        /// <summary>
        /// 合并请求数量
        /// </summary>
        public static readonly int? NumPulls2 = 2;
        /// <summary>
        /// 大小
        /// </summary>
        public static readonly decimal? Size2 = 2;
        /// <summary>
        /// 归属用户
        /// </summary>
        public static readonly long? UserID2 = "UserID2";
        /// <summary>
        /// 用户名称
        /// </summary>
        public static readonly string UserName2 = "UserName2";
        /// <summary>
        /// 创建时间
        /// </summary>
        public static readonly DateTime? CreationTime2 = "CreationTime2";
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public static readonly DateTime? LastModifiTime2 = "LastModifiTime2";
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
        /// 创建仓库表实体
        /// </summary>
        public static Repositories Create(string id = "") {
            return new Repositories( id.ToGuid() ) {
                DefaultBranch = DefaultBranch,
                Description = Description,
                IsMirror = IsMirror,
                IsPrivate = IsPrivate,
                Name = Name,
                NumIssues = NumIssues,
                NumOpenIssues = NumOpenIssues,
                NumOpenPulls = NumOpenPulls,
                NumPulls = NumPulls,
                Size = Size,
                UserID = UserID,
                UserName = UserName,
                CreationTime = CreationTime,
                LastModifiTime = LastModifiTime,
                IsDeleted = IsDeleted,
                Version = Version,
            };
        }
        
        /// <summary>
        /// 创建仓库表实体2
        /// </summary>
        /// <param name="id">仓库表编号</param>
        public static Repositories Create2( string id = "" ) {
            return new Repositories( id.ToGuid() ) {
                DefaultBranch = DefaultBranch2,
                Description = Description2,
                IsMirror = IsMirror2,
                IsPrivate = IsPrivate2,
                Name = Name2,
                NumIssues = NumIssues2,
                NumOpenIssues = NumOpenIssues2,
                NumOpenPulls = NumOpenPulls2,
                NumPulls = NumPulls2,
                Size = Size2,
                UserID = UserID2,
                UserName = UserName2,
                CreationTime = CreationTime2,
                LastModifiTime = LastModifiTime2,
                IsDeleted = IsDeleted2,
                Version = Version2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<Repositories> CreateList() {
            return new List<Repositories>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}