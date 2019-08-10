using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class AuthorizationLogDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static AuthorizationLogDto Create(string id = "") {
            return AuthorizationLogTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static AuthorizationLogDto Create2( string id = "" ) {
            return AuthorizationLogTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
        /// </summary>
        public static List<AuthorizationLogDto> CreateList() {
            return new List<AuthorizationLogDto>() {
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
            Assert.Equal( AuthorizationLogTest.Id.ToString(),dto.Id );
            Assert.Equal( AuthorizationLogTest.UserID,dto.UserID );
            Assert.Equal( AuthorizationLogTest.IssueDate,dto.IssueDate );
            Assert.Equal( AuthorizationLogTest.Expires,dto.Expires );
            Assert.Equal( AuthorizationLogTest.IssueIp,dto.IssueIp );
            Assert.Equal( AuthorizationLogTest.LastIp,dto.LastIp );
            Assert.Equal( AuthorizationLogTest.IsValid,dto.IsValid );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( AuthorizationLogTest.Id,entity.Id );
            Assert.Equal( AuthorizationLogTest.UserID,entity.UserID );
            Assert.Equal( AuthorizationLogTest.IssueDate,entity.IssueDate );
            Assert.Equal( AuthorizationLogTest.Expires,entity.Expires );
            Assert.Equal( AuthorizationLogTest.IssueIp,entity.IssueIp );
            Assert.Equal( AuthorizationLogTest.LastIp,entity.LastIp );
            Assert.Equal( AuthorizationLogTest.IsValid,entity.IsValid );
        }
    }
}