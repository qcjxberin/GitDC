using Util.Datas.Ef.Core;
using GitDC.Domain.Models;
using GitDC.Domain.Repositories;
using GitDC.Data.Pos.dbo;
using GitDC.Data.Stores.Abstractions.dbo;
using GitDC.Data.Pos.dbo.Extensions;

namespace GitDC.Data.Repositories.dbo {
    /// <summary>
    /// 用户名仓储
    /// </summary>
    public class DCUsersRepository : CompactRepositoryBase<DCUsers,DCUsersPo,long>, IDCUsersRepository {
        /// <summary>
        /// 初始化用户名仓储
        /// </summary>
        /// <param name="store">用户名存储器</param>
        public DCUsersRepository( IDCUsersPoStore store ) : base( store ) {
        }
        
        /// <summary>
        /// 转成实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        protected override DCUsers ToEntity( DCUsersPo po ) {
            return po.ToEntity();
        }

        /// <summary>
        /// 转成持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        protected override DCUsersPo ToPo( DCUsers entity ) {
            return entity.ToPo();
        }
    }
}