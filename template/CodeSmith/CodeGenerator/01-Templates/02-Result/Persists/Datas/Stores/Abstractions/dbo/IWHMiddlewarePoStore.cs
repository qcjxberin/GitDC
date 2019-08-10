using Ding.Datas.Stores;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Stores.Abstractions.dbo  {
    /// <summary>
    /// 网络勾子中转表存储器
    /// </summary>
    public interface IWHMiddlewarePoStore : IStore<WHMiddlewarePo> {
    }
}