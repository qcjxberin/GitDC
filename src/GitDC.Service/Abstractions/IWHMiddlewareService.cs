using Ding.Applications;
using GitDC.Domain.Models;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using System.Threading.Tasks;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 网络勾子中转表服务
    /// </summary>
    public interface IWHMiddlewareService : ICrudService<WHMiddlewareDto, WHMiddlewareQuery> {
        /// <summary>
        /// 获取指定Token的数据
        /// </summary>
        /// <param name="Token"></param>
        /// <returns></returns>
        Task<WHMiddleware> GetByToken(string Token);
    }
}