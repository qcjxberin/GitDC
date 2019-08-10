using Ding.Webs.Controllers;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using GitDC.Service.Abstractions.dbo;

namespace GitDC.Apis.dbo {
    /// <summary>
    /// 用户名控制器
    /// </summary>
    public class DCUsersController : CrudControllerBase<DCUsersDto, DCUsersQuery> {
        /// <summary>
        /// 初始化用户名控制器
        /// </summary>
        /// <param name="service">用户名服务</param>
        public DCUsersController( IDCUsersService service ) : base( service ) {
            DCUsersService = service;
        }

        /// <summary>
        /// 用户名服务
        /// </summary>
        public IDCUsersService DCUsersService { get; }
    }
}