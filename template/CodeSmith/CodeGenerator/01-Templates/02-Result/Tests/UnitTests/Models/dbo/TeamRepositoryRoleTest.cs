using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class TeamRepositoryRoleTest {
        /// <summary>
        /// 
        /// </summary>
        private TeamRepositoryRole _teamRepositoryRole;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public TeamRepositoryRoleTest() {
            _teamRepositoryRole = Create();
        }
    }
}