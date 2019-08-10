using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class UserTeamRoleFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userID"></param>
        /// <param name="teamID"></param>
        /// <param name="isAdministrator"></param>
        public static UserTeamRole Create( 
            Guid id,
            long userID,
            long teamID,
            bool isAdministrator
        ) {
            UserTeamRole result;
            result = new UserTeamRole( id );
            result.UserID = userID;
            result.TeamID = teamID;
            result.IsAdministrator = isAdministrator;
            return result;
        }
    }
}