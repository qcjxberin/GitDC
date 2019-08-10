using GitDC.Common;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace GitDC.SignalR
{
    public static class SendHubs
    {
        /// <summary>
        /// 调用hub方法
        /// </summary>
        /// <param name="methodName"></param>
        public static async Task Start(string methodName, params object[] args)
        {
            var hubConnection = new HubConnectionBuilder()
                .WithUrl($"{SiteSetting.Current.Url}/chathub")
                .Build();

            await hubConnection.StartAsync();
            //await hubConnection.InvokeAsync(methodName);
            Console.WriteLine("连接状态" + hubConnection.State);
        }
    }
}
