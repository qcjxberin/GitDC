using System;
using System.Collections.Generic;
using Xunit;
using GitDC.Service.Dtos.dbo;
using GitDC.Test.Models.dbo;

namespace GitDC.Test.Integration.Dtos.dbo {
    /// <summary>
    /// 数据传输对象测试
    /// </summary>
    public class SshKeysDtoTest {
        /// <summary>
        /// 创建数据传输对象
        /// </summary>
        public static SshKeysDto Create(string id = "") {
            return SshKeysTest.Create(id).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象2
        /// </summary>
        /// <param name="id">编号</param>
        public static SshKeysDto Create2( string id = "" ) {
            return SshKeysTest.Create2( id ).ToDto(); 
        }
        
        /// <summary>
        /// 创建数据传输对象列表
        /// </summary>
        public static List<SshKeysDto> CreateList() {
            return new List<SshKeysDto>() {
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
            Assert.Equal( SshKeysTest.Id,dto.Id );
            Assert.Equal( SshKeysTest.UserID,dto.UserID );
            Assert.Equal( SshKeysTest.KeyType,dto.KeyType );
            Assert.Equal( SshKeysTest.Fingerprint,dto.Fingerprint );
            Assert.Equal( SshKeysTest.PublicKey,dto.PublicKey );
            Assert.Equal( SshKeysTest.ImportData,dto.ImportData );
            Assert.Equal( SshKeysTest.LastUse,dto.LastUse );
        }
        
        /// <summary>
        /// 转换为实体
        /// </summary>
        [Fact]
        public void TestToEntity() {
            var entity = Create().ToEntity();
            Assert.Equal( SshKeysTest.Id,entity.Id );
            Assert.Equal( SshKeysTest.UserID,entity.UserID );
            Assert.Equal( SshKeysTest.KeyType,entity.KeyType );
            Assert.Equal( SshKeysTest.Fingerprint,entity.Fingerprint );
            Assert.Equal( SshKeysTest.PublicKey,entity.PublicKey );
            Assert.Equal( SshKeysTest.ImportData,entity.ImportData );
            Assert.Equal( SshKeysTest.LastUse,entity.LastUse );
        }
    }
}