using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 用户名数据传输对象测试
    /// </summary>
    public class DCUsersDtoTest {
        /// <summary>
        /// 创建用户名数据传输对象
        /// </summary>
        public static DCUsersDto Create(string id = "") {
            return DCUsersTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建用户名数据传输对象2
        /// </summary>
        /// <param name="id">用户名编号</param>
        public static DCUsersDto Create2( string id = "" ) {
            return DCUsersTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建用户名数据传输对象列表
        /// </summary>
        public static List<DCUsersDto> CreateList() {
            return new List<DCUsersDto>() {
                Create(),
                Create2()
            };
        }
        
        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        [Fact]
        public void TestToDto() {
            var dto = Create();
            Assert.Equal( DCUsersTest.Id,dto.Id );
            Assert.Equal( DCUsersTest.Name,dto.Name );
            Assert.Equal( DCUsersTest.NickName,dto.NickName );
            Assert.Equal( DCUsersTest.Email,dto.Email );
            Assert.Equal( DCUsersTest.PasswordVersion,dto.PasswordVersion );
            Assert.Equal( DCUsersTest.Password,dto.Password );
            Assert.Equal( DCUsersTest.Salt,dto.Salt );
            Assert.Equal( DCUsersTest.Description,dto.Description );
            Assert.Equal( DCUsersTest.IsSystemAdministrator,dto.IsSystemAdministrator );
            Assert.Equal( DCUsersTest.CreationTime,dto.CreationTime );
            Assert.Equal( DCUsersTest.CreatId,dto.CreatId );
            Assert.Equal( DCUsersTest.LastModifiTime,dto.LastModifiTime );
            Assert.Equal( DCUsersTest.LastModifiId,dto.LastModifiId );
            Assert.Equal( DCUsersTest.IsDeleted,dto.IsDeleted );
            Assert.Equal( DCUsersTest.Version,dto.Version );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( DCUsersTest.Id,entity.Id );
            Assert.Equal( DCUsersTest.Name,entity.Name );
            Assert.Equal( DCUsersTest.NickName,entity.NickName );
            Assert.Equal( DCUsersTest.Email,entity.Email );
            Assert.Equal( DCUsersTest.PasswordVersion,entity.PasswordVersion );
            Assert.Equal( DCUsersTest.Password,entity.Password );
            Assert.Equal( DCUsersTest.Salt,entity.Salt );
            Assert.Equal( DCUsersTest.Description,entity.Description );
            Assert.Equal( DCUsersTest.IsSystemAdministrator,entity.IsSystemAdministrator );
            Assert.Equal( DCUsersTest.CreationTime,entity.CreationTime );
            Assert.Equal( DCUsersTest.CreatId,entity.CreatId );
            Assert.Equal( DCUsersTest.LastModifiTime,entity.LastModifiTime );
            Assert.Equal( DCUsersTest.LastModifiId,entity.LastModifiId );
            Assert.Equal( DCUsersTest.IsDeleted,entity.IsDeleted );
            Assert.Equal( DCUsersTest.Version,entity.Version );
        }
    }
}