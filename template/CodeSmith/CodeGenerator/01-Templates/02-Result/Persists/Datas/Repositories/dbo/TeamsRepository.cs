using Util.Datas.Ef.Core;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;
using GitDC.Data.Pos.dbo.Extensions;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 仓储
    /// </summary>
    public class TeamsRepository : CompactRepositoryBase<Teams,TeamsPo,long>, ITeamsRepository {
        /// <summary>
        /// 初始化仓储
        /// </summary>
        /// <param name="store">存储器</param>
        public TeamsRepository( ITeamsPoStore store ) : base( store ) {
        }
        
        /// <summary>
        /// 转成实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        protected override Teams ToEntity( TeamsPo po ) {
            return po.ToEntity();
        }

        /// <summary>
        /// 转成持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        protected override TeamsPo ToPo( Teams entity ) {
            return entity.ToPo();
        }
    }
}