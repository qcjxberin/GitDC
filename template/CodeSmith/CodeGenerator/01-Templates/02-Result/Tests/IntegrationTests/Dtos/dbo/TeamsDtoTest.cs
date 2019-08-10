using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class TeamsDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static TeamsDto Create(string id = "") {
            return TeamsTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static TeamsDto Create2( string id = "" ) {
            return TeamsTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
        /// </summary>
        public static List<TeamsDto> CreateList() {
            return new List<TeamsDto>() {
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
            Assert.Equal( TeamsTest.Id,dto.Id );
            Assert.Equal( TeamsTest.Name,dto.Name );
            Assert.Equal( TeamsTest.Description,dto.Description );
            Assert.Equal( TeamsTest.CreationDate,dto.CreationDate );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( TeamsTest.Id,entity.Id );
            Assert.Equal( TeamsTest.Name,entity.Name );
            Assert.Equal( TeamsTest.Description,entity.Description );
            Assert.Equal( TeamsTest.CreationDate,entity.CreationDate );
        }
    }
}