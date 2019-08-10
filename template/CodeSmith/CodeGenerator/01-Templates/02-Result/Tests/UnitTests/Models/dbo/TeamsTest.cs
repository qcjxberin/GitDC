using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class TeamsTest {
        /// <summary>
        /// 
        /// </summary>
        private Teams _teams;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public TeamsTest() {
            _teams = Create();
        }
    }
}