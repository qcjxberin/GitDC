using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 网络勾子中转表工厂
    /// </summary>
    public static class WHMiddlewareFactory {
        /// <summary>
        /// 创建网络勾子中转表
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="name">名称</param>
        /// <param name="summary">介绍</param>
        /// <param name="token">令牌</param>
        /// <param name="source">1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea</param>
        /// <param name="push">1.钉钉，2为企业微信</param>
        /// <param name="pushUrl">推送Url</param>
        /// <param name="pushToken">推送令牌</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatId">创建人编号</param>
        /// <param name="lastModifiTime">最后修改时间</param>
        /// <param name="lastModifiId">最后修改人编号</param>
        /// <param name="isDeleted">软删除，数据不会被物理删除</param>
        /// <param name="version">处理并发问题</param>
        public static WHMiddleware Create( 
            Guid id,
            string name,
            string summary,
            string token,
            short source,
            short push,
            string pushUrl,
            string pushToken,
            DateTime? creationTime,
            int? creatId,
            DateTime? lastModifiTime,
            int? lastModifiId,
            bool isDeleted,
            Byte[] version
        ) {
            WHMiddleware result;
            result = new WHMiddleware( id );
            result.Name = name;
            result.Summary = summary;
            result.Token = token;
            result.Source = source;
            result.Push = push;
            result.PushUrl = pushUrl;
            result.PushToken = pushToken;
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