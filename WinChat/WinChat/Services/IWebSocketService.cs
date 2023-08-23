namespace WinChat.Services
{
    public interface IWebSocketService
    {
        Task StartAsync(Uri uri);
        Task SendAsync(string message);
        event EventHandler<string> MessageReceived;
    }
}
