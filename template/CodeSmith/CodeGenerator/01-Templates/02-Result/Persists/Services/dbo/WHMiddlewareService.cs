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
    /// 网络勾子中转表服务
    /// </summary>
    public class WHMiddlewareService : CrudServiceBase<WHMiddlewarePo, WHMiddlewareDto, WHMiddlewareQuery>, IWHMiddlewareService {
        /// <summary>
        /// 初始化网络勾子中转表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="wHMiddlewareStore">网络勾子中转表存储器</param>
        public WHMiddlewareService( IGitDCUnitOfWork unitOfWork, IWHMiddlewarePoStore wHMiddlewareStore )
            : base( unitOfWork, wHMiddlewareStore ) {
            WHMiddlewareStore = wHMiddlewareStore;
        }
        
        /// <summary>
        /// 网络勾子中转表存储器
        /// </summary>
        public IWHMiddlewarePoStore WHMiddlewareStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<WHMiddlewarePo> CreateQuery( WHMiddlewareQuery param ) {
            return new Query<WHMiddlewarePo>( param );
        }
    }
}