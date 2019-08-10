using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class TeamRepositoryRoleFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="id"></param>
        /// <param name="teamID"></param>
        /// <param name="repositoryID"></param>
        /// <param name="allowRead"></param>
        /// <param name="allowWrite"></param>
        public static TeamRepositoryRole Create( 
            Guid id,
            long teamID,
            long repositoryID,
            bool allowRead,
            bool allowWrite
        ) {
            TeamRepositoryRole result;
            result = new TeamRepositoryRole( id );
            result.TeamID = teamID;
            result.RepositoryID = repositoryID;
            result.AllowRead = allowRead;
            result.AllowWrite = allowWrite;
            return result;
        }
    }
}