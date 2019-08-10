using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 网络勾子中转表测试
    /// </summary>
    public partial class WHMiddlewareTest {
        /// <summary>
        /// 网络勾子中转表
        /// </summary>
        private WHMiddleware _wHMiddleware;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public WHMiddlewareTest() {
            _wHMiddleware = Create();
        }
    }
}