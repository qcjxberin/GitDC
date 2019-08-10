using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class UserRepositoryRoleTest {
        /// <summary>
        /// 
        /// </summary>
        private UserRepositoryRole _userRepositoryRole;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UserRepositoryRoleTest() {
            _userRepositoryRole = Create();
        }
    }
}