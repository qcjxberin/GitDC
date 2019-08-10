using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试数据
    /// </summary>
    public partial class TeamsTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly long Id = "19bf7bdc-889e-4b8c-9282-8526e8db8f58".ToLong();
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
        
        #endregion
        
        #region 测试数据2
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly long Id2 = "5129cd86-6579-4923-b4eb-9bc10aa4f2f7".ToLong();
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
        
        #endregion
        
        #region Create(创建实体)
        
        /// <summary>
        /// 创建实体
        /// </summary>
        public static Teams Create(string id = "") {
            return new Teams( id.ToLong() ) {
                Name = Name,
                Description = Description,
                CreationDate = CreationDate,
            };
        }
        
        /// <summary>
        /// 创建实体2
        /// </summary>
        /// <param name="id">编号</param>
        public static Teams Create2( string id = "" ) {
            return new Teams( id.ToLong() ) {
                Name = Name2,
                Description = Description2,
                CreationDate = CreationDate2,
            };
        }
        
        #endregion
        
        #region CreateList(创建列表)

        /// <summary>
        /// 创建列表
        /// </summary>
        public static List<Teams> CreateList() {
            return new List<Teams>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}