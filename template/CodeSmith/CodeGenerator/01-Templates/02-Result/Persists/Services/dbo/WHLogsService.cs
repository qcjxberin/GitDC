using Ding;
using Ding.Maps;
using Ding.Domains.Repositories;
using Ding.Datas.Queries;
using Ding.Applications;
using GitDC.Data;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;

namespace GitDC.Service.Implements.dbo {
    /// <summary>
    /// 网络勾子推送内容日志服务
    /// </summary>
    public class WHLogsService : CrudServiceBase<WHLogsPo, WHLogsDto, WHLogsQuery>, IWHLogsService {
        /// <summary>
        /// 初始化网络勾子推送内容日志服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="wHLogsStore">网络勾子推送内容日志存储器</param>
        public WHLogsService( IGitDCUnitOfWork unitOfWork, IWHLogsPoStore wHLogsStore )
            : base( unitOfWork, wHLogsStore ) {
            WHLogsStore = wHLogsStore;
        }
        
        /// <summary>
        /// 网络勾子推送内容日志存储器
        /// </summary>
        public IWHLogsPoStore WHLogsStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<WHLogsPo> CreateQuery( WHLogsQuery param ) {
            return new Query<WHLogsPo>( param );
        }
    }
}