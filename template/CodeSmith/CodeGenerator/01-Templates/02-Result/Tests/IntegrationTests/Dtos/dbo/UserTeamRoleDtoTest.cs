using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class UserTeamRoleDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static UserTeamRoleDto Create(string id = "") {
            return UserTeamRoleTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static UserTeamRoleDto Create2( string id = "" ) {
            return UserTeamRoleTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
        /// </summary>
        public static List<UserTeamRoleDto> CreateList() {
            return new List<UserTeamRoleDto>() {
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
            Assert.Equal( UserTeamRoleTest.Id.ToString(),dto.Id );
            Assert.Equal( UserTeamRoleTest.UserID,dto.UserID );
            Assert.Equal( UserTeamRoleTest.TeamID,dto.TeamID );
            Assert.Equal( UserTeamRoleTest.IsAdministrator,dto.IsAdministrator );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( UserTeamRoleTest.Id,entity.Id );
            Assert.Equal( UserTeamRoleTest.UserID,entity.UserID );
            Assert.Equal( UserTeamRoleTest.TeamID,entity.TeamID );
            Assert.Equal( UserTeamRoleTest.IsAdministrator,entity.IsAdministrator );
        }
    }
}