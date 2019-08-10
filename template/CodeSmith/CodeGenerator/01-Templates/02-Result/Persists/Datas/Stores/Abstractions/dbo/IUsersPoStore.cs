using Ding.Datas.Stores;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Stores.Abstractions.dbo  {
    /// <summary>
    /// 用户名存储器
    /// </summary>
    public interface IUsersPoStore : IStore<UsersPo,long> {
    }
}