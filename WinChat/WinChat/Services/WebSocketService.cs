using System.Net.WebSockets;
using System.Text;

namespace WinChat.Services
{
    public class WebSocketService : IWebSocketService
    {
        private ClientWebSocket _webSocket;
        public event EventHandler<string> MessageReceived;

        /* Connect Websocket*/
        public async Task StartAsync(Uri uri)
        {
            _webSocket = new ClientWebSocket();
            await _webSocket.ConnectAsync(uri, CancellationToken.None);

            await ReceiveMessageAsync();
        }

        /* Send Message*/
        public async Task SendAsync(string message)
        {
            if (_webSocket.State != WebSocketState.Open)
                throw new InvalidOperationException("WebSocket is not open.");

            var buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
            await _webSocket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }


        /* Receive Message*/
        private async Task ReceiveMessageAsync()
        {
            var buffer = new byte[1024];
            while (_webSocket.State == WebSocketState.Open)
            {
                var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Text || result.MessageType == WebSocketMessageType.Binary)
                {
                    var receivedMessage = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    MessageReceived?.Invoke(this, receivedMessage);
                }
            }
        }
    }

}
