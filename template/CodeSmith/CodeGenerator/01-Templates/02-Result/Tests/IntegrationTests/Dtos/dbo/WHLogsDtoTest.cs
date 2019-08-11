using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 网络勾子推送内容日志数据传输对象测试
    /// </summary>
    public class WHLogsDtoTest {
        /// <summary>
        /// 创建网络勾子推送内容日志数据传输对象
        /// </summary>
        public static WHLogsDto Create(string id = "") {
            return WHLogsTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建网络勾子推送内容日志数据传输对象2
        /// </summary>
        /// <param name="id">网络勾子推送内容日志编号</param>
        public static WHLogsDto Create2( string id = "" ) {
            return WHLogsTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建网络勾子推送内容日志数据传输对象列表
        /// </summary>
        public static List<WHLogsDto> CreateList() {
            return new List<WHLogsDto>() {
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
            Assert.Equal( WHLogsTest.Id.ToString(),dto.Id );
            Assert.Equal( WHLogsTest.WHTypes,dto.WHTypes );
            Assert.Equal( WHLogsTest.RequestTop,dto.RequestTop );
            Assert.Equal( WHLogsTest.Content,dto.Content );
            Assert.Equal( WHLogsTest.ResponseTop,dto.ResponseTop );
            Assert.Equal( WHLogsTest.ResponseContent,dto.ResponseContent );
            Assert.Equal( WHLogsTest.CreationTime,dto.CreationTime );
            Assert.Equal( WHLogsTest.IsDeleted,dto.IsDeleted );
            Assert.Equal( WHLogsTest.Version,dto.Version );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( WHLogsTest.Id,entity.Id );
            Assert.Equal( WHLogsTest.WHTypes,entity.WHTypes );
            Assert.Equal( WHLogsTest.RequestTop,entity.RequestTop );
            Assert.Equal( WHLogsTest.Content,entity.Content );
            Assert.Equal( WHLogsTest.ResponseTop,entity.ResponseTop );
            Assert.Equal( WHLogsTest.ResponseContent,entity.ResponseContent );
            Assert.Equal( WHLogsTest.CreationTime,entity.CreationTime );
            Assert.Equal( WHLogsTest.IsDeleted,entity.IsDeleted );
            Assert.Equal( WHLogsTest.Version,entity.Version );
        }
    }
}