using Ding.Applications;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 网络勾子中转表服务
    /// </summary>
    public interface IWHMiddlewareService : ICrudService<WHMiddlewareDto, WHMiddlewareQuery> {
    }
}