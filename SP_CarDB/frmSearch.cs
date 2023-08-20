using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// Define the namespace
namespace PizzaDatabase
{
    // Define the frmSearch form
    public partial class frmSearch : Form
    {
        // Define the connection string for the SQL database
        private string DBConnectionString = $@"Data Source={Environment.MachineName}\SQLEXPRESS;Initial Catalog=Hire;Integrated Security=True;";

        // Constructor for the frmSearch form
        public frmSearch()
        {
            // Initialize the form components
            InitializeComponent();

            // Set the text of the form
            this.Text = $"Task A Search {Environment.UserName} {DateTime.Today.ToShortDateString()}";
        }

        // Event handler for the Load event of the frmSearch form
        private void frmSearch_Load(object sender, EventArgs e)
        {
            // Populate the combo boxes for fields and operators
            cboField.Items.AddRange(new string[] { "PizzaType", "PizzaSize", "Price", "Delivery" });
            cboOperator.Items.AddRange(new string[] { "=", "<", ">", "<=", ">=" });
        }

        // Event handler for the Click event of the Run button
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Validate the selected items and text in the combo boxes and text box
            if (cboField.SelectedItem == null || cboOperator.SelectedItem == null || string.IsNullOrEmpty(txtValue.Text))
            {
                // Show a message box if any of the search criteria is missing
                MessageBox.Show("Please fill all the search criteria.");
                return;
            }

            // Get the selected field, operator, and value from the form controls
            string field = cboField.SelectedItem.ToString();
            string operatorSymbol = cboOperator.SelectedItem.ToString();
            string value = txtValue.Text;

            // Define the SQL query string
            string sqlQuery = $"SELECT OrderId, PizzaType, PizzaSize, OrderDate, Price, Delivery FROM tblPizza WHERE {field} {operatorSymbol} @Value";

            // Create a new SQL connection
            using (SqlConnection connection = new SqlConnection(DBConnectionString))
            {
                // Create a new SQL command
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add a parameter to the command
                    command.Parameters.AddWithValue("@Value", value);

                    // Try to execute the command
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a new SQL data adapter
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            // Create a new data table
                            DataTable dataTable = new DataTable();

                            // Fill the data table with the result of the command
                            dataAdapter.Fill(dataTable);

                            // Set the data source of the data grid view to the data table
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                    // Catch any SQL exceptions
                    catch (SqlException ex)
                    {
                        // Show a message box with the exception message
                        MessageBox.Show("A database error occurred: " + ex.Message);
                    }
                }
            }
        }

        // Event handler for the Click event of the Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Hide the form
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
