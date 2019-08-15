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
    public class DCRepositoriesService : CrudServiceBase<DCRepositoriesPo, DCRepositoriesDto, DCRepositoriesQuery>, IDCRepositoriesService {
        /// <summary>
        /// 初始化仓库表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="dCRepositoriesStore">仓库表存储器</param>
        public DCRepositoriesService( IGitDCUnitOfWork unitOfWork, IDCRepositoriesPoStore dCRepositoriesStore )
            : base( unitOfWork, dCRepositoriesStore ) {
            DCRepositoriesStore = dCRepositoriesStore;
        }
        
        /// <summary>
        /// 仓库表存储器
        /// </summary>
        public IDCRepositoriesPoStore DCRepositoriesStore { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DCRepositoriesPo> CreateQuery( DCRepositoriesQuery param ) {
            return new Query<DCRepositoriesPo>( param );
        }
    }
}