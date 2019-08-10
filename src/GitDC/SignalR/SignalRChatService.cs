using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace GitDC.SignalR
{
    public class SignalRChatService : ISignalRChatService
    {
        private readonly HubLifetimeManager<ChatsHub> _hubLifetimeManager;

        public SignalRChatService(HubLifetimeManager<ChatsHub> hubLifetimeManager)
        {
            _hubLifetimeManager = hubLifetimeManager;
        }

        public Task SendMessageAsync(string message)
        {
            _hubLifetimeManager.SendAllAsync("broadcastMessage", new[] { "首页测试", "返回信息" + message } );
            return _hubLifetimeManager.SendAllAsync("message", new object[] { message });
        }
    }
}
