using Ding.Domains.Repositories;
using GitDC.Domain.Models;

namespace GitDC.Domain.Repositories {
    /// <summary>
    /// 用户名仓储
    /// </summary>
    public interface IDCUsersRepository : IRepository<DCUsers,long> {
    }
}