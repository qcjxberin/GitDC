using System;
using System.ComponentModel.DataAnnotations;
using Ding;
using Ding.Datas.Queries;

namespace GitDC.Service.Queries.dbo {
    /// <summary>
    /// 用户名查询参数
    /// </summary>
    public class UsersQuery : QueryParameter {
        /// <summary>
        /// 编号
        /// </summary>
        [Display( Name = "编号" )]
        public long? Id { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        [Display( Name = "用户名" )]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        
        private string _nickName = string.Empty;
        /// <summary>
        /// 昵称
        /// </summary>
        [Display( Name = "昵称" )]
        public string NickName {
            get => _nickName == null ? string.Empty : _nickName.Trim();
            set => _nickName = value;
        }
        
        private string _email = string.Empty;
        /// <summary>
        /// 邮箱
        /// </summary>
        [Display( Name = "邮箱" )]
        public string Email {
            get => _email == null ? string.Empty : _email.Trim();
            set => _email = value;
        }
        /// <summary>
        /// 密码版本
        /// </summary>
        [Display( Name = "密码版本" )]
        public short? PasswordVersion { get; set; }
        
        private string _password = string.Empty;
        /// <summary>
        /// 密码
        /// </summary>
        [Display( Name = "密码" )]
        public string Password {
            get => _password == null ? string.Empty : _password.Trim();
            set => _password = value;
        }
        
        private string _description = string.Empty;
        /// <summary>
        /// 描述
        /// </summary>
        [Display( Name = "描述" )]
        public string Description {
            get => _description == null ? string.Empty : _description.Trim();
            set => _description = value;
        }
        /// <summary>
        /// 是否系统管理员
        /// </summary>
        [Display( Name = "是否系统管理员" )]
        public bool? IsSystemAdministrator { get; set; }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }
        /// <summary>
        /// 创建人编号
        /// </summary>
        [Display( Name = "创建人编号" )]
        public int? CreatId { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModifiTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModifiTime { get; set; }
        /// <summary>
        /// 最后修改人编号
        /// </summary>
        [Display( Name = "最后修改人编号" )]
        public int? LastModifiId { get; set; }
    }
}