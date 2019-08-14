using System;
using System.Collections.Generic;
using Ding;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 用户名测试数据
    /// </summary>
    public partial class DCUsersTest {
        
        #region 测试数据1
        
        /// <summary>
        /// 编号
        /// </summary>
        public static readonly long Id = "c4f1bb00-5dbd-401e-a845-4118a90f4be6".ToLong();
        /// <summary>
        /// 用户名
        /// </summary>
        public static readonly string Name = "Name";
        /// <summary>
        /// 昵称
        /// </summary>
        public static readonly string NickName = "NickName";
        /// <summary>
        /// 邮箱
        /// </summary>
        public static readonly string Email = "Email";
        /// <summary>
        /// 密码版本
        /// </summary>
        public static readonly short? PasswordVersion = "PasswordVersion";
        /// <summary>
        /// 密码
        /// </summary>
        public static readonly string Password = "Password";
        /// <summary>
        /// 盐值
        /// </summary>
        public static readonly string Salt = "Salt";
        /// <summary>
        /// 描述
        /// </summary>
        public static readonly string Description = "Description";
        /// <summary>
        /// 是否系统管理员
        /// </summary>
        public static readonly bool? IsSystemAdministrator = true;
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
        public static readonly long Id2 = "938729f9-e8b1-467e-af2b-1debe928b6fd".ToLong();
        /// <summary>
        /// 用户名
        /// </summary>
        public static readonly string Name2 = "Name2";
        /// <summary>
        /// 昵称
        /// </summary>
        public static readonly string NickName2 = "NickName2";
        /// <summary>
        /// 邮箱
        /// </summary>
        public static readonly string Email2 = "Email2";
        /// <summary>
        /// 密码版本
        /// </summary>
        public static readonly short? PasswordVersion2 = "PasswordVersion2";
        /// <summary>
        /// 密码
        /// </summary>
        public static readonly string Password2 = "Password2";
        /// <summary>
        /// 盐值
        /// </summary>
        public static readonly string Salt2 = "Salt2";
        /// <summary>
        /// 描述
        /// </summary>
        public static readonly string Description2 = "Description2";
        /// <summary>
        /// 是否系统管理员
        /// </summary>
        public static readonly bool? IsSystemAdministrator2 = true;
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
        /// 创建用户名实体
        /// </summary>
        public static DCUsers Create(string id = "") {
            return new DCUsers( id.ToLong() ) {
                Name = Name,
                NickName = NickName,
                Email = Email,
                PasswordVersion = PasswordVersion,
                Password = Password,
                Salt = Salt,
                Description = Description,
                IsSystemAdministrator = IsSystemAdministrator,
                CreationTime = CreationTime,
                CreatId = CreatId,
                LastModifiTime = LastModifiTime,
                LastModifiId = LastModifiId,
                IsDeleted = IsDeleted,
                Version = Version,
            };
        }
        
        /// <summary>
        /// 创建用户名实体2
        /// </summary>
        /// <param name="id">用户名编号</param>
        public static DCUsers Create2( string id = "" ) {
            return new DCUsers( id.ToLong() ) {
                Name = Name2,
                NickName = NickName2,
                Email = Email2,
                PasswordVersion = PasswordVersion2,
                Password = Password2,
                Salt = Salt2,
                Description = Description2,
                IsSystemAdministrator = IsSystemAdministrator2,
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
        public static List<DCUsers> CreateList() {
            return new List<DCUsers>() {
                Create(),
                Create2()
            };
        }

        #endregion
    }
}