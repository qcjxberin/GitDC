using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class RepositoriesTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly long Id = "50e06dcd-6075-4fc8-9e4e-9310c5086f5c".ToLong();
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Name = "Name";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Description = "Description";
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime CreationDate = "2019/8/1 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsPrivate = true;
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowAnonymousRead = true;
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowAnonymousWrite = true;
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly long Id2 = "4b5c77b7-3a77-485f-ba0f-f9fe16d0db39".ToLong();
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Name2 = "Name2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly string Description2 = "Description2";
        /// <summary>
        /// 
        /// </summary>
        public static readonly DateTime CreationDate2 = "2019/8/2 21:48:52".ToDate();
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool IsPrivate2 = true;
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowAnonymousRead2 = true;
        /// <summary>
        /// 
        /// </summary>
        public static readonly bool AllowAnonymousWrite2 = true;
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static Repositories Create(string id = "") {
            return new Repositories( id.ToLong() ) {
                Name = Name,
                Description = Description,
                CreationDate = CreationDate,
                IsPrivate = IsPrivate,
                AllowAnonymousRead = AllowAnonymousRead,
                AllowAnonymousWrite = AllowAnonymousWrite,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static Repositories Create2( string id = "" ) {
            return new Repositories( id.ToLong() ) {
                Name = Name2,
                Description = Description2,
                CreationDate = CreationDate2,
                IsPrivate = IsPrivate2,
                AllowAnonymousRead = AllowAnonymousRead2,
                AllowAnonymousWrite = AllowAnonymousWrite2,
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