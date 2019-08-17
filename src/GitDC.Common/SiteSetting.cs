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
        public string Url { get; set; } = "http://localhost:7070";

        /// <summary>数据库类型：MSSQL2005, MSSQL2012, MySQL, PostgreSQL, Oracle, Sqlite</summary>
        [Description("数据库类型：MSSQL2005, MSSQL2012, MySQL, PostgreSQL, Oracle, Sqlite")]
        public string DataProvider { get; set; } = "MySQL";

        /// <summary>
        /// 验证码加密密钥
        /// </summary>
        [Description("验证码加密密钥")]
        public string CaptchaSecretKey { get; set; } = "HAOCODING";

        /// <summary>
        /// Git配置
        /// </summary>
        [Description("Git配置")]
        public GitConfig GitConfig { get; set; } = new GitConfig();

        /// <summary>
        /// 网站配置
        /// </summary>
        [Description("网站配置")]
        public WebConfig WebConfig { get; set; } = new WebConfig();

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

        /// <summary>
        /// Jwt配置项
        /// </summary>
        [Description("Jwt配置项")]
        public JwtAuthConfigModel JWT { get; set; } = new JwtAuthConfigModel();
    }

    /// <summary>
    /// 网站配置
    /// </summary>
    [DisplayName("网站配置")]
    public class WebConfig
    {
        /// <summary>
        /// 管理后台目录
        /// </summary>
        [Description("管理后台目录")]
        public string AdminPath { get; set; } = "HaoCodingAdmin";

        /// <summary>
        /// Redis配置
        /// </summary>
        [Description("Redis配置")]
        public string Redis_Configuration { get; set; } = "localhost:6379"; //不包含密码localhost:6379或者包含密码及其他配置localhost:6379,password=senparc,connectTimeout=1000,connectRetry=2,syncTimeout=10000,defaultDatabase=3

        /// <summary>
        /// 随机库
        /// </summary>
        [Description("随机库")]
        public string RandomLibrary { get; set; } = "123456789abcdefghjkmnpqrstuvwxy";
    }

    /// <summary>
    /// Git配置
    /// </summary>
    [DisplayName("Git配置")]
    public class GitConfig
    {
        /// <summary>
        /// 仓库地址
        /// </summary>
        [Description("仓库地址")]
        public string RepositoryPath { get; set; } = "";

        /// <summary>
        /// Git.exe路径
        /// </summary>
        [Description("Git.exe路径")]
        public string GitCorePath { get; set; } = "";

        /// <summary>
        /// Cache路径
        /// </summary>
        [Description("Cache路径")]
        public string CachePath { get; set; } = "";
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

    /// <summary>
    /// Jwt配置项
    /// </summary>
    [DisplayName("Jwt配置项")]
    public class JwtAuthConfigModel
    {
        /// <summary>
        /// Jwt密钥
        /// </summary>
        public string JWTSecretKey { get; set; } = "lyDqoSIQmyFcUhmmN4eBRGWWzm1ELC7owHVtStOu1YD7wYz";

        /// <summary>
        /// Web过期时间
        /// </summary>
        public double WebExp { get; set; } = 800;

        /// <summary>
        /// App过期时间
        /// </summary>
        public double AppExp { get; set; } = 800;

        /// <summary>
        /// 微信过期时间
        /// </summary>
        public double WxExp { get; set; } = 800;

        /// <summary>
        /// 其他过期时间
        /// </summary>
        public double OtherExp { get; set; } = 800;

        /// <summary>
        /// 发行人
        /// </summary>
        public string Issuer { get; set; } = "Berin";

        /// <summary>
        /// 接收人
        /// </summary>
        public string Audience { get; set; } = "GITDC";
    }
}
