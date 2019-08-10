using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class RepositoriesDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static RepositoriesDto Create(string id = "") {
            return RepositoriesTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static RepositoriesDto Create2( string id = "" ) {
            return RepositoriesTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
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
            Assert.Equal( RepositoriesTest.Id,dto.Id );
            Assert.Equal( RepositoriesTest.Name,dto.Name );
            Assert.Equal( RepositoriesTest.Description,dto.Description );
            Assert.Equal( RepositoriesTest.CreationDate,dto.CreationDate );
            Assert.Equal( RepositoriesTest.IsPrivate,dto.IsPrivate );
            Assert.Equal( RepositoriesTest.AllowAnonymousRead,dto.AllowAnonymousRead );
            Assert.Equal( RepositoriesTest.AllowAnonymousWrite,dto.AllowAnonymousWrite );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( RepositoriesTest.Id,entity.Id );
            Assert.Equal( RepositoriesTest.Name,entity.Name );
            Assert.Equal( RepositoriesTest.Description,entity.Description );
            Assert.Equal( RepositoriesTest.CreationDate,entity.CreationDate );
            Assert.Equal( RepositoriesTest.IsPrivate,entity.IsPrivate );
            Assert.Equal( RepositoriesTest.AllowAnonymousRead,entity.AllowAnonymousRead );
            Assert.Equal( RepositoriesTest.AllowAnonymousWrite,entity.AllowAnonymousWrite );
        }
    }
}