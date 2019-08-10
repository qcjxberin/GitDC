using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 网络勾子中转表数据传输对象测试
    /// </summary>
    public class WHMiddlewareDtoTest {
        /// <summary>
        /// 创建网络勾子中转表数据传输对象
        /// </summary>
        public static WHMiddlewareDto Create(string id = "") {
            return WHMiddlewareTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建网络勾子中转表数据传输对象2
        /// </summary>
        /// <param name="id">网络勾子中转表编号</param>
        public static WHMiddlewareDto Create2( string id = "" ) {
            return WHMiddlewareTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建网络勾子中转表数据传输对象列表
        /// </summary>
        public static List<WHMiddlewareDto> CreateList() {
            return new List<WHMiddlewareDto>() {
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
            Assert.Equal( WHMiddlewareTest.Id.ToString(),dto.Id );
            Assert.Equal( WHMiddlewareTest.Token,dto.Token );
            Assert.Equal( WHMiddlewareTest.Source,dto.Source );
            Assert.Equal( WHMiddlewareTest.Push,dto.Push );
            Assert.Equal( WHMiddlewareTest.PushUrl,dto.PushUrl );
            Assert.Equal( WHMiddlewareTest.PushToken,dto.PushToken );
            Assert.Equal( WHMiddlewareTest.CreationTime,dto.CreationTime );
            Assert.Equal( WHMiddlewareTest.CreatId,dto.CreatId );
            Assert.Equal( WHMiddlewareTest.LastModifiTime,dto.LastModifiTime );
            Assert.Equal( WHMiddlewareTest.LastModifiId,dto.LastModifiId );
            Assert.Equal( WHMiddlewareTest.IsDeleted,dto.IsDeleted );
            Assert.Equal( WHMiddlewareTest.Version,dto.Version );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( WHMiddlewareTest.Id,entity.Id );
            Assert.Equal( WHMiddlewareTest.Token,entity.Token );
            Assert.Equal( WHMiddlewareTest.Source,entity.Source );
            Assert.Equal( WHMiddlewareTest.Push,entity.Push );
            Assert.Equal( WHMiddlewareTest.PushUrl,entity.PushUrl );
            Assert.Equal( WHMiddlewareTest.PushToken,entity.PushToken );
            Assert.Equal( WHMiddlewareTest.CreationTime,entity.CreationTime );
            Assert.Equal( WHMiddlewareTest.CreatId,entity.CreatId );
            Assert.Equal( WHMiddlewareTest.LastModifiTime,entity.LastModifiTime );
            Assert.Equal( WHMiddlewareTest.LastModifiId,entity.LastModifiId );
            Assert.Equal( WHMiddlewareTest.IsDeleted,entity.IsDeleted );
            Assert.Equal( WHMiddlewareTest.Version,entity.Version );
        }
    }
}