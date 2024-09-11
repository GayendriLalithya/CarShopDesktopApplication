using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace ADCoursework1.Helper
{
    internal class ComboBoxHelper
    {
        // Method to load brands into a Guna2ComboBox
        public static void LoadBrandsIntoComboBox(Guna2ComboBox comboBox)
        {
            string sql = "SELECT brand_id, brand_name FROM Brand WHERE deleted = 0";
            DataTable brandTable = DatabaseHelper.ExecuteDataTable(sql, null);

            if (brandTable != null)  // Add null check
            {
                DataRow allRow = brandTable.NewRow();
                allRow["brand_id"] = DBNull.Value;
                allRow["brand_name"] = "All";
                brandTable.Rows.InsertAt(allRow, 0);

                comboBox.DataSource = brandTable;
                comboBox.DisplayMember = "brand_name";
                comboBox.ValueMember = "brand_id";
            }
        }

        // Method to load years into a Guna2ComboBox
        public static void LoadYearsIntoComboBox(Guna2ComboBox comboBox)
        {
            string sql = "SELECT DISTINCT year FROM Car ORDER BY year DESC";
            DataTable yearTable = DatabaseHelper.ExecuteDataTable(sql, null);

            if (yearTable != null)  // Add null check
            {
                DataRow allRow = yearTable.NewRow();
                allRow["year"] = DBNull.Value;  // Use correct null value for integer column
                yearTable.Rows.InsertAt(allRow, 0);

                comboBox.DataSource = yearTable;
                comboBox.DisplayMember = "year";
                comboBox.ValueMember = "year";
            }
        }

        // Method to load price ranges into a Guna2ComboBox
        public static void LoadPriceRangesIntoComboBox(Guna2ComboBox comboBox)
        {
            // Define price ranges
            DataTable priceRangeTable = new DataTable();
            priceRangeTable.Columns.Add("Display", typeof(string));
            priceRangeTable.Columns.Add("Value", typeof(string));

            // Add "All" option at the top
            priceRangeTable.Rows.Add("All", "0-1000000");

            priceRangeTable.Rows.Add("Below $30,000", "0-30000");
            priceRangeTable.Rows.Add("$30,000 - $50,000", "30000-50000");
            priceRangeTable.Rows.Add("$50,000 - $100,000", "50000-100000");
            priceRangeTable.Rows.Add("Above $100,000", "100000-1000000"); // Set upper bound to a high number

            comboBox.DataSource = priceRangeTable;
            comboBox.DisplayMember = "Display";
            comboBox.ValueMember = "Value";
        }

        // Method to load car part price ranges into a Guna2ComboBox
        public static void LoadCarPartPriceRangesIntoComboBox(Guna2ComboBox comboBox)
        {
            // Define price ranges for car parts
            DataTable priceRangeTable = new DataTable();
            priceRangeTable.Columns.Add("Display", typeof(string));
            priceRangeTable.Columns.Add("Value", typeof(string));

            // Add "All" option at the top
            priceRangeTable.Rows.Add("All", "0-100000");

            priceRangeTable.Rows.Add("Below $100", "0-100");
            priceRangeTable.Rows.Add("$100 - $500", "100-500");
            priceRangeTable.Rows.Add("$500 - $1,000", "500-1000");
            priceRangeTable.Rows.Add("Above $1,000", "1000-100000"); // Set upper bound to a high number

            comboBox.DataSource = priceRangeTable;
            comboBox.DisplayMember = "Display";
            comboBox.ValueMember = "Value";
        }

    }
}
