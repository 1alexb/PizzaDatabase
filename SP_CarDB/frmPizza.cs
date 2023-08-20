using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PizzaDatabase
{
    public partial class FrmPizza : Form
    {
        // Variables for data storage and manipulation
        // pizzaDataset holds data in memory
        DataSet pizzaDataset = new DataSet();
        // pizzaDataAdapter serves as a bridge between the dataset and the database
        SqlDataAdapter pizzaDataAdapter;
        // pizzaBindingSource links form controls to data source
        BindingSource pizzaBindingSource;
        // dbSQLCommands generates SQL commands for data updates
        SqlCommandBuilder dbSQLCommands;

        public FrmPizza()
        {
            InitializeComponent();
            // Setting the form title bar
            this.Text = $"Task A Search {Environment.UserName} {DateTime.Today.ToShortDateString()}";
        }

        // Event Handler for the form load event
        private void FrmPizza_Load(object sender, EventArgs e)
        {

            // Display instructions to the user
            MessageBox.Show("Please note the following important points before you start:\n\n" +
                            "1) All fields must be complete before Updating an Order. This includes the Order ID, Pizza Type, Pizza Size, Order Date, and Price. Incomplete entries will not be saved.\n\n" +
                            "2) The format of the Order ID must be 'O' followed by a four-digit number (e.g., O0001, O0123, etc.). The Order Date must be in the format 'dd/mm/yyyy'. The Price must be in the format '€0.00'.\n\n" +
                            "3) If you move to a different record without clicking 'Update', your changes will be lost. Please make sure to click 'Update' after making any changes.", "Instructions");

            // Building the DB connection string dynamically
            string thisMachine = Environment.MachineName;
            string DBConnectionString = $@"Data Source={thisMachine}\SQLEXPRESS;Initial Catalog=Hire;Integrated Security=True;";

            cmbPizzaSize.SelectedIndexChanged += cmbPizzaSize_SelectedIndexChanged;

            try
            {
                // Connecting to database and loading data into memory
                pizzaDataAdapter = new SqlDataAdapter("SELECT * FROM tblPizza", DBConnectionString);
                pizzaDataAdapter.Fill(pizzaDataset, "tblPizza");
                MessageBox.Show("Connected to Database!");
            }
            catch (SqlException ex) // Handling SQL exceptions
            {
                MessageBox.Show("A database error occurred: " + ex.Message);
                return;
            }
            catch (Exception ex) // Handling general exceptions
            {
                MessageBox.Show(ex.GetType().ToString() + ":" + ex.Message);
                return;
            }

            // Binding form controls to data source
            BindControls();
            // Displaying current record count
            recordCountDisplay();
            // Subscribing to PositionChanged event of pizzaBindingSource
            pizzaBindingSource.PositionChanged += rowPositionChanged;
        }

        // Event Handler for pizzaBindingSource.PositionChanged event
        private void rowPositionChanged(object sender, EventArgs e)
        {
            recordCountDisplay();
        }

        // Method to bind form controls to data source
        private void BindControls()
        {
            // Creating and setting up BindingSource
            pizzaBindingSource = new BindingSource(pizzaDataset, "tblPizza");

            // Binding form controls to appropriate data fields
            txtOrderId.DataBindings.Add(new Binding("Text", pizzaBindingSource, "OrderId", true, DataSourceUpdateMode.OnValidation));
            cmbPizzaType.DataBindings.Add(new Binding("SelectedItem", pizzaBindingSource, "PizzaType", true, DataSourceUpdateMode.OnValidation));
            cmbPizzaSize.DataBindings.Add(new Binding("SelectedItem", pizzaBindingSource, "PizzaSize", true, DataSourceUpdateMode.OnValidation));

            // Setting up and adding data bindings for date and cost fields with proper formatting

            Binding orderDateBinding = new Binding("Text", pizzaBindingSource, "OrderDate", true);
            txtOrderDate.DataBindings.Add(orderDateBinding);
            orderDateBinding.FormatInfo = new CultureInfo("en-IE");

            Binding pizzaPriceBinding = new Binding("Text", pizzaBindingSource, "Price", true, DataSourceUpdateMode.OnValidation, "", "c");
           
            //  ("") is passed as the nullValue argument to the Binding constructor to prevent the control from displaying the string "null" when the value of the data source is DBNull.Value.
            // This tells the binding to use an empty string when it can't format the Price value as a currency. This way, the application won't throw an exception when the Price text box is empty.

            // Binding Available checkbox to data field
            chkDelivery.DataBindings.Add(new Binding("Checked", pizzaBindingSource, "Delivery", true, DataSourceUpdateMode.OnValidation));
            txtPrice.DataBindings.Add(pizzaPriceBinding);
        }

        // Event Handler for the Update button click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Order ID issues firstly
                var orderIDCheck = InputValidator.OrderIDValidation(txtOrderId.Text);
                if (!orderIDCheck.Item1)
                {
                    MessageBox.Show($"Please fill in the following fields: {orderIDCheck.Item2}");
                    return;
                }

                // Check other fields secondly
                var fieldCheck = InputValidator.InputValidation(txtOrderId.Text, cmbPizzaType.Text, cmbPizzaSize.Text, txtPrice.Text);
                if (!fieldCheck.Item1)
                {
                    MessageBox.Show($"Please fill in the following fields: {fieldCheck.Item2}");
                    return;
                }

                // Finalizing edits to the data
                pizzaBindingSource.EndEdit();
                // Generating SQL commands for data updates
                dbSQLCommands = new SqlCommandBuilder(pizzaDataAdapter);
                // Updating database with changes made to dataset
                pizzaDataAdapter.Update(pizzaDataset, "tblPizza");

                MessageBox.Show("Added order!");
            }
            catch (SqlException ex) // Handling SQL exceptions
            {
                if (ex.Number == 2627) // Violation of primary key (unique constraint)
                {
                    MessageBox.Show("Order ID is already in use. Please choose a different Order ID.");
                }

                /*else if (ex.Number == 515) // Violation of NOT NULL constraint
                {
                    MessageBox.Show("There is a field missing in one of the records, so you can't update the database. If unsure, Exit the app.");
                }*/

                else if (ex.Number == 547) // Violation of FOREIGN KEY constraint
                {
                    MessageBox.Show("Invalid Pizza Type or Pizza Size. Please choose a valid Pizza Type and Pizza Size.");
                }

                else
                {
                    MessageBox.Show("A database error occurred while updating: " + ex.Message);
                }
            }

            catch (Exception ex) // Handling general exceptions
            {
                MessageBox.Show("An unexpected error occurred while updating: " + ex.Message);
            }
        }

        // Event Handlers for Add, Delete, and Cancel button click events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Adding a new row to the dataset
            pizzaBindingSource.AddNew();

            // Clear fields
            InputValidator.ClearFields(txtOrderId, cmbPizzaType, cmbPizzaSize, txtOrderDate, txtPrice, chkDelivery);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Removing the currently viewed row
            pizzaBindingSource.RemoveCurrent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Canceling editing of the currently viewed row
            pizzaBindingSource.CancelEdit();
            // Rolling back changes made to the dataset
            pizzaDataset.RejectChanges();
        }

        // Method to display total record count and current record number
        private void recordCountDisplay()
        {
            txtRecordCount.Text = String.Format(" {0} of {1}", pizzaBindingSource.Position + 1, pizzaBindingSource.Count);
        }

        // Event Handlers for navigation button click events
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pizzaBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pizzaBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pizzaBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pizzaBindingSource.MoveLast();
        }

        // Event Handler for Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exits the application
        }

        // Event Handler for Search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchFrom = new frmSearch();
            searchFrom.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker.
            DateTime selectedDate = dateTimePicker1.Value;

            // Format the date as a string.
            string dateString = selectedDate.ToString("dd/MM/yyyy");

            // Assign the string to the TextBox.
            txtOrderDate.Text = dateString;
        }

        /*private void cmbPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = cmbPizzaSize.SelectedItem.ToString();
            string price = InputValidator.GetPriceBasedOnSize(selectedSize);

            txtPrice.Text = price;
        }*/

        private void cmbPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a pizza size is selected
            if (cmbPizzaSize.SelectedItem != null)
            {
                // Setting the price based on the selected pizza size
                switch (cmbPizzaSize.SelectedItem.ToString())
                {
                    case "Small":
                        txtPrice.Text = "€5.00";
                        break;
                    case "Medium":
                        txtPrice.Text = "€10.00";
                        break;
                    case "Large":
                        txtPrice.Text = "€15.00";
                        break;
                    default:
                        txtPrice.Text = "€0.00";
                        break;
                }
            }
        }
    }
}