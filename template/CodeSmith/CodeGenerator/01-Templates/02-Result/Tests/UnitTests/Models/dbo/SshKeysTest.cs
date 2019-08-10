using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class SshKeysTest {
        /// <summary>
        /// 
        /// </summary>
        private SshKeys _sshKeys;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public SshKeysTest() {
            _sshKeys = Create();
        }
    }
}