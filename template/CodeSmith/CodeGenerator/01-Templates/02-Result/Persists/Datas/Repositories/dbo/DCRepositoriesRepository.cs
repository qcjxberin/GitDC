using Util.Datas.Ef.Core;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;
using GitDC.Data.Pos.dbo.Extensions;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 仓库表仓储
    /// </summary>
    public class DCRepositoriesRepository : CompactRepositoryBase<DCRepositories,DCRepositoriesPo>, IDCRepositoriesRepository {
        /// <summary>
        /// 初始化仓库表仓储
        /// </summary>
        /// <param name="store">仓库表存储器</param>
        public DCRepositoriesRepository( IDCRepositoriesPoStore store ) : base( store ) {
        }
        
        /// <summary>
        /// 转成实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        protected override DCRepositories ToEntity( DCRepositoriesPo po ) {
            return po.ToEntity();
        }

        /// <summary>
        /// 转成持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        protected override DCRepositoriesPo ToPo( DCRepositories entity ) {
            return entity.ToPo();
        }
    }
}