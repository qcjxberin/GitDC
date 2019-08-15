using Ding.Applications;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 仓库表服务
    /// </summary>
    public interface IDCRepositoriesService : ICrudService<DCRepositoriesDto, DCRepositoriesQuery> {
    }
}