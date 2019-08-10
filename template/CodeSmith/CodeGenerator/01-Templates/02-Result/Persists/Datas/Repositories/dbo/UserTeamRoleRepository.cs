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
    public class UserTeamRoleRepository : CompactRepositoryBase<UserTeamRole,UserTeamRolePo>, IUserTeamRoleRepository {
        /// <summary>
        /// 初始化仓储
        /// </summary>
        /// <param name="store">存储器</param>
        public UserTeamRoleRepository( IUserTeamRolePoStore store ) : base( store ) {
        }
        
        /// <summary>
        /// 转成实体
        /// </summary>
        /// <param name="po">持久化对象</param>
        protected override UserTeamRole ToEntity( UserTeamRolePo po ) {
            return po.ToEntity();
        }

        /// <summary>
        /// 转成持久化对象
        /// </summary>
        /// <param name="entity">实体</param>
        protected override UserTeamRolePo ToPo( UserTeamRole entity ) {
            return entity.ToPo();
        }
    }
}