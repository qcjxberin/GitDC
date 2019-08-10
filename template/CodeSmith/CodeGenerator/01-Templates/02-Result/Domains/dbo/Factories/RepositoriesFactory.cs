using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class RepositoriesFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="creationDate"></param>
        /// <param name="isPrivate"></param>
        /// <param name="allowAnonymousRead"></param>
        /// <param name="allowAnonymousWrite"></param>
        public static Repositories Create( 
            long id,
            string name,
            string description,
            DateTime creationDate,
            bool isPrivate,
            bool allowAnonymousRead,
            bool allowAnonymousWrite
        ) {
            Repositories result;
            result = new Repositories( id );
            result.Name = name;
            result.Description = description;
            result.CreationDate = creationDate;
            result.IsPrivate = isPrivate;
            result.AllowAnonymousRead = allowAnonymousRead;
            result.AllowAnonymousWrite = allowAnonymousWrite;
            return result;
        }
    }
}