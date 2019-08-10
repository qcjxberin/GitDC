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
    /// 用户名服务
    /// </summary>
    public class DCUsersService : CrudServiceBase<DCUsers, DCUsersDto, DCUsersQuery,long>, IDCUsersService {
        /// <summary>
        /// 初始化用户名服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="dCUsersRepository">用户名仓储</param>
        public DCUsersService( IGitDCUnitOfWork unitOfWork, IDCUsersRepository dCUsersRepository )
            : base( unitOfWork, dCUsersRepository ) {
            DCUsersRepository = dCUsersRepository;
        }
        
        /// <summary>
        /// 用户名仓储
        /// </summary>
        public IDCUsersRepository DCUsersRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DCUsers> CreateQuery( DCUsersQuery param ) {
            return new Query<DCUsers,long>( param );
        }
    }
}