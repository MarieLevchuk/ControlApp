using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    public partial class MainForm : Form
    {
        public SqlConnection SqlConnection;
        public string ConnectionString;
        AddItemForm _addItemForm;
        AddManufcturerForm _addManufcturerForm;
        MessageForm _messageForm;
        EditForm _editForm;
        YesNoForm _yesNoForm;

        public int ManufacturerID { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            _addItemForm = new AddItemForm();
            _addManufcturerForm = new AddManufcturerForm();
            _messageForm = new MessageForm();
            _editForm = new EditForm();
            _yesNoForm = new YesNoForm();

            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\ControlApp\ControllApp\CatalogDB.mdf; Integrated Security=True; MultipleActiveResultSets=true;";
            SqlConnection = new SqlConnection(ConnectionString);
            await SqlConnection.OpenAsync();

            GetManufacturersData();
        }

        private void CBoxManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxManufacturers.SelectedItem != null)
            {
                ManufacturerID = GetID(CBoxManufacturers.SelectedItem.ToString());
                DataGrid.Rows.Clear();
                DataLoad(ManufacturerID);
            }
            else
            {
                Logger.Log.Error("Error: Something is wrong in \"CBoxManufacturers_SelectedIndexChanged\"");

                _messageForm.Show("Something is wrong");                
            }            
        }              

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _addItemForm.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDBData();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            _yesNoForm.LblMessage.Text = "Do you want to remove this item?";
            DialogResult dialogResult = _yesNoForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                bool flag = false;
                string itemID = DataGrid[0, DataGrid.CurrentRow.Index].Value.ToString();
                try
                {
                    ItemRemoveByID(itemID);
                    flag = true;
                }
                catch
                {
                    Logger.Log.Error("Error: Something is wrong in \"BtnRemove_Click\"");

                    _messageForm.Show("Deletion error");
                }
                finally
                {
                    if (flag)
                    {
                        Logger.Log.Info("Item was removed");

                        _messageForm.Show("Successfully deleted!");
                        RefreshDBData();
                    }
                    else
                    {
                        Logger.Log.Error("Error: Something is wrong in \"BtnRemove_Click\"");

                        _messageForm.Show("Deletion error");
                    }                        
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                _yesNoForm.Hide();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {           
                string itemID = DataGrid[0, DataGrid.CurrentRow.Index].Value.ToString();
                _editForm.Show(itemID);
        }
        private void BtnRemoveManufacturer_Click(object sender, EventArgs e)
        {
            _yesNoForm.LblMessage.Text = "When you delete a manufacturer, all of its products will be deleted.\nWould you like to continue?";
            DialogResult dialogResult = _yesNoForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                bool flag = false;
                try
                {                                       
                    ItemRemoveByManufacturerID(ManufacturerID);
                    ManufacturerRemove(ManufacturerID);
                    flag = true;
                }
                catch
                {
                    Logger.Log.Error("Error: Something is wrong in \"BtnRemoveManufacturer_Click\"");

                    _messageForm.Show("Something  is wrong");
                }
                finally
                {
                    if (flag)
                    {
                        Logger.Log.Info("Manufacturer was removed");

                        _messageForm.Show("Manufacturer was removed successfully!");
                        RefreshDBData();
                    }
                    else
                    {
                        Logger.Log.Error("Error: Something is wrong in \"BtnRemoveManufacturer_Click\"");

                        _messageForm.Show("Deletion error");
                    }                        
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                _yesNoForm.Hide();
            }
        }

        private void BtnAddManufacturer_Click(object sender, EventArgs e)
        {
            _addManufcturerForm.Show();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
            {
                SqlConnection.Close();
            }
            Close();
        }

        public async void DataLoad(int id)
        {
            Logger.Log.Info("Method \"DataLoad\" called");

            string cmdData = "SELECT * FROM [Produces] WHERE [ManufacturerID] = @ManufacturerID";
            SqlCommand sqlCommand = new SqlCommand(cmdData, SqlConnection);
            sqlCommand.Parameters.AddWithValue("ManufacturerID", id);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            List<string[]> data = new List<string[]>();
            while (sqlDataReader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = sqlDataReader[0].ToString();
                data[data.Count - 1][1] = sqlDataReader[2].ToString();
                data[data.Count - 1][2] = sqlDataReader[3].ToString();
                data[data.Count - 1][3] = sqlDataReader[4].ToString();
            }
            sqlDataReader.Close();

            foreach (string[] item in data)
            {
                DataGrid.Rows.Add(item);
            }
        }

        public int GetID(string item)
        {
            Logger.Log.Info("Method \"GetID\" called");

            string[] selectedItem = item.Split(new char[] { ' ' });
            return Int32.Parse(selectedItem[0]);
        }

        public async void GetManufacturersData()
        {
            Logger.Log.Info("Method \"ManufacturersData\" called");

            SqlDataReader sqlDataReaderManufacturer = null;
            string cmdManufacturer = "SELECT * FROM [Manufacturers]";
            SqlCommand sqlCommandManufacturer = new SqlCommand(cmdManufacturer, SqlConnection);
            try
            {
                sqlDataReaderManufacturer = await sqlCommandManufacturer.ExecuteReaderAsync();
                while (await sqlDataReaderManufacturer.ReadAsync())
                {
                    object id = sqlDataReaderManufacturer["ManufacturerID"];
                    object manufacturer = Convert.ToString(sqlDataReaderManufacturer["Manufacturer"]);
                    object country = Convert.ToString(sqlDataReaderManufacturer["Country"]);
                    CBoxManufacturers.Items.Add($"{id} {manufacturer} ({country})");
                    _addItemForm.CBoxManufacturersInAdd.Items.Add($"{id} {manufacturer} ({country})");
                }
            }
            catch
            {
                Logger.Log.Info("Error getting manufacturers' data");

                _messageForm.Show("Error getting manufacturers' data");
            }
            finally
            {
                sqlDataReaderManufacturer.Close();
            }
        }

        public async void ItemRemoveByID(string itemId)
        {
            Logger.Log.Info("Method \"ItemRemoveByID\" called");

            string cmdToRemove = "DELETE FROM [Produces] WHERE [ID] = @ID ";
            SqlCommand sqlCommand = new SqlCommand(cmdToRemove, SqlConnection);
            sqlCommand.Parameters.AddWithValue("ID", itemId);
            await sqlCommand.ExecuteNonQueryAsync();
        }

        public async void ItemRemoveByManufacturerID(int manufacturerId)
        {
            Logger.Log.Info("Method \"ItemRemoveByManufacturerID\" called");

            string cmdToRemove = "DELETE FROM [Produces] WHERE [ManufacturerID] = @ManufacturerID";
            SqlCommand sqlCommand = new SqlCommand(cmdToRemove, SqlConnection);
            sqlCommand.Parameters.AddWithValue("ManufacturerID", manufacturerId);
            await sqlCommand.ExecuteNonQueryAsync();
        }

        public async void ManufacturerRemove(int id)
        {
            Logger.Log.Info("Method \"ManufacturerRemove\" called");

            string cmdToRemove = "DELETE FROM [Manufacturers] WHERE [ManufacturerID] = @ManufacturerID ";
            SqlCommand sqlCommand = new SqlCommand(cmdToRemove, SqlConnection);
            sqlCommand.Parameters.AddWithValue("ManufacturerID", id);
            await sqlCommand.ExecuteNonQueryAsync();
        }

        public void RefreshDBData()
        {
            Logger.Log.Info("Method \"RefreshDBData\" called");

            CBoxManufacturers.Items.Clear();
            _addItemForm.CBoxManufacturersInAdd.Items.Clear();
            GetManufacturersData();
            DataGrid.Rows.Clear();
            DataLoad(ManufacturerID);
        }
    }
}
