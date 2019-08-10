using Newtonsoft.Json;
using System.Collections.Generic;

namespace GitDC.Common
{
    /// <summary>
    /// 文本类型
    /// </summary>
    public class Text
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }

    /// <summary>
    /// Link类型
    /// </summary>
    public class Link
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { set; get; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { set; get; }

        /// <summary>
        /// 图片URL
        /// </summary>
        [JsonProperty(PropertyName = "picUrl")]
        public string PicUrl { set; get; }

        /// <summary>
        /// 点击消息跳转的URL
        /// </summary>
        [JsonProperty(PropertyName = "messageUrl")]
        public string MessageUrl { set; get; }
    }

    /// <summary>
    /// MarkDown类型
    /// </summary>
    public class MarkDown
    {
        /// <summary>
        /// 首屏会话透出的展示内容
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { set; get; }

        /// <summary>
        /// markdown格式的消息
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { set; get; }
    }

    /// <summary>
    /// ActionCard类型
    /// </summary>
    public class ActionCard
    {
        /// <summary>
        /// 首屏会话透出的展示内容
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { set; get; }

        /// <summary>
        /// markdown格式的消息
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { set; get; }

        /// <summary>
        /// 单个按钮的方案。(设置此项和singleURL后btns无效)
        /// </summary>
        [JsonProperty(PropertyName = "singleTitle")]
        public string SingleTitle { set; get; }

        /// <summary>
        /// 点击singleTitle按钮触发的URL
        /// </summary>
        [JsonProperty(PropertyName = "singleURL")]
        public string SingleURL { set; get; }

        /// <summary>
        /// 首屏会话透出的展示内容
        /// </summary>
        [JsonProperty(PropertyName = "btnOrientation")]
        public string BtnOrientation { set; get; }

        /// <summary>
        /// 0-正常发消息者头像，1-隐藏发消息者头像
        /// </summary>
        [JsonProperty(PropertyName = "hideAvatar")]
        public string HideAvatar { set; get; }

        /// <summary>
        /// 按钮的信息：title-按钮方案，actionURL-点击按钮触发的URL
        /// </summary>
        [JsonProperty(PropertyName = "btns")]
        public List<BtnInfo> Btns { set; get; }
    }

    /// <summary>
    /// FeedCard类型
    /// </summary>
    public class FeedCard
    {
        [JsonProperty(PropertyName = "links")]
        public List<Link> Links { get; set; }
    }

    /// <summary>
    /// @指定人
    /// </summary>
    public class At
    {
        /// <summary>
        /// @的联系人
        /// </summary>
        [JsonProperty(PropertyName = "atMobiles")]
        public List<string> AtMobiles { set; get; }

        /// <summary>
        /// 是否@所有人
        /// </summary>
        [JsonProperty(PropertyName = "isAtAll")]
        public bool IsAtAll { set; get; }
    }

    /// <summary>
    /// 按钮信息
    /// </summary>
    public class BtnInfo
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "actionUrl")]
        public string ActionUrl { get; set; }
    }

    /// <summary>
    /// 钉钉群机器人消息类型枚举
    /// </summary>
    /// <remarks>此处要注意小写</remarks>
    public enum MsgTypeEnum
    {
        text,
        link,
        markdown,
        actionCard,
        feedCard
    }
}
