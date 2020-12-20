using System;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }
        
        public void Show (string message)
        {
            Logger.Log.Info("Method \"Show (string message)\" in MessageForm called");

            LblMessage.Text = message;
            this.Show();
        }        

        private void LblClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
