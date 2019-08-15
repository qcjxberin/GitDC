using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 仓库表数据传输对象测试
    /// </summary>
    public class DCRepositoriesDtoTest {
        /// <summary>
        /// 创建仓库表数据传输对象
        /// </summary>
        public static DCRepositoriesDto Create(string id = "") {
            return DCRepositoriesTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建仓库表数据传输对象2
        /// </summary>
        /// <param name="id">仓库表编号</param>
        public static DCRepositoriesDto Create2( string id = "" ) {
            return DCRepositoriesTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建仓库表数据传输对象列表
        /// </summary>
        public static List<DCRepositoriesDto> CreateList() {
            return new List<DCRepositoriesDto>() {
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
            Assert.Equal( DCRepositoriesTest.Id.ToString(),dto.Id );
            Assert.Equal( DCRepositoriesTest.DefaultBranch,dto.DefaultBranch );
            Assert.Equal( DCRepositoriesTest.Description,dto.Description );
            Assert.Equal( DCRepositoriesTest.IsMirror,dto.IsMirror );
            Assert.Equal( DCRepositoriesTest.IsPrivate,dto.IsPrivate );
            Assert.Equal( DCRepositoriesTest.Name,dto.Name );
            Assert.Equal( DCRepositoriesTest.NumIssues,dto.NumIssues );
            Assert.Equal( DCRepositoriesTest.NumOpenIssues,dto.NumOpenIssues );
            Assert.Equal( DCRepositoriesTest.NumOpenPulls,dto.NumOpenPulls );
            Assert.Equal( DCRepositoriesTest.NumPulls,dto.NumPulls );
            Assert.Equal( DCRepositoriesTest.Size,dto.Size );
            Assert.Equal( DCRepositoriesTest.UserID,dto.UserID );
            Assert.Equal( DCRepositoriesTest.UserName,dto.UserName );
            Assert.Equal( DCRepositoriesTest.CreationTime,dto.CreationTime );
            Assert.Equal( DCRepositoriesTest.LastModifiTime,dto.LastModifiTime );
            Assert.Equal( DCRepositoriesTest.IsDeleted,dto.IsDeleted );
            Assert.Equal( DCRepositoriesTest.Version,dto.Version );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( DCRepositoriesTest.Id,entity.Id );
            Assert.Equal( DCRepositoriesTest.DefaultBranch,entity.DefaultBranch );
            Assert.Equal( DCRepositoriesTest.Description,entity.Description );
            Assert.Equal( DCRepositoriesTest.IsMirror,entity.IsMirror );
            Assert.Equal( DCRepositoriesTest.IsPrivate,entity.IsPrivate );
            Assert.Equal( DCRepositoriesTest.Name,entity.Name );
            Assert.Equal( DCRepositoriesTest.NumIssues,entity.NumIssues );
            Assert.Equal( DCRepositoriesTest.NumOpenIssues,entity.NumOpenIssues );
            Assert.Equal( DCRepositoriesTest.NumOpenPulls,entity.NumOpenPulls );
            Assert.Equal( DCRepositoriesTest.NumPulls,entity.NumPulls );
            Assert.Equal( DCRepositoriesTest.Size,entity.Size );
            Assert.Equal( DCRepositoriesTest.UserID,entity.UserID );
            Assert.Equal( DCRepositoriesTest.UserName,entity.UserName );
            Assert.Equal( DCRepositoriesTest.CreationTime,entity.CreationTime );
            Assert.Equal( DCRepositoriesTest.LastModifiTime,entity.LastModifiTime );
            Assert.Equal( DCRepositoriesTest.IsDeleted,entity.IsDeleted );
            Assert.Equal( DCRepositoriesTest.Version,entity.Version );
        }
    }
}