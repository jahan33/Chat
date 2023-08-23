using Microsoft.Extensions.DependencyInjection;
using WinChat.Services;

namespace WinChat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();
            services.AddSingleton<IWebSocketService, WebSocketService>();
            services.AddSingleton<ChatForm>();
            // Add other services and forms here if needed

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<ChatForm>());


        }
    }
}