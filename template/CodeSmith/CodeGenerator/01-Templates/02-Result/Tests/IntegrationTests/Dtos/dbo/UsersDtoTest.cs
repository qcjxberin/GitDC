using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 用户名数据传输对象测试
    /// </summary>
    public class UsersDtoTest {
        /// <summary>
        /// 创建用户名数据传输对象
        /// </summary>
        public static UsersDto Create(string id = "") {
            return UsersTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建用户名数据传输对象2
        /// </summary>
        /// <param name="id">用户名编号</param>
        public static UsersDto Create2( string id = "" ) {
            return UsersTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建用户名数据传输对象列表
        /// </summary>
        public static List<UsersDto> CreateList() {
            return new List<UsersDto>() {
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
            Assert.Equal( UsersTest.Id,dto.Id );
            Assert.Equal( UsersTest.Name,dto.Name );
            Assert.Equal( UsersTest.NickName,dto.NickName );
            Assert.Equal( UsersTest.Email,dto.Email );
            Assert.Equal( UsersTest.PasswordVersion,dto.PasswordVersion );
            Assert.Equal( UsersTest.Password,dto.Password );
            Assert.Equal( UsersTest.Description,dto.Description );
            Assert.Equal( UsersTest.IsSystemAdministrator,dto.IsSystemAdministrator );
            Assert.Equal( UsersTest.CreationTime,dto.CreationTime );
            Assert.Equal( UsersTest.CreatId,dto.CreatId );
            Assert.Equal( UsersTest.LastModifiTime,dto.LastModifiTime );
            Assert.Equal( UsersTest.LastModifiId,dto.LastModifiId );
            Assert.Equal( UsersTest.IsDeleted,dto.IsDeleted );
            Assert.Equal( UsersTest.Version,dto.Version );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( UsersTest.Id,entity.Id );
            Assert.Equal( UsersTest.Name,entity.Name );
            Assert.Equal( UsersTest.NickName,entity.NickName );
            Assert.Equal( UsersTest.Email,entity.Email );
            Assert.Equal( UsersTest.PasswordVersion,entity.PasswordVersion );
            Assert.Equal( UsersTest.Password,entity.Password );
            Assert.Equal( UsersTest.Description,entity.Description );
            Assert.Equal( UsersTest.IsSystemAdministrator,entity.IsSystemAdministrator );
            Assert.Equal( UsersTest.CreationTime,entity.CreationTime );
            Assert.Equal( UsersTest.CreatId,entity.CreatId );
            Assert.Equal( UsersTest.LastModifiTime,entity.LastModifiTime );
            Assert.Equal( UsersTest.LastModifiId,entity.LastModifiId );
            Assert.Equal( UsersTest.IsDeleted,entity.IsDeleted );
            Assert.Equal( UsersTest.Version,entity.Version );
        }
    }
}