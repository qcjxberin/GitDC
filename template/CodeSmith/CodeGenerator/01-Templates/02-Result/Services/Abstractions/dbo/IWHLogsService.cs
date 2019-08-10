using Ding.Applications;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 网络勾子推送内容日志服务
    /// </summary>
    public interface IWHLogsService : ICrudService<WHLogsDto, WHLogsQuery> {
    }
}