using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 网络勾子推送内容日志工厂
    /// </summary>
    public static class WHLogsFactory {
        /// <summary>
        /// 创建网络勾子推送内容日志
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="wHTypes">是为中转，否为非中转</param>
        /// <param name="requestTop">请求头部</param>
        /// <param name="content">推送内容</param>
        /// <param name="responseTop">响应头部</param>
        /// <param name="responseContent">响应内容</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="isDeleted">软删除，数据不会被物理删除</param>
        /// <param name="version">处理并发问题</param>
        public static WHLogs Create( 
            Guid id,
            bool wHTypes,
            string requestTop,
            string content,
            string responseTop,
            string responseContent,
            DateTime? creationTime,
            bool isDeleted,
            Byte[] version
        ) {
            WHLogs result;
            result = new WHLogs( id );
            result.WHTypes = wHTypes;
            result.RequestTop = requestTop;
            result.Content = content;
            result.ResponseTop = responseTop;
            result.ResponseContent = responseContent;
            result.CreationTime = creationTime;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}