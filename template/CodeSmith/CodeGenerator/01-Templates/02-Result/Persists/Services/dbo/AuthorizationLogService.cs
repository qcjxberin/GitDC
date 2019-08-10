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
    /// 服务
    /// </summary>
    public class AuthorizationLogService : CrudServiceBase<AuthorizationLogPo, AuthorizationLogDto, AuthorizationLogQuery>, IAuthorizationLogService {
        /// <summary>
        /// 初始化服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="authorizationLogStore">存储器</param>
        public AuthorizationLogService( IGitDCUnitOfWork unitOfWork, IAuthorizationLogPoStore authorizationLogStore )
            : base( unitOfWork, authorizationLogStore ) {
            AuthorizationLogStore = authorizationLogStore;
        }
        
        /// <summary>
        /// 存储器
        /// </summary>
        public IAuthorizationLogPoStore AuthorizationLogStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<AuthorizationLogPo> CreateQuery( AuthorizationLogQuery param ) {
            return new Query<AuthorizationLogPo>( param );
        }
    }
}