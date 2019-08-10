using System;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Datas.Persistence;

namespace GitDC.Data.Pos.dbo{
    /// <summary>
    /// 用户名持久化对象
    /// </summary>
    public class DCUsersPo : PersistentObjectBase<long>,IDelete{
        /// <summary>
        /// 用户名
        /// </summary>  
        public string Name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>  
        public string NickName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>  
        public string Email { get; set; }
        /// <summary>
        /// 密码版本
        /// </summary>  
        public short? PasswordVersion { get; set; }
        /// <summary>
        /// 密码
        /// </summary>  
        public string Password { get; set; }
        /// <summary>
        /// 盐值
        /// </summary>  
        public string Salt { get; set; }
        /// <summary>
        /// 描述
        /// </summary>  
        public string Description { get; set; }
        /// <summary>
        /// 是否系统管理员
        /// </summary>  
        public bool? IsSystemAdministrator { get; set; }
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