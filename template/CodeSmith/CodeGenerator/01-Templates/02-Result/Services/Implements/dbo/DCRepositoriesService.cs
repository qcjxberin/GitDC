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
    /// 仓库表服务
    /// </summary>
    public class DCRepositoriesService : CrudServiceBase<DCRepositories, DCRepositoriesDto, DCRepositoriesQuery>, IDCRepositoriesService {
        /// <summary>
        /// 初始化仓库表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="dCRepositoriesRepository">仓库表仓储</param>
        public DCRepositoriesService( IGitDCUnitOfWork unitOfWork, IDCRepositoriesRepository dCRepositoriesRepository )
            : base( unitOfWork, dCRepositoriesRepository ) {
            DCRepositoriesRepository = dCRepositoriesRepository;
        }
        
        /// <summary>
        /// 仓库表仓储
        /// </summary>
        public IDCRepositoriesRepository DCRepositoriesRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DCRepositories> CreateQuery( DCRepositoriesQuery param ) {
            return new Query<DCRepositories>( param );
        }
    }
}