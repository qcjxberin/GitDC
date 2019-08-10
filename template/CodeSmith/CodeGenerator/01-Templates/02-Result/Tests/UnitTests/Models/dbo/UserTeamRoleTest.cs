using Xunit;
using GitDC.Domain.Models;

namespace GitDC.Test.Models.dbo {
    /// <summary>
    /// 测试
    /// </summary>
    public partial class UserTeamRoleTest {
        /// <summary>
        /// 
        /// </summary>
        private UserTeamRole _userTeamRole;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UserTeamRoleTest() {
            _userTeamRole = Create();
        }
    }
}