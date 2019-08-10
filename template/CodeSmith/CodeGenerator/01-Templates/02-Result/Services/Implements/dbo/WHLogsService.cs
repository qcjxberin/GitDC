using Ding;
using Ding.Maps;
using Ding.Domains.Repositories;
using Ding.Datas.Queries;
using Ding.Applications;
using GitDC.Data;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Service.Implements.dbo {
    /// <summary>
    /// 网络勾子推送内容日志服务
    /// </summary>
    public class WHLogsService : CrudServiceBase<WHLogs, WHLogsDto, WHLogsQuery>, IWHLogsService {
        /// <summary>
        /// 初始化网络勾子推送内容日志服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="wHLogsRepository">网络勾子推送内容日志仓储</param>
        public WHLogsService( IGitDCUnitOfWork unitOfWork, IWHLogsRepository wHLogsRepository )
            : base( unitOfWork, wHLogsRepository ) {
            WHLogsRepository = wHLogsRepository;
        }
        
        /// <summary>
        /// 网络勾子推送内容日志仓储
        /// </summary>
        public IWHLogsRepository WHLogsRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<WHLogs> CreateQuery( WHLogsQuery param ) {
            return new Query<WHLogs>( param );
        }
    }
}