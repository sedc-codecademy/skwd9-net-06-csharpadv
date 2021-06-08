using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDC.WinApp
{
    public partial class Form1 : Form
    {
        private string Message = "No message yer!";

        public Form1()
        {
            InitializeComponent();
        }

        public void SendMessage(string message)
        {
            infoMessageLbl.Text = "Message sent synchronously!";
            Thread.Sleep(7000);
            Message = message;
        }

        public async Task SendMessageAsync(string message)
        {
            infoMessageLbl.Text = "Message sent asynchronously!";
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Message = message;
            });
            Message = message;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void asyncBtn_Click(object sender, EventArgs e)
        {
            await SendMessageAsync("Hello from SEDC ASYNC");
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            SendMessage("Hello from SEDC SYNC");
        }

        private void checkMessageBtn_Click(object sender, EventArgs e)
        {
            checkMessageLbl.Text = Message;
        }
    }
}
