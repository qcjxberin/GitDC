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
    public class DCUsersService : CrudServiceBase<DCUsersPo, DCUsersDto, DCUsersQuery,long>, IDCUsersService {
        /// <summary>
        /// 初始化用户名服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="dCUsersStore">用户名存储器</param>
        public DCUsersService( IGitDCUnitOfWork unitOfWork, IDCUsersPoStore dCUsersStore )
            : base( unitOfWork, dCUsersStore ) {
            DCUsersStore = dCUsersStore;
        }
        
        /// <summary>
        /// 用户名存储器
        /// </summary>
        public IDCUsersPoStore DCUsersStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DCUsersPo> CreateQuery( DCUsersQuery param ) {
            return new Query<DCUsersPo,long>( param );
        }
    }
}