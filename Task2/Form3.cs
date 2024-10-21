// Ziv Gohasi 211541271




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form3 : Form
    {
        // Connection string to connect to the local SQL database.
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        
        // Entity framework context for interacting with the database.
        private Database1Entities db = new Database1Entities();
        public Form3()
        {
            InitializeComponent();
        }


        // Loads data from the database into the DataGridView when the form is loaded.
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource tblBindingSource = new BindingSource();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Open the database connection.


                    // Query to get all data from 'TblPlayers' table.
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TblPlayers", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // Fill the data table with results.


                    tblBindingSource.DataSource = dataTable;// Set the data source to the data table.

                    tblDataGridView.DataSource = tblBindingSource;// Display data in the DataGridView.

                    // Bind the navigator to the same data source.
                    tblBindingNavigator.BindingSource = tblBindingSource;
                }
            }
            catch (Exception ex)
            {
                // Show error message if loading data fails.
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void tblDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tblBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Q1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();// Open the database connection.

                    // Query to get player names and play times, sorted by length.
                    string query = "SELECT Name, Length FROM TblPlayers ORDER BY Length DESC";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // Fill the data table with results.

                    tblBindingSource.DataSource = dataTable;// Set the data source.

                    tblDataGridView.DataSource = tblBindingSource;// Display data in the DataGridView.

                    tblBindingNavigator.BindingSource = tblBindingSource;// Update the navigator binding.

                    tblDataGridView.Refresh();// Refresh the DataGridView to show the new data.
                }
            }
            catch (Exception ex)
            {
                // Show error message if the operation fails.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Q2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Open the database connection.


                    // Query to get the total play time for each player, sorted by total length.
                    string query = @"
                SELECT Name COLLATE Latin1_General_BIN AS Name, SUM(Length) AS TotalLength 
                FROM TblPlayers 
                GROUP BY Name COLLATE Latin1_General_BIN 
                ORDER BY TotalLength DESC";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);// Fill the data table with results.

                    tblBindingSource.DataSource = dataTable;// Set the data source.

                    tblDataGridView.DataSource = tblBindingSource; // Display data in the DataGridView.

                    tblBindingNavigator.BindingSource = tblBindingSource;// Update the navigator binding.

                    tblDataGridView.Refresh();// Refresh the DataGridView to show the new data.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Q3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Open the database connection.

                    // Query to get all records from 'TblPlayers', sorted by Id in ascending order.
                    string query = "SELECT * FROM TblPlayers ORDER BY Id ASC";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // Fill the data table with results.

                    tblBindingSource.DataSource = dataTable;// Set the data source.

                    tblDataGridView.DataSource = tblBindingSource;// Display data in the DataGridView.

                    tblBindingNavigator.BindingSource = tblBindingSource;// Update the navigator binding.

                    // If the 'Id' column exists, make it visible and place it at the first position.
                    if (tblDataGridView.Columns["Id"] != null)
                    {
                        tblDataGridView.Columns["Id"].Visible = true;
                        tblDataGridView.Columns["Id"].DisplayIndex = 0; // העברת עמודת Id למיקום הראשון
                    }

                    tblDataGridView.Refresh(); // Refresh the DataGridView to show the new data.
                }
            }
            catch (Exception ex)
            {
                // Show error message if the operation fails.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            
        }
        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            
        }
        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
