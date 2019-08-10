using Ding.Datas.Stores;
using GitDC.Data.Pos.dbo;

namespace GitDC.Data.Stores.Abstractions.dbo  {
    /// <summary>
    /// 网络勾子推送内容日志存储器
    /// </summary>
    public interface IWHLogsPoStore : IStore<WHLogsPo> {
    }
}