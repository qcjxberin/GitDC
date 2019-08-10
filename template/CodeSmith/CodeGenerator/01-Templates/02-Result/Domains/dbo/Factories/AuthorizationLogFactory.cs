using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class AuthorizationLogFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="authCode"></param>
        /// <param name="userID"></param>
        /// <param name="issueDate"></param>
        /// <param name="expires"></param>
        /// <param name="issueIp"></param>
        /// <param name="lastIp"></param>
        /// <param name="isValid"></param>
        public static AuthorizationLog Create( 
            Guid authCode,
            long userID,
            DateTime issueDate,
            DateTime expires,
            string issueIp,
            string lastIp,
            bool isValid
        ) {
            AuthorizationLog result;
            result = new AuthorizationLog( authCode );
            result.UserID = userID;
            result.IssueDate = issueDate;
            result.Expires = expires;
            result.IssueIp = issueIp;
            result.LastIp = lastIp;
            result.IsValid = isValid;
            return result;
        }
    }
}