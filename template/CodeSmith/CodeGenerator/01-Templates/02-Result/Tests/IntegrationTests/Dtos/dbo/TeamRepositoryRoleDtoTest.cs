using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class TeamRepositoryRoleDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static TeamRepositoryRoleDto Create(string id = "") {
            return TeamRepositoryRoleTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static TeamRepositoryRoleDto Create2( string id = "" ) {
            return TeamRepositoryRoleTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
        /// </summary>
        public static List<TeamRepositoryRoleDto> CreateList() {
            return new List<TeamRepositoryRoleDto>() {
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
            Assert.Equal( TeamRepositoryRoleTest.Id.ToString(),dto.Id );
            Assert.Equal( TeamRepositoryRoleTest.TeamID,dto.TeamID );
            Assert.Equal( TeamRepositoryRoleTest.RepositoryID,dto.RepositoryID );
            Assert.Equal( TeamRepositoryRoleTest.AllowRead,dto.AllowRead );
            Assert.Equal( TeamRepositoryRoleTest.AllowWrite,dto.AllowWrite );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( TeamRepositoryRoleTest.Id,entity.Id );
            Assert.Equal( TeamRepositoryRoleTest.TeamID,entity.TeamID );
            Assert.Equal( TeamRepositoryRoleTest.RepositoryID,entity.RepositoryID );
            Assert.Equal( TeamRepositoryRoleTest.AllowRead,entity.AllowRead );
            Assert.Equal( TeamRepositoryRoleTest.AllowWrite,entity.AllowWrite );
        }
    }
}