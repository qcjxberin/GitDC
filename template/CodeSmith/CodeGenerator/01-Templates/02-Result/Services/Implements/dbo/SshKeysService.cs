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
    public class SshKeysService : CrudServiceBase<SshKeys, SshKeysDto, SshKeysQuery,long>, ISshKeysService {
        /// <summary>
        /// 初始化服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="sshKeysRepository">仓储</param>
        public SshKeysService( IGitDCUnitOfWork unitOfWork, ISshKeysRepository sshKeysRepository )
            : base( unitOfWork, sshKeysRepository ) {
            SshKeysRepository = sshKeysRepository;
        }
        
        /// <summary>
        /// 仓储
        /// </summary>
        public ISshKeysRepository SshKeysRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<SshKeys> CreateQuery( SshKeysQuery param ) {
            return new Query<SshKeys,long>( param );
        }
    }
}