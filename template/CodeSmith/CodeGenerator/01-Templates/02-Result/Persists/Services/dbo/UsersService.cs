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
    /// 用户名服务
    /// </summary>
    public class UsersService : CrudServiceBase<UsersPo, UsersDto, UsersQuery,long>, IUsersService {
        /// <summary>
        /// 初始化用户名服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="usersStore">用户名存储器</param>
        public UsersService( IGitDCUnitOfWork unitOfWork, IUsersPoStore usersStore )
            : base( unitOfWork, usersStore ) {
            UsersStore = usersStore;
        }
        
        /// <summary>
        /// 用户名存储器
        /// </summary>
        public IUsersPoStore UsersStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<UsersPo> CreateQuery( UsersQuery param ) {
            return new Query<UsersPo,long>( param );
        }
    }
}