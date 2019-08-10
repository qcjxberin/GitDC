using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace GitDC.SignalR
{
    /// <summary>
    /// 消息推送，即时通信服务（可供客户端调用的方法开头用小写）
    /// </summary>
    public class ChatsHub : Hub
    {
        public static ConcurrentDictionary<string, OnlineClient> OnlineClients { get; }

        private static readonly object SyncObj = new object();

        static ChatsHub()
        {
            OnlineClients = new ConcurrentDictionary<string, OnlineClient>();
        }

        #region 重载Hub方法
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <returns></returns>
        public override Task OnConnectedAsync()
        {
            //AddOnline();
            Clients.All.SendAsync("broadcastMessage", "丁丁丁丁丁丁丁丁", "欢迎连接");
            return base.OnConnectedAsync();
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public override Task OnDisconnectedAsync(Exception exception)
        {
            //RemoveOnline();
            return base.OnDisconnectedAsync(exception);
        }
        #endregion

        #region 客户端操作
        /// <summary>
        /// 添加在线用户
        /// </summary>
        public void AddOnline()
        {
            var clientId = Context.ConnectionId;

            var client = GetOnlineClient();

            lock (SyncObj)
            {
                OnlineClients[Context.ConnectionId] = client;
            }

            Groups.AddToGroupAsync(clientId, client.UserId);
        }

        /// <summary>
        /// 移除在线用户
        /// </summary>
        public void RemoveOnline()
        {
            var clientId = Context.ConnectionId;

            bool isRemoved;
            OnlineClient client;
            lock (SyncObj)
            {
                isRemoved = OnlineClients.TryRemove(Context.ConnectionId, out client);
            }

            Groups.RemoveFromGroupAsync(clientId, client.UserId);
        }

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.SendAsync("broadcastMessage", name, "返回信息" + message);
        }

        ///// <summary>
        ///// 给指定人发送消息
        ///// </summary>
        ///// <param name="toUserId">对方UserId</param>
        ///// <param name="msg">消息</param>
        ///// <param name="isSystem">是否系统消息0不是1是</param>
        //public async Task SendMessage(string toUserId, string msg, int isSystem)
        //{
        //    var client = OnlineClients.Where(x => x.Key == Context.ConnectionId).Select(x => x.Value).FirstOrDefault();
        //    if (client == null)
        //    {
        //        await Clients.Client(Context.ConnectionId).SendAsync("system", "您的状态有误!");
        //    }

        //    await Clients.Group(toUserId).SendAsync("revmsg", client.UserId, msg, DateTime.Now.ToFullString(), isSystem);
        //}

        ///// <summary>
        ///// 给指定人发送消息
        ///// </summary>
        ///// <param name="myUserId">我的UserId</param>
        ///// <param name="toUserId">对方UserId</param>
        ///// <param name="msg">消息</param>
        ///// <param name="isSystem">是否系统消息0不是1是</param>
        //public async Task SendMessage(string myUserId, string toUserId, string msg, int isSystem)
        //{
        //    await Clients.Group(toUserId).SendAsync("revmsg", myUserId, msg, DateTime.Now.ToFullString(), isSystem);
        //}
        #endregion

        #region 一般公用方法
        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <returns></returns>
        private OnlineClient GetOnlineClient()
        {
            var http = Context.GetHttpContext();
            var client = new OnlineClient
            {
                UserId = http.Request.Query["userId"],
                NickName = http.Request.Query["NickName"],
                Avatar = http.Request.Query["Avatar"],
            };

            return client;
        }
        #endregion
    }
}
