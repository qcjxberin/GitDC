using Ding.Applications;
using GitDC.Domain.Models;
using GitDC.Service.Dtos.dbo;
using GitDC.Service.Queries.dbo;
using System.Threading.Tasks;

namespace GitDC.Service.Abstractions.dbo {
    /// <summary>
    /// 用户名服务
    /// </summary>
    public interface IDCUsersService : ICrudService<DCUsersDto, DCUsersQuery> {
        /// <summary>
        /// 根据用户名获取用户数据
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        Task<DCUsers> GetUserByName(string name);

        /// <summary>
        /// 创建用户密码
        /// </summary>
        /// <param name="password">真实密码</param>
        /// <param name="salt">散列盐值</param>
        /// <returns></returns>
        Task<string> CreateUserPassword(string password, string salt);
    }
}