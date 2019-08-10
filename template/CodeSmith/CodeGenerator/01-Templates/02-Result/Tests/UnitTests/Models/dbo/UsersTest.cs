using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 用户名测试
    /// </summary>
    public partial class UsersTest {
        /// <summary>
        /// 用户名
        /// </summary>
        private Users _users;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UsersTest() {
            _users = Create();
        }
    }
}