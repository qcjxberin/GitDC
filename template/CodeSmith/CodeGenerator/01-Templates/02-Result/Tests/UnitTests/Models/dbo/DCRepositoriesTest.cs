using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 仓库表测试
    /// </summary>
    public partial class DCRepositoriesTest {
        /// <summary>
        /// 仓库表
        /// </summary>
        private DCRepositories _dCRepositories;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public DCRepositoriesTest() {
            _dCRepositories = Create();
        }
    }
}