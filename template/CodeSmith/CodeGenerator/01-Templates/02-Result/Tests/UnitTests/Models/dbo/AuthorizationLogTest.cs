using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class AuthorizationLogTest {
        /// <summary>
        /// 
        /// </summary>
        private AuthorizationLog _authorizationLog;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public AuthorizationLogTest() {
            _authorizationLog = Create();
        }
    }
}