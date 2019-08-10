using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class RepositoriesTest {
        /// <summary>
        /// 
        /// </summary>
        private Repositories _repositories;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public RepositoriesTest() {
            _repositories = Create();
        }
    }
}