using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 用户名测试
    /// </summary>
    public partial class DCUsersTest {
        /// <summary>
        /// 用户名
        /// </summary>
        private DCUsers _dCUsers;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public DCUsersTest() {
            _dCUsers = Create();
        }
    }
}