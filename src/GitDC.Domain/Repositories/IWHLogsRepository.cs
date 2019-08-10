using Ding.Domains.Repositories;
using GitDC.Domain.Models;

namespace GitDC.Domain.Repositories {
    /// <summary>
    /// 网络勾子推送内容日志仓储
    /// </summary>
    public interface IWHLogsRepository : IRepository<WHLogs> {
    }
}