namespace WinChat
{
    using System;
    using System.Configuration;
    using System.Windows.Forms;
    using WinChat.Services;

    public partial class ChatForm : Form
    {
        private readonly IWebSocketService _webSocketService;

        public ChatForm(IWebSocketService webSocketService)
        {
            _webSocketService = webSocketService;

            InitializeComponent();

            _webSocketService.MessageReceived += OnMessageReceived;


        }
        private async void ChatForm_Load(object sender, EventArgs e)
        {
            txtSendMessage.PlaceholderText = "Please enter your message";
            txtSendMessage.Select();

            string webSocketPath = ConfigurationManager.AppSettings["WebsocketServerPath"];
            var uri = new Uri(webSocketPath);
            await _webSocketService.StartAsync(uri);
        }

        /* Receive Message*/
        private void OnMessageReceived(object sender, string message)
        {
            txtReceivedMessage.Invoke((Action)(() =>
            {
                txtReceivedMessage.Text = $"{message}{Environment.NewLine}{txtReceivedMessage.Text}";
            }));
        }
        /* Send Message*/
        private async void btnSend_Click(object sender, EventArgs e)
        {
            txtSendMessage.Text = txtSendMessage.Text.Trim();
            if (txtSendMessage.Text.Length > 0)
            {
                string message = "Win User: " + txtSendMessage.Text;
                await _webSocketService.SendAsync(message);
                txtSendMessage.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter the message");
            }
        }
        /* Send Message on press enter*/
        private void txtSendMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSend_Click(txtSendMessage.Focus(), e);
            }
        }
    }
}
