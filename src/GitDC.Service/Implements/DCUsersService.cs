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
using System.Threading.Tasks;
using Ding.Helpers;

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
            UnitOfWork = unitOfWork;
        }
        
        /// <summary>
        /// 用户名仓储
        /// </summary>
        public IDCUsersRepository DCUsersRepository { get; set; }

        /// <summary>
        /// 工作单元
        /// </summary>
        public IGitDCUnitOfWork UnitOfWork;

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DCUsers> CreateQuery( DCUsersQuery param ) {
            return new Query<DCUsers,long>( param );
        }

        /// <summary>
        /// 创建后操作
        /// </summary>
        /// <param name="entity">创建参数</param>
        /// <returns></returns>
        protected override async Task CreateAfterAsync(DCUsers entity)
        {
            await UnitOfWork.CommitAsync();  //适用于自增字段获取自增之后的Id
        }

        /// <summary>
        /// 根据用户名获取用户数据
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public async Task<DCUsers> GetUserByName(string name)
        {
            return await DCUsersRepository.SingleAsync(x => x.Name == name);
        }

        /// <summary>
        /// 创建用户密码
        /// </summary>
        /// <param name="password">真实密码</param>
        /// <param name="salt">散列盐值</param>
        /// <returns></returns>
        public async Task<string> CreateUserPassword(string password, string salt)
        {
            return await Task.Run(() => SecureHelper.MD5(password + salt));
        }
    }
}