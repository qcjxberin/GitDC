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
    /// 网络勾子中转表服务
    /// </summary>
    public class WHMiddlewareService : CrudServiceBase<WHMiddleware, WHMiddlewareDto, WHMiddlewareQuery>, IWHMiddlewareService {
        /// <summary>
        /// 初始化网络勾子中转表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="wHMiddlewareRepository">网络勾子中转表仓储</param>
        public WHMiddlewareService( IGitDCUnitOfWork unitOfWork, IWHMiddlewareRepository wHMiddlewareRepository )
            : base( unitOfWork, wHMiddlewareRepository ) {
            WHMiddlewareRepository = wHMiddlewareRepository;
        }
        
        /// <summary>
        /// 网络勾子中转表仓储
        /// </summary>
        public IWHMiddlewareRepository WHMiddlewareRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<WHMiddleware> CreateQuery( WHMiddlewareQuery param ) {
            return new Query<WHMiddleware>( param );
        }
    }
}