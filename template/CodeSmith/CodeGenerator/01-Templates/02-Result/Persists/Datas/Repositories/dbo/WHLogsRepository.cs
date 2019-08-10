using Util.Datas.Ef.Core;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;
using GitDC.Data.Pos.dbo.Extensions;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 网络勾子推送内容日志仓储
    /// </summary>
    public class WHLogsRepository : CompactRepositoryBase<WHLogs,WHLogsPo>, IWHLogsRepository {
        /// <summary>
        /// 初始化网络勾子推送内容日志仓储
        /// </summary>
        /// <param name="store">网络勾子推送内容日志存储器</param>
        public WHLogsRepository( IWHLogsPoStore store ) : base( store ) {
        }
        
        /// <summary>
        /// 转成实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        protected override WHLogs ToEntity( WHLogsPo po ) {
            return po.ToEntity();
        }

        /// <summary>
        /// 转成持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        protected override WHLogsPo ToPo( WHLogs entity ) {
            return entity.ToPo();
        }
    }
}