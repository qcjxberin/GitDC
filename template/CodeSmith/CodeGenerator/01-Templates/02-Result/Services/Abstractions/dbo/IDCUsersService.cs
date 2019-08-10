using Ding.Applications;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 用户名服务
    /// </summary>
    public interface IDCUsersService : ICrudService<DCUsersDto, DCUsersQuery> {
    }
}