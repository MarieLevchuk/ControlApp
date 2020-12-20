using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    public partial class AddManufcturerForm : Form
    {
        MainForm _mainForm;
        MessageForm _messageForm;

        public AddManufcturerForm()
        {
            InitializeComponent();
            _mainForm = new MainForm();
            _messageForm = new MessageForm();
        }

        private async void BtnAddManufacturer_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                if (!String.IsNullOrEmpty(TBoxAddManufacturer.Text) && !String.IsNullOrWhiteSpace(TBoxAddManufacturer.Text) &&
                    !String.IsNullOrEmpty(TBoxAddCountry.Text) && !String.IsNullOrWhiteSpace(TBoxAddCountry.Text))
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ControlApp\ControllApp\CatalogDB.mdf;Integrated Security=True";
                    _mainForm.SqlConnection = new SqlConnection(connectionString);
                    await _mainForm.SqlConnection.OpenAsync();
                    string cmdTextInsertItem = $"INSERT INTO [Manufacturers] (Manufacturer, Country) " +
                        $"VALUES (@Manufacturer, @Country)";
                    SqlCommand sqlCommandItem = new SqlCommand(cmdTextInsertItem, _mainForm.SqlConnection);
                    sqlCommandItem.Parameters.AddWithValue("Manufacturer", TBoxAddManufacturer.Text);
                    sqlCommandItem.Parameters.AddWithValue("Country", TBoxAddCountry.Text);
                    await sqlCommandItem.ExecuteNonQueryAsync();
                    flag = true;
                }
                else
                {
                    Logger.Log.Warn("Not all fields are filled in");

                    _messageForm.Show("Fill in all fields");
                }
            }
            catch
            {
                Logger.Log.Error("Error adding a new manufacturer");

                _messageForm.Show("Error adding a new manufacturer");
            }
            finally
            {
                if (flag)
                {
                    Logger.Log.Info("New successfully was added");

                    _messageForm.Show("Manufacturer was added successfully!");
                }
                else
                {
                    Logger.Log.Error("Error adding a new manufacturer");

                    _messageForm.Show("Error adding a new manufacturer");
                }
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Logger.Log.Info("The form for adding a new manufacturer was closed");

            Hide();
        }
    }
}
