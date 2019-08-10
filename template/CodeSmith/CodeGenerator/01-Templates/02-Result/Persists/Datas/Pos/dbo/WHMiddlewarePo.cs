using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 网络勾子中转表持久化对象
    /// </summary>
    public class WHMiddlewarePo : PersistentObjectBase<Guid>,IDelete{
        /// <summary>
        /// 名称
        /// </summary>  
        public string Name { get; set; }
        /// <summary>
        /// 介绍
        /// </summary>  
        public string Summary { get; set; }
        /// <summary>
        /// 令牌
        /// </summary>  
        public string Token { get; set; }
        /// <summary>
        /// 1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea
        /// </summary>  
        public short Source { get; set; }
        /// <summary>
        /// 1.钉钉，2为企业微信
        /// </summary>  
        public short Push { get; set; }
        /// <summary>
        /// 推送Url
        /// </summary>  
        public string PushUrl { get; set; }
        /// <summary>
        /// 推送令牌
        /// </summary>  
        public string PushToken { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>  
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>  
        public int? CreatId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>  
        public DateTime? LastModifiTime { get; set; }
        /// <summary>
        /// 最后修改人编号
        /// </summary>  
        public int? LastModifiId { get; set; }
        /// <summary>
        /// 软删除，数据不会被物理删除
        /// </summary>  
        public bool IsDeleted { get; set; }
    }
}