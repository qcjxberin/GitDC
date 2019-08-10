using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 用户名工厂
    /// </summary>
    public static class UsersFactory {
        /// <summary>
        /// 创建用户名
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="name">用户名</param>
        /// <param name="nickName">昵称</param>
        /// <param name="email">邮箱</param>
        /// <param name="passwordVersion">密码版本</param>
        /// <param name="password">密码</param>
        /// <param name="description">描述</param>
        /// <param name="isSystemAdministrator">是否系统管理员</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatId">创建人编号</param>
        /// <param name="lastModifiTime">最后修改时间</param>
        /// <param name="lastModifiId">最后修改人编号</param>
        /// <param name="isDeleted">软删除，数据不会被物理删除</param>
        /// <param name="version">处理并发问题</param>
        public static Users Create( 
            long id,
            string name,
            string nickName,
            string email,
            short? passwordVersion,
            string password,
            string description,
            bool? isSystemAdministrator,
            DateTime? creationTime,
            int? creatId,
            DateTime? lastModifiTime,
            int? lastModifiId,
            bool isDeleted,
            Byte[] version
        ) {
            Users result;
            result = new Users( id );
            result.Name = name;
            result.NickName = nickName;
            result.Email = email;
            result.PasswordVersion = passwordVersion;
            result.Password = password;
            result.Description = description;
            result.IsSystemAdministrator = isSystemAdministrator;
            result.CreationTime = creationTime;
            result.CreatId = creatId;
            result.LastModifiTime = lastModifiTime;
            result.LastModifiId = lastModifiId;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}