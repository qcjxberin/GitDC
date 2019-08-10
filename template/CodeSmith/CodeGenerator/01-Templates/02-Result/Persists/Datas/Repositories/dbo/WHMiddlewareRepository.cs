using Util.Datas.Ef.Core;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;
using GitDC.Data.Pos.dbo.Extensions;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 网络勾子中转表仓储
    /// </summary>
    public class WHMiddlewareRepository : CompactRepositoryBase<WHMiddleware,WHMiddlewarePo>, IWHMiddlewareRepository {
        /// <summary>
        /// 初始化网络勾子中转表仓储
        /// </summary>
        /// <param name="store">网络勾子中转表存储器</param>
        public WHMiddlewareRepository( IWHMiddlewarePoStore store ) : base( store ) {
        }
        
        /// <summary>
        /// 转成实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        protected override WHMiddleware ToEntity( WHMiddlewarePo po ) {
            return po.ToEntity();
        }

        /// <summary>
        /// 转成持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        protected override WHMiddlewarePo ToPo( WHMiddleware entity ) {
            return entity.ToPo();
        }
    }
}