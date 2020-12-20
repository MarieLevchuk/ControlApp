using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    public partial class EditForm : Form
    {
        MainForm _mainForm;
        MessageForm _messageForm;

        string ItemID { get; set; }

        public EditForm()
        {
            InitializeComponent();
            _mainForm = new MainForm();
            _messageForm = new MessageForm();
        }

        public void Show(string itemID)
        {
            Logger.Log.Info("Method \"Show(string itemID)\" called");

            ItemID = itemID;
            this.Show();
        }

        private async void BtnItemEdit_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                if (ItemID != String.Empty &&
                    !String.IsNullOrEmpty(TBoxNewQuantity.Text) && !String.IsNullOrWhiteSpace(TBoxNewQuantity.Text) &&
                    !String.IsNullOrEmpty(TBoxNewPrice.Text) && !String.IsNullOrWhiteSpace(TBoxNewPrice.Text))
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ControlApp\ControllApp\CatalogDB.mdf;Integrated Security=True";
                    _mainForm.SqlConnection = new SqlConnection(connectionString);
                    await _mainForm.SqlConnection.OpenAsync();
                    string cmdEdit = "UPDATE [Produces] SET [Quantity] = @Quantity, [Price] = @Price WHERE [ID]=@ID";
                    SqlCommand sqlCommandItem = new SqlCommand(cmdEdit, _mainForm.SqlConnection);
                    sqlCommandItem.Parameters.AddWithValue("ID", ItemID);
                    sqlCommandItem.Parameters.AddWithValue("Quantity", TBoxNewQuantity.Text);
                    sqlCommandItem.Parameters.AddWithValue("Price", TBoxNewPrice.Text);
                    await sqlCommandItem.ExecuteNonQueryAsync();
                    flag = true;
                }
                else
                {
                    Logger.Log.Warn("Not all fields are filled in");

                    _messageForm.Show("Fill in all fields about item");
                }
            }
            catch
            {
                Logger.Log.Error("Error editing an item");

                _messageForm.Show("Error editing");
            }
            finally
            {
                if (flag)
                {
                    Logger.Log.Error("Item was editing");

                    _messageForm.Show("The item was edited successfully!");
                }
                else
                {
                    Logger.Log.Error("Error editing an item");

                    _messageForm.Show("Error editing");
                }
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("The form for editing an item was closed");

            Hide();
        }
    }
}
