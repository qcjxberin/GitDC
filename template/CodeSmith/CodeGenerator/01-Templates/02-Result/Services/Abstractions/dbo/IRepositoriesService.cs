using Ding.Applications;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 服务
    /// </summary>
    public interface IRepositoriesService : ICrudService<RepositoriesDto, RepositoriesQuery> {
    }
}