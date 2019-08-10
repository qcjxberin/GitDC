using System.Threading.Tasks;

namespace GitDC.SignalR
{
    public interface ISignalRChatService
    {
        Task SendMessageAsync(string message);
    }
}
