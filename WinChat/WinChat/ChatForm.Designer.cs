namespace WinChat
{
    partial class ChatForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSendMessage = new TextBox();
            panelOutput = new Panel();
            txtReceivedMessage = new TextBox();
            panelSendMessage = new Panel();
            panelButton = new Panel();
            btnSend = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panelOutput.SuspendLayout();
            panelSendMessage.SuspendLayout();
            panelButton.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSendMessage
            // 
            txtSendMessage.Dock = DockStyle.Fill;
            txtSendMessage.Location = new Point(0, 0);
            txtSendMessage.Multiline = true;
            txtSendMessage.Name = "txtSendMessage";
            txtSendMessage.Size = new Size(641, 51);
            txtSendMessage.TabIndex = 0;
            txtSendMessage.KeyPress += txtSendMessage_KeyPress;
            // 
            // panelOutput
            // 
            panelOutput.Controls.Add(txtReceivedMessage);
            panelOutput.Dock = DockStyle.Bottom;
            panelOutput.Location = new Point(0, 89);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(800, 361);
            panelOutput.TabIndex = 2;
            // 
            // txtReceivedMessage
            // 
            txtReceivedMessage.Dock = DockStyle.Fill;
            txtReceivedMessage.Location = new Point(0, 0);
            txtReceivedMessage.Margin = new Padding(10, 3, 10, 3);
            txtReceivedMessage.Multiline = true;
            txtReceivedMessage.Name = "txtReceivedMessage";
            txtReceivedMessage.ReadOnly = true;
            txtReceivedMessage.ScrollBars = ScrollBars.Vertical;
            txtReceivedMessage.Size = new Size(800, 361);
            txtReceivedMessage.TabIndex = 2;
            // 
            // panelSendMessage
            // 
            panelSendMessage.Controls.Add(txtSendMessage);
            panelSendMessage.Controls.Add(panelButton);
            panelSendMessage.Dock = DockStyle.Top;
            panelSendMessage.Location = new Point(0, 0);
            panelSendMessage.Name = "panelSendMessage";
            panelSendMessage.Size = new Size(800, 51);
            panelSendMessage.TabIndex = 3;
            // 
            // panelButton
            // 
            panelButton.Controls.Add(btnSend);
            panelButton.Dock = DockStyle.Right;
            panelButton.Location = new Point(641, 0);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(159, 51);
            panelButton.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Fill;
            btnSend.Location = new Point(0, 0);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(159, 51);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send Message";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 3;
            label1.Text = "Received Messages";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 32);
            panel1.TabIndex = 4;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelSendMessage);
            Controls.Add(panelOutput);
            Name = "ChatForm";
            Text = "Win Chat";
            Load += ChatForm_Load;
            panelOutput.ResumeLayout(false);
            panelOutput.PerformLayout();
            panelSendMessage.ResumeLayout(false);
            panelSendMessage.PerformLayout();
            panelButton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label OutputLabel;
        private TextBox txtSendMessage;
        private Panel panelOutput;
        private Panel panelSendMessage;
        private Panel panelButton;
        private Button btnSend;
        private Label labelHeading;
        private TextBox txtReceivedMessage;
        private Label label1;
        private Panel panel1;
    }
}