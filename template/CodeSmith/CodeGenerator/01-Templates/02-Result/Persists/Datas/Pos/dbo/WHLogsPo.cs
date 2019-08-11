using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 网络勾子推送内容日志持久化对象
    /// </summary>
    public class WHLogsPo : PersistentObjectBase<Guid>,IDelete{
        /// <summary>
        /// 是为中转，否为非中转
        /// </summary>  
        public bool WHTypes { get; set; }
        /// <summary>
        /// 请求头部
        /// </summary>  
        public string RequestTop { get; set; }
        /// <summary>
        /// 推送内容
        /// </summary>  
        public string Content { get; set; }
        /// <summary>
        /// 响应头部
        /// </summary>  
        public string ResponseTop { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>  
        public string ResponseContent { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>  
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>  
        public bool IsDeleted { get; set; }
    }
}