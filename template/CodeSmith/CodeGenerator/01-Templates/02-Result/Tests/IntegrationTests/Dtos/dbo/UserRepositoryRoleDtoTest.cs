using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class UserRepositoryRoleDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static UserRepositoryRoleDto Create(string id = "") {
            return UserRepositoryRoleTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static UserRepositoryRoleDto Create2( string id = "" ) {
            return UserRepositoryRoleTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
        /// </summary>
        public static List<UserRepositoryRoleDto> CreateList() {
            return new List<UserRepositoryRoleDto>() {
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
            Assert.Equal( UserRepositoryRoleTest.Id.ToString(),dto.Id );
            Assert.Equal( UserRepositoryRoleTest.UserID,dto.UserID );
            Assert.Equal( UserRepositoryRoleTest.RepositoryID,dto.RepositoryID );
            Assert.Equal( UserRepositoryRoleTest.AllowRead,dto.AllowRead );
            Assert.Equal( UserRepositoryRoleTest.AllowWrite,dto.AllowWrite );
            Assert.Equal( UserRepositoryRoleTest.IsOwner,dto.IsOwner );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( UserRepositoryRoleTest.Id,entity.Id );
            Assert.Equal( UserRepositoryRoleTest.UserID,entity.UserID );
            Assert.Equal( UserRepositoryRoleTest.RepositoryID,entity.RepositoryID );
            Assert.Equal( UserRepositoryRoleTest.AllowRead,entity.AllowRead );
            Assert.Equal( UserRepositoryRoleTest.AllowWrite,entity.AllowWrite );
            Assert.Equal( UserRepositoryRoleTest.IsOwner,entity.IsOwner );
        }
    }
}