using Ding.Webs.Controllers;
using GitDC.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GitDC.Controllers
{
    /// <summary>
    /// 与钉钉机器人交互
    /// </summary>
    public class DingTalkRobotController : WebControllerBase
    {
        private readonly string WebHook_Token = "https://oapi.dingtalk.com/robot/send?access_token=542ac7c0ee4546c36581eed3873270ecd86cc0c5f4654539ae88e38e6ef44239";

        private readonly IHttpClientFactory _httpClientFactory;

        public DingTalkRobotController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        #region 多种消息类型
        /// <summary>
        /// 调用钉钉机器人发送文本内容
        /// </summary>
        /// <param name="FromTypes">来源于</param>
        /// <returns></returns>
        [HttpPost("TextContent/{FromTypes}")]
        public async Task<ActionResult> TextContent(int FromTypes)
        {
            //消息类型
            var msgtype = MsgTypeEnum.text.ToString();

            //文本内容
            var text = new Text
            {
                Content = "测试钉钉机器人消息@18307555593"
            };

            //指定目标人群
            var at = new At()
            {
                AtMobiles = new List<string>() { "18307555593" },
                IsAtAll = false
            };

            var response = await SendDingTalkMessage(new { msgtype, text, at });

            return Ok(response);
        }

        /// <summary>
        /// 调用钉钉机器人发送Link内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> LinkContent()
        {
            //消息类型
            var msgtype = MsgTypeEnum.link.ToString();

            //link内容
            var link = new Link
            {
                Text = "这个即将发布的新版本，创始人陈航（花名“无招”）称它为“红树林”。而在此之前，每当面临重大升级，产品经理们都会取一个应景的代号，这一次，为什么是“红树林”？",
                Title = "时代在召唤",
                PicUrl = "",
                MessageUrl = "https://mp.weixin.qq.com/s?__biz=MzA4NjMwMTA2Ng==&mid=2650316842&idx=1&sn=60da3ea2b29f1dcc43a7c8e4a7c97a16&scene=2&srcid=09189AnRJEdIiWVaKltFzNTw&from=timeline&isappinstalled=0&key=&ascene=2&uin=&devicetype=android-23&version=26031933&nettype=WIFI"
            };

            var response = await SendDingTalkMessage(new { msgtype, link });

            return Ok(response);
        }

        /// <summary>
        /// 调用钉钉机器人发送MarkDown内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> MarkDownContent()
        {
            //消息类型
            var msgtype = MsgTypeEnum.markdown.ToString();

            //markdown内容
            var markdown = new MarkDown
            {
                Text = "#### 长沙天气 @15675120617\n" +
                             "> 8度，西北风3级，空气优16，相对湿度100%\n\n" +
                             "> ![screenshot](https://gw.alipayobjects.com/zos/skylark-tools/public/files/84111bbeba74743d2771ed4f062d1f25.png)\n" +
                             "> ###### 15点03分发布 [天气](https://www.seniverse.com/) \n",
                Title = "长沙天气"
            };

            //指定目标人群
            var at = new At()
            {
                AtMobiles = new List<string>() { "15675120617" },
                IsAtAll = false
            };

            var response = await SendDingTalkMessage(new { msgtype, markdown, at });

            return Ok(response);
        }

        /// <summary>
        /// 调用钉钉机器人发送整体跳转ActionCard内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> WholeActionCardContent()
        {
            //消息类型
            var msgtype = MsgTypeEnum.actionCard.ToString();

            //actionCard内容
            var actionCard = new ActionCard
            {
                Text = "![screenshot](https://gw.alipayobjects.com/zos/skylark-tools/public/files/84111bbeba74743d2771ed4f062d1f25.png) " +
                        "### 乔布斯 20 年前想打造的苹果咖啡厅 " +
                        "Apple Store 的设计正从原来满满的科技感走向生活化，而其生活化的走向其实可以追溯到 20 年前苹果一个建立咖啡馆的计划",
                Title = "乔布斯 20 年前想打造一间苹果咖啡厅，而它正是 Apple Store 的前身",
                HideAvatar = "0",
                BtnOrientation = "0",
                SingleTitle = "阅读全文",
                SingleURL = "https://www.dingtalk.com/"
            };

            var response = await SendDingTalkMessage(new { msgtype, actionCard });

            return Ok(response);
        }

        /// <summary>
        /// 调用钉钉机器人发送独立跳转ActionCard内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> PartActionCardContent()
        {
            //消息类型
            var msgtype = MsgTypeEnum.actionCard.ToString();

            //actionCard内容
            var actionCard = new ActionCard
            {
                Text = "![screenshot](https://gw.alipayobjects.com/zos/skylark-tools/public/files/84111bbeba74743d2771ed4f062d1f25.png) " +
                        "### 乔布斯 20 年前想打造的苹果咖啡厅 " +
                        "Apple Store 的设计正从原来满满的科技感走向生活化，而其生活化的走向其实可以追溯到 20 年前苹果一个建立咖啡馆的计划",
                Title = "乔布斯 20 年前想打造一间苹果咖啡厅，而它正是 Apple Store 的前身",
                HideAvatar = "0",
                BtnOrientation = "0",
                Btns = new List<BtnInfo>()
                {
                    new BtnInfo(){
                        Title = "内容不错",
                        ActionUrl = "https://www.dingtalk.com/"
                    },
                    new BtnInfo(){
                        Title = "不感兴趣",
                        ActionUrl = "https://www.dingtalk.com/"
                    }
                }
            };

            var response = await SendDingTalkMessage(new { msgtype, actionCard });

            return Ok(response);
        }

        /// <summary>
        /// 调用钉钉机器人发送FeedCard内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> FeedCardContent()
        {
            //消息类型
            var msgtype = MsgTypeEnum.feedCard.ToString();

            //feedCard内容
            var feedCard = new FeedCard
            {
                Links = new List<Link>()
                {
                    new Link(){
                        Title = "时代的火车向前开",
                        MessageUrl="https://mp.weixin.qq.com/s?__biz=MzA4NjMwMTA2Ng==&mid=2650316842&idx=1&sn=60da3ea2b29f1dcc43a7c8e4a7c97a16&scene=2&srcid=09189AnRJEdIiWVaKltFzNTw&from=timeline&isappinstalled=0&key=&ascene=2&uin=&devicetype=android-23&version=26031933&nettype=WIFI",
                        PicUrl="https://www.dingtalk.com/"
                    },
                    new Link(){
                        Title = "时代在召唤",
                        MessageUrl="https://mp.weixin.qq.com/s?__biz=MzA4NjMwMTA2Ng==&mid=2650316842&idx=1&sn=60da3ea2b29f1dcc43a7c8e4a7c97a16&scene=2&srcid=09189AnRJEdIiWVaKltFzNTw&from=timeline&isappinstalled=0&key=&ascene=2&uin=&devicetype=android-23&version=26031933&nettype=WIFI",
                        PicUrl="https://www.dingtalk.com/"
                    }
                }
            };

            var response = await SendDingTalkMessage(new { msgtype, feedCard });

            return Ok(response);
        }
        #endregion

        /// <summary>
        /// 执行发送消息
        /// </summary>
        /// <param name="sendMessage"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> SendDingTalkMessage(object value)
        {
            var sendMessage = JsonConvert.SerializeObject(value);

            var request = new HttpRequestMessage(HttpMethod.Post, WebHook_Token)
            {
                //钉钉文档需指定UTF8编码
                Content = new StringContent(sendMessage, Encoding.UTF8, "application/json")
            };

            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);

            return response;
        }
    }
}
