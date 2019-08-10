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
    public class SshKeysService : CrudServiceBase<SshKeysPo, SshKeysDto, SshKeysQuery,long>, ISshKeysService {
        /// <summary>
        /// 初始化服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="sshKeysStore">存储器</param>
        public SshKeysService( IGitDCUnitOfWork unitOfWork, ISshKeysPoStore sshKeysStore )
            : base( unitOfWork, sshKeysStore ) {
            SshKeysStore = sshKeysStore;
        }
        
        /// <summary>
        /// 存储器
        /// </summary>
        public ISshKeysPoStore SshKeysStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<SshKeysPo> CreateQuery( SshKeysQuery param ) {
            return new Query<SshKeysPo,long>( param );
        }
    }
}