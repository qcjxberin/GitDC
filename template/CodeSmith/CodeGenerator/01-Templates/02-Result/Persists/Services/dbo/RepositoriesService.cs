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
    /// 仓库表服务
    /// </summary>
    public class RepositoriesService : CrudServiceBase<RepositoriesPo, RepositoriesDto, RepositoriesQuery>, IRepositoriesService {
        /// <summary>
        /// 初始化仓库表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="repositoriesStore">仓库表存储器</param>
        public RepositoriesService( IGitDCUnitOfWork unitOfWork, IRepositoriesPoStore repositoriesStore )
            : base( unitOfWork, repositoriesStore ) {
            RepositoriesStore = repositoriesStore;
        }
        
        /// <summary>
        /// 仓库表存储器
        /// </summary>
        public IRepositoriesPoStore RepositoriesStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<RepositoriesPo> CreateQuery( RepositoriesQuery param ) {
            return new Query<RepositoriesPo>( param );
        }
    }
}