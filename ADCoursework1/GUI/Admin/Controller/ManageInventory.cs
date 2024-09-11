using ADCoursework1.Helper;
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

namespace ADCoursework1.GUI.Admin.Controller
{
    public partial class ManageInventory : UserControl
    {
        public ManageInventory()
        {
            InitializeComponent();
            LoadInventory();
            DataGridViewHelper.AddButtonsToInventoryGrid(this, DgvInventory, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        public void ReloadGrid()
        {
            LoadInventory();
        }

        private void LoadInventory(string searchItem = "")
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the size of the columns
            DgvInventory.Columns["colBtnUpdate"].Width = 80;
            DgvInventory.Columns["colBtnDelete"].Width = 80;
            DgvInventory.Columns["colBtnView"].Width = 80;

            // Set the row height
            DgvInventory.RowTemplate.Height = 80;

            // Base SQL query to select stock details from the Car and CarPart views
            string sql = @"
                        SELECT 
                            s.*, 
                            v.*
                        FROM 
                            Stock s
                        INNER JOIN 
                            vw_ItemDetails v ON s.item_id = v.item_id
                        WHERE 
                            1=1"; // Placeholder WHERE clause

            // List to hold SQL parameters
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add search conditions if a search term is provided
            if (!string.IsNullOrEmpty(searchItem))
            {
                sql += @"
                         AND (
                             LOWER(v.item_name) LIKE LOWER(@SearchItem)
                             OR LOWER(v.brand) LIKE LOWER(@SearchItem)
                             OR LOWER(v.item_type) LIKE LOWER(@SearchItem)
                         )";
                parameters.Add(new SqlParameter("@SearchItem", "%" + searchItem.ToLower() + "%"));

            }

            // Fetch data from the database
            DataTable inventoryTable = DatabaseHelper.ExecuteDataTable(sql, parameters.ToArray());

            if (inventoryTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvInventory.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in inventoryTable.Rows)
                {
                    DgvInventory.Rows.Add(
                        row["stock_id"],
                        row["item_type"],
                        row["brand"],
                        row["item_name"],
                        Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd"),
                        row["quantity"],
                        "",  // Icon for the Update button
                        "",  // Icon for the Delete button
                        ""   // Icon for the View button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToInventoryGrid(this, DgvInventory, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }



        private void RemoveAllButtons()
        {
            var buttonsToRemove = DgvInventory.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().ToList();
            foreach (var btn in buttonsToRemove)
            {
                DgvInventory.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void BtnAddInventory_Click(object sender, EventArgs e)
        {
            // Create an instance of the StockForm form
            using (Forms.StockForm addStockForm = new Forms.StockForm())
            {
                // Show the modal with dimming effect
                ModalHelper.ShowModalWithMaximizedDimming(addStockForm);

                // Reload the grid based on the currently selected filter
                ReloadGrid();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchItem = TbSearchItem.Text.Trim();

            // Reload the grid with the search term
            LoadInventory(searchItem);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            TbSearchItem.Clear();
        }
    }
}
