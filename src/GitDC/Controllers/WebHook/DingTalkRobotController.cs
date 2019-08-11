using Ding.Helpers;
using Ding.Log;
using Ding.Webs;
using Ding.Webs.Controllers;
using GitDC.Common;
using GitDC.Domain.Models;
using GitDC.Service.Abstractions.dbo;
using GitDC.Service.Dtos.dbo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using AngleSharp.Html.Parser;
using System.Linq;
using Ding.Collections;

namespace GitDC.Controllers
{
    /// <summary>
    /// 与机器人交互
    /// </summary>
    public class RobotController : WebControllerBase
    {
        private string WebHook_Token { get; set; } = "";

        #region 多种消息类型

        /// <summary>
        /// 调用钉钉机器人发送文本内容
        /// </summary>
        /// <param name="Access_Token">来源于</param>
        /// <returns></returns>
        public async Task<IActionResult> Send([FromQuery]string Access_Token)
        {
            var WHMiddlewareService = Ioc.Create<IWHMiddlewareService>();
            var WHLogsService = Ioc.Create<IWHLogsService>();

            var model = await WHMiddlewareService.GetByToken(Access_Token);

            if (model == null)
            {
                return Fail("指定的数据不存在");
            }

            WebHook_Token = model.PushUrl;
            if (!model.PushUrl.Contains("access_token") && !model.PushToken.IsNullOrEmpty())
            {
                WebHook_Token += $"?access_token={model.PushToken}";
            }

            var dic = new Dictionary<string, string>();
            foreach(var row in HttpContext.Request.Headers)
            {
                dic.Add(row.Key, row.Value);
            }

            var content = await Web.GetBodyAsync();

            if (!content.IsNullOrEmpty())
            {
                var modelwhlogs = new WHLogsDto();
                modelwhlogs.WHTypes = true;
                modelwhlogs.RequestTop = dic.ToJson();
                modelwhlogs.Content = content;
                modelwhlogs.CreationTime = DateTime.Now;
                await WHLogsService.CreateAsync(modelwhlogs);
            }

            switch (model.Source)
            {
                case 1:
                    {
                        //消息类型
                        var msgtype = MsgTypeEnum.actionCard.ToString();

                        var modelContent = JObject.Parse(content);
                        var repository = modelContent["repository"];

                        var repositorychild = repository.Children().OfType<JProperty>()
                            .ToDictionary(p => p.Name, p => p.Value);

                        XTrace.UseConsole();
                        XTrace.WriteLine(repositorychild.ToJson());

                        var parser = new HtmlParser();
                        var document = await parser.ParseDocumentAsync(repositorychild["html_url"].ToString());
                        var html_url = document.QuerySelector("a").GetAttribute("href");

                        var build = Pool.StringBuilder.Get();

                        if (dic.ContainsKey("X-Coding-Event"))
                        {
                            if (dic["X-Coding-Event"] == "push")
                            {
                                build.Append("# Repo Push Event\n-");
                            }
                        }

                        build.Append("# Repo Push Event\n- Repo: **[test](https://try.gogs.io/qcjxberin/test)**\n- Ref: **[master](https://try.gogs.io/qcjxberin/test/src/master)**\n- Pusher: **qcjxberin**\n## Total 1 commits(s)\n\u003e 0. [efc05d0](https://try.gogs.io/qcjxberin/test/commit/efc05d0399da7a7350672655b2d7d776b743ca92) qcjxberin - Initial commit\n @18307555593");

                        //actionCard内容
                        var actionCard = new ActionCard
                        {
                            

                        Text = build.Put(true),
                            Title = "极思灵创WebHook中转器-腾讯开发者平台",
                            HideAvatar = "0",
                            BtnOrientation = "0",
                            SingleTitle = "查看详情",
                            SingleURL = html_url
                        };

                        //指定目标人群
                        var at = new At()
                        {
                            AtMobiles = new List<string>() { "18307555593" },
                            IsAtAll = false
                        };

                        var response = await SendDingTalkMessage(new { msgtype, actionCard, at });

                        return Ok(response);
                    }

                case 2:

                case 3:

                default:
                    {
                        //消息类型
                        var msgtype = MsgTypeEnum.markdown.ToString();

                        //markdown内容
                        var markdown = new MarkDown
                        {
                            Text = "#### 长沙天气 @18307555593\n" +
                                         "> 8度，西北风3级，空气优16，相对湿度100%\n\n" +
                                         "> ![screenshot](https://gw.alipayobjects.com/zos/skylark-tools/public/files/84111bbeba74743d2771ed4f062d1f25.png)\n" +
                                         "> ###### 15点03分发布 [天气](https://www.seniverse.com/) \n",
                            Title = "长沙天气"
                        };

                        //指定目标人群
                        var at = new At()
                        {
                            AtMobiles = new List<string>() { "18307555593" },
                            IsAtAll = false
                        };

                        var response = await SendDingTalkMessage(new { msgtype, markdown, at });

                        return Ok(response);
                    }
            }
        }

        /// <summary>
        /// 调用钉钉机器人发送文本内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> TextContent()
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
        /// <param name="value"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> SendDingTalkMessage(object value)
        {
            var sendMessage = JsonConvert.SerializeObject(value);

            var request = new HttpRequestMessage(HttpMethod.Post, WebHook_Token)
            {
                //钉钉文档需指定UTF8编码
                Content = new StringContent(sendMessage, Encoding.UTF8, "application/json")
            };

            var HttpClientFactory = Ioc.Create<IHttpClientFactory>();

            var client = HttpClientFactory.CreateClient();
            var response = await client.SendAsync(request);

            return response;
        }
    }
}
