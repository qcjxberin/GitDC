using Ding.Domains.Repositories;
using GitDC.Domain.Models;

namespace GitDC.Domain.Repositories {
    /// <summary>
    /// 网络勾子中转表仓储
    /// </summary>
    public interface IWHMiddlewareRepository : ICompactRepository<WHMiddleware> {
    }
}