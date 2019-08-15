using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 仓库表工厂
    /// </summary>
    public static class RepositoriesFactory {
        /// <summary>
        /// 创建仓库表
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="defaultBranch">默认分支</param>
        /// <param name="description">描述</param>
        /// <param name="isMirror">是否镜像</param>
        /// <param name="isPrivate">是否私人</param>
        /// <param name="name">项目名称</param>
        /// <param name="numIssues">问题数量</param>
        /// <param name="numOpenIssues">未关闭的问题数量</param>
        /// <param name="numOpenPulls">未关闭的合并请求数量</param>
        /// <param name="numPulls">合并请求数量</param>
        /// <param name="size">大小</param>
        /// <param name="userID">归属用户</param>
        /// <param name="userName">用户名称</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="lastModifiTime">最后修改时间</param>
        /// <param name="isDeleted">软删除，数据不会被物理删除</param>
        /// <param name="version">处理并发问题</param>
        public static Repositories Create( 
            Guid id,
            string defaultBranch,
            string description,
            bool? isMirror,
            bool? isPrivate,
            string name,
            int? numIssues,
            int? numOpenIssues,
            int? numOpenPulls,
            int? numPulls,
            decimal? size,
            long? userID,
            string userName,
            DateTime? creationTime,
            DateTime? lastModifiTime,
            bool isDeleted,
            Byte[] version
        ) {
            Repositories result;
            result = new Repositories( id );
            result.DefaultBranch = defaultBranch;
            result.Description = description;
            result.IsMirror = isMirror;
            result.IsPrivate = isPrivate;
            result.Name = name;
            result.NumIssues = numIssues;
            result.NumOpenIssues = numOpenIssues;
            result.NumOpenPulls = numOpenPulls;
            result.NumPulls = numPulls;
            result.Size = size;
            result.UserID = userID;
            result.UserName = userName;
            result.CreationTime = creationTime;
            result.LastModifiTime = lastModifiTime;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}