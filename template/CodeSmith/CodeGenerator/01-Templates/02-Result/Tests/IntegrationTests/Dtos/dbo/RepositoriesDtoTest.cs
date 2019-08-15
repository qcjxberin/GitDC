using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 仓库表数据传输对象测试
    /// </summary>
    public class RepositoriesDtoTest {
        /// <summary>
        /// 创建仓库表数据传输对象
        /// </summary>
        public static RepositoriesDto Create(string id = "") {
            return RepositoriesTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建仓库表数据传输对象2
        /// </summary>
        /// <param name="id">仓库表编号</param>
        public static RepositoriesDto Create2( string id = "" ) {
            return RepositoriesTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建仓库表数据传输对象列表
        /// </summary>
        public static List<RepositoriesDto> CreateList() {
            return new List<RepositoriesDto>() {
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
            Assert.Equal( RepositoriesTest.Id.ToString(),dto.Id );
            Assert.Equal( RepositoriesTest.DefaultBranch,dto.DefaultBranch );
            Assert.Equal( RepositoriesTest.Description,dto.Description );
            Assert.Equal( RepositoriesTest.IsMirror,dto.IsMirror );
            Assert.Equal( RepositoriesTest.IsPrivate,dto.IsPrivate );
            Assert.Equal( RepositoriesTest.Name,dto.Name );
            Assert.Equal( RepositoriesTest.NumIssues,dto.NumIssues );
            Assert.Equal( RepositoriesTest.NumOpenIssues,dto.NumOpenIssues );
            Assert.Equal( RepositoriesTest.NumOpenPulls,dto.NumOpenPulls );
            Assert.Equal( RepositoriesTest.NumPulls,dto.NumPulls );
            Assert.Equal( RepositoriesTest.Size,dto.Size );
            Assert.Equal( RepositoriesTest.UserID,dto.UserID );
            Assert.Equal( RepositoriesTest.UserName,dto.UserName );
            Assert.Equal( RepositoriesTest.CreationTime,dto.CreationTime );
            Assert.Equal( RepositoriesTest.LastModifiTime,dto.LastModifiTime );
            Assert.Equal( RepositoriesTest.IsDeleted,dto.IsDeleted );
            Assert.Equal( RepositoriesTest.Version,dto.Version );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( RepositoriesTest.Id,entity.Id );
            Assert.Equal( RepositoriesTest.DefaultBranch,entity.DefaultBranch );
            Assert.Equal( RepositoriesTest.Description,entity.Description );
            Assert.Equal( RepositoriesTest.IsMirror,entity.IsMirror );
            Assert.Equal( RepositoriesTest.IsPrivate,entity.IsPrivate );
            Assert.Equal( RepositoriesTest.Name,entity.Name );
            Assert.Equal( RepositoriesTest.NumIssues,entity.NumIssues );
            Assert.Equal( RepositoriesTest.NumOpenIssues,entity.NumOpenIssues );
            Assert.Equal( RepositoriesTest.NumOpenPulls,entity.NumOpenPulls );
            Assert.Equal( RepositoriesTest.NumPulls,entity.NumPulls );
            Assert.Equal( RepositoriesTest.Size,entity.Size );
            Assert.Equal( RepositoriesTest.UserID,entity.UserID );
            Assert.Equal( RepositoriesTest.UserName,entity.UserName );
            Assert.Equal( RepositoriesTest.CreationTime,entity.CreationTime );
            Assert.Equal( RepositoriesTest.LastModifiTime,entity.LastModifiTime );
            Assert.Equal( RepositoriesTest.IsDeleted,entity.IsDeleted );
            Assert.Equal( RepositoriesTest.Version,entity.Version );
        }
    }
}