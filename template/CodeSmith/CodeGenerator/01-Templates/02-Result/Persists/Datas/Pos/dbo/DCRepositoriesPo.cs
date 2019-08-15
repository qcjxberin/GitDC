using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 仓库表持久化对象
    /// </summary>
    public class DCRepositoriesPo : PersistentObjectBase<Guid>,IDelete{
        /// <summary>
        /// 默认分支
        /// </summary>  
        public string DefaultBranch { get; set; }
        /// <summary>
        /// 描述
        /// </summary>  
        public string Description { get; set; }
        /// <summary>
        /// 是否镜像
        /// </summary>  
        public bool? IsMirror { get; set; }
        /// <summary>
        /// 是否私人
        /// </summary>  
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>  
        public string Name { get; set; }
        /// <summary>
        /// 问题数量
        /// </summary>  
        public int? NumIssues { get; set; }
        /// <summary>
        /// 未关闭的问题数量
        /// </summary>  
        public int? NumOpenIssues { get; set; }
        /// <summary>
        /// 未关闭的合并请求数量
        /// </summary>  
        public int? NumOpenPulls { get; set; }
        /// <summary>
        /// 合并请求数量
        /// </summary>  
        public int? NumPulls { get; set; }
        /// <summary>
        /// 大小
        /// </summary>  
        public decimal? Size { get; set; }
        /// <summary>
        /// 归属用户
        /// </summary>  
        public long? UserID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>  
        public string UserName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>  
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>  
        public DateTime? LastModifiTime { get; set; }
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>  
        public bool IsDeleted { get; set; }
    }
}