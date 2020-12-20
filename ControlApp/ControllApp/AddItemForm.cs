using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    public partial class AddItemForm : Form
    {
        MainForm _mainForm;
        MessageForm _messageForm;
        int _id;

        public AddItemForm()
        {
            InitializeComponent();
            _mainForm = new MainForm();
            _messageForm = new MessageForm();
        }                


        private async void BtnAddItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {    
                if (_id != 0 &&
                    !String.IsNullOrEmpty(TBoxAddItem.Text) && !String.IsNullOrWhiteSpace(TBoxAddItem.Text) &&
                    !String.IsNullOrEmpty(TBoxAddQuantity.Text) && !String.IsNullOrWhiteSpace(TBoxAddQuantity.Text) &&
                    !String.IsNullOrEmpty(TBoxAddPrice.Text) && !String.IsNullOrWhiteSpace(TBoxAddPrice.Text))
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ControlApp\ControllApp\CatalogDB.mdf;Integrated Security=True";                    
                    _mainForm.SqlConnection = new SqlConnection(connectionString);
                    await _mainForm.SqlConnection.OpenAsync();
                    string cmdTextInsertItem = $"INSERT INTO [Produces] " +
                        $"(ManufacturerID, Name, Quantity, Price) VALUES " +
                        $"(@ManufacturerID, @Name, @Quantity, @Price)";
                    SqlCommand sqlCommandItem = new SqlCommand(cmdTextInsertItem, _mainForm.SqlConnection);
                    sqlCommandItem.Parameters.AddWithValue("ManufacturerID", _id);
                    sqlCommandItem.Parameters.AddWithValue("Name", TBoxAddItem.Text);
                    sqlCommandItem.Parameters.AddWithValue("Quantity", TBoxAddQuantity.Text);
                    sqlCommandItem.Parameters.AddWithValue("Price", TBoxAddPrice.Text);
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
                Logger.Log.Error("Error adding a new item");

                _messageForm.Show("Error adding a new item");
            }
            finally
            {
                if (flag)
                {
                    Logger.Log.Info("New item was added");

                    _messageForm.Show("The item was added successfully!");
                }
                else
                {
                    Logger.Log.Error("Error adding a new item");

                   //_messageForm.Show("Error adding a new item");
                }                    
            }
        }

        private void CBoxManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxManufacturersInAdd.SelectedItem != null)
            {                
                _id = _mainForm.GetID(CBoxManufacturersInAdd.SelectedItem.ToString());
            }
            else
            {
                Logger.Log.Info("Error getting an ID for adding new item");

                _messageForm.Show("Error getting an ID");
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("The form for adding a new item was closed");

            Hide();
        }
    }
}
