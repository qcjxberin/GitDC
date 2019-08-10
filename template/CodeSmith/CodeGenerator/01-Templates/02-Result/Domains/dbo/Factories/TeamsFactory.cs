using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class TeamsFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="creationDate"></param>
        public static Teams Create( 
            long id,
            string name,
            string description,
            DateTime creationDate
        ) {
            Teams result;
            result = new Teams( id );
            result.Name = name;
            result.Description = description;
            result.CreationDate = creationDate;
            return result;
        }
    }
}