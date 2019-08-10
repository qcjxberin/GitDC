using Ding.Xml;
using System.ComponentModel;

namespace GitDC.Common
{
    /// <summary>
    /// 站点参数设置
    /// </summary>
    [DisplayName("站点参数设置")]
    [XmlConfigFile("Config/Site.config", 15000)]
    public class SiteSetting : XmlConfig<SiteSetting>
    {
        /// <summary>网站域名</summary>
        [Description("网站域名")]
        public string Url { get; set; } = "http://localhost:9090";

        /// <summary>数据库类型：MSSQL2005, MSSQL2012, MySQL, PostgreSQL, Oracle, Sqlite</summary>
        [Description("数据库类型：MSSQL2005, MSSQL2012, MySQL, PostgreSQL, Oracle, Sqlite")]
        public string DataProvider { get; set; } = "MySQL";

        /// <summary>
        /// Email配置
        /// </summary>
        [Description("Email配置")]
        public Email Email { get; set; } = new Email();

        /// <summary>
        /// 短信配置
        /// </summary>
        [Description("短信配置")]
        public Sms Sms { get; set; } = new Sms();
    }

    /// <summary>
    /// Email配置
    /// </summary>
    [DisplayName("Email配置")]
    public class Email
    {
        /// <summary>
        /// 服务器地址
        /// </summary>
        public string Host { get; set; } = "";
        /// <summary>
        /// 服务器端口
        /// </summary>
        public int Port { get; set; } = 465;
        /// <summary>
        /// 邮箱账号
        /// </summary>
        public string UserName { get; set; } = "";
        /// <summary>
        /// 邮箱密码
        /// </summary>
        public string Password { get; set; } = "";
        /// <summary>
        /// 发送邮箱
        /// </summary>
        public string From { get; set; } = "";
        /// <summary>
        /// 发送邮箱的昵称
        /// </summary>
        public string FromName { get; set; } = "";
        /// <summary>
        /// 是否启用SSL,0为否,1为是
        /// </summary>
        public bool IsSSL { get; set; } = true;
    }

    /// <summary>
    /// 短信配置
    /// </summary>
    [DisplayName("短信配置")]
    public class Sms
    {
        /// <summary>
        /// 短信服务器地址
        /// </summary>
        public string Url { get; set; } = "";
        /// <summary>
        /// 短信AccessKeyId
        /// </summary>
        public string AccessKeyId { get; set; } = "";
        /// <summary>
        /// 短信AccessKeySecret
        /// </summary>
        public string AccessKeySecret { get; set; } = "";
        /// <summary>
        /// 短信签名
        /// </summary>
        public string passKey { get; set; } = "";

        /// <summary>
        /// 注册欢迎短信模板
        /// </summary>
        public string RegisterWelComBody { get; set; } = "";

        /// <summary>
        /// 烽火短信账号
        /// </summary>
        public string FengHuoName { get; set; } = "";

        /// <summary>
        /// 烽火短信密码
        /// </summary>
        public string FengHuoPassWord { get; set; } = "";
    }
}
