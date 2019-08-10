using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 网络勾子推送内容日志测试
    /// </summary>
    public partial class WHLogsTest {
        /// <summary>
        /// 网络勾子推送内容日志
        /// </summary>
        private WHLogs _wHLogs;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public WHLogsTest() {
            _wHLogs = Create();
        }
    }
}