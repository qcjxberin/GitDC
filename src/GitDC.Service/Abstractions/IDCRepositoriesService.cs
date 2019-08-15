using Ding.Applications;
using GitDC.Domain.Models;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using LibGit2Sharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 仓库表服务
    /// </summary>
    public interface IDCRepositoriesService : ICrudService<DCRepositoriesDto, DCRepositoriesQuery> {
        /// <summary>
        /// 获取指定用户的仓库信息
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns></returns>
        Task<List<DCRepositories>> GetListByUserName(string UserName);

        /// <summary>
        /// 创建仓储
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Repository CreateRepository(string name);

        /// <summary>
        /// 创建创建
        /// </summary>
        /// <param name="name"></param>
        /// <param name="remoteUrl"></param>
        /// <returns></returns>
        Repository CreateRepository(string name, string remoteUrl);
    }
}