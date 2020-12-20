using System;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    public partial class YesNoForm : Form
    {
        public YesNoForm()
        {
            InitializeComponent();
        }
        public void Show(string message)
        {
            Logger.Log.Info("Method \"Show (string message)\" in YesNoForm called");

            LblMessage.Text = message;
            this.Show();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
