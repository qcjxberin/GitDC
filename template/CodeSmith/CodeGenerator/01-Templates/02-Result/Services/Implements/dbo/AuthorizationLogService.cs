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
    /// 服务
    /// </summary>
    public class AuthorizationLogService : CrudServiceBase<AuthorizationLog, AuthorizationLogDto, AuthorizationLogQuery>, IAuthorizationLogService {
        /// <summary>
        /// 初始化服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="authorizationLogRepository">仓储</param>
        public AuthorizationLogService( IGitDCUnitOfWork unitOfWork, IAuthorizationLogRepository authorizationLogRepository )
            : base( unitOfWork, authorizationLogRepository ) {
            AuthorizationLogRepository = authorizationLogRepository;
        }
        
        /// <summary>
        /// 仓储
        /// </summary>
        public IAuthorizationLogRepository AuthorizationLogRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<AuthorizationLog> CreateQuery( AuthorizationLogQuery param ) {
            return new Query<AuthorizationLog>( param );
        }
    }
}