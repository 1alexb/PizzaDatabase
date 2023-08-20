using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PizzaDatabase
{
    public class InputValidator
    {
        public static (bool, string) OrderIDValidation(string orderId) // Method that validates the order ID field.
        {
            List<string> orderIssues = new List<string>();
            Regex orderIdPattern = new Regex("^O[0-9]{4}$"); // Regex pattern: Start with 'O' followed by any number of digits

            if (string.IsNullOrWhiteSpace(orderId))
                orderIssues.Add("Order ID");
            else if (!orderIdPattern.IsMatch(orderId))
                orderIssues.Add("Order ID format is incorrect. It should start with 'O' followed by exactly four digits.");

            if (orderIssues.Count > 0)
                return (false, string.Join(", ", orderIssues));
            else
                return (true, string.Empty);
        }

        public static (bool, string) InputValidation(string pizzaType, string pizzaSize, string orderDate, string price) // Method that validates the input fields.
        {
            List<string> missingFields = new List<string>();
            if (string.IsNullOrWhiteSpace(pizzaType))
                missingFields.Add("Pizza Type");
            if (string.IsNullOrWhiteSpace(pizzaSize))
                missingFields.Add("Pizza Size");
            if (string.IsNullOrWhiteSpace(orderDate))
                missingFields.Add("Order Date");
            if (string.IsNullOrWhiteSpace(price))
                missingFields.Add("Price is missing");
            if (missingFields.Count > 0)
                return (false, string.Join(", ", missingFields));
            else
                return (true, string.Empty);
        }

        /*public static string GetPriceBasedOnSize(string size) // Switch statement that returns the price based on the size of the pizza.
        {
            switch (size)
            {
                case "Small":
                    return "€5.00";
                case "Medium":
                    return "€10.00";
                case "Large":
                    return "€15.00";
                default:
                    return "€0.00";
            }
        }*/

        public static void ClearFields(TextBox txtOrderId, ComboBox cmbPizzaType, ComboBox cmbPizzaSize, TextBox txtOrderDate, TextBox txtPrice, CheckBox chkDelivery)
        {
            txtOrderId.Clear();
            cmbPizzaType.SelectedIndex = -1;
            cmbPizzaSize.SelectedIndex = -1;
            txtOrderDate.Clear();
            txtPrice.Clear();
            chkDelivery.Checked = false;
        }
    }
}
