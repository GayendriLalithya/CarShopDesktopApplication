using ADCoursework1.Entities;
using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Admin.Forms
{
    public partial class StockForm : Form
    {
        private int? StockId { get; set; }
        private int ItemId { get; set; }
        private bool IsUpdateMode { get; set; }

        public StockForm()
        {
            InitializeComponent();
            LoadItemTypes();
            LoadBrands();
            CmbItemType.SelectedIndexChanged += CmbItemType_SelectedIndexChanged;
            CmbBrand.SelectedIndexChanged += CmbBrand_SelectedIndexChanged;
        }

        public StockForm(bool isUpdateMode = false, int? stockId = null) : this()
        {
            this.IsUpdateMode = isUpdateMode;
            this.StockId = stockId;

            if (IsUpdateMode && stockId.HasValue)
            {
                LblFormHeading.Text = "Update Stock";
                BtnSubmit.Text = "Update Stock";
                DisableFields();
                LoadStockDetails(stockId.Value); // Make sure this method is working correctly
            }
            else
            {
                LblFormHeading.Text = "Add New Stock";
                BtnSubmit.Text = "Add Stock";
            }
        }

        private void DisableFields()
        {
            CmbItemType.Enabled = false;
            CmbBrand.Enabled = false;
            TbItemName.ReadOnly = true;
        }

        private void LoadItemTypes()
        {
            CmbItemType.Items.Clear(); // Clear existing items
            CmbItemType.Items.Add("Car");
            CmbItemType.Items.Add("Car Part");

            if (CmbItemType.Items.Count > 0)
            {
                CmbItemType.SelectedIndex = 0; // Optionally select the first item
            }
        }

        private void LoadBrands()
        {
            string sql = "SELECT brand_id, brand_name FROM Brand";
            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sql, null))
            {
                DataTable brandTable = new DataTable();
                brandTable.Load(reader);
                CmbBrand.DataSource = brandTable;
                CmbBrand.DisplayMember = "brand_name";
                CmbBrand.ValueMember = "brand_id";
            }
        }

        private void CmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillItemName();
        }

        private void CmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoFillItemName();
        }

        
        private void AutoFillItemName()
        {
            if (CmbItemType.SelectedItem != null && CmbBrand.SelectedValue != null)
            {
                string sql = @"
        SELECT item_id, item_name 
        FROM vw_ItemDetails 
        WHERE item_type = @ItemType 
        AND brand = @Brand";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ItemType", CmbItemType.SelectedItem.ToString()),
            new SqlParameter("@Brand", CmbBrand.Text)
                };

                DataTable itemTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

                if (itemTable.Rows.Count > 0)
                {
                    TbItemName.AutoCompleteCustomSource.Clear(); // Clear existing suggestions
                    TbItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    TbItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    foreach (DataRow row in itemTable.Rows)
                    {
                        TbItemName.AutoCompleteCustomSource.Add(row["item_name"].ToString());
                    }
                }
                else
                {
                    TbItemName.AutoCompleteCustomSource.Clear(); // No items found
                    TbItemName.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }

        private void LoadStockDetails(int stockId)
        {
            string sql = @"
        SELECT 
            s.stock_id, 
            s.item_id, 
            s.date, 
            s.quantity, 
            s.reorder_level,  
            v.item_type, 
            v.brand, 
            v.item_name  
        FROM 
            Stock s 
        JOIN 
            vw_ItemDetails v ON s.item_id = v.item_id 
        WHERE 
            s.stock_id = @StockId";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@StockId", stockId)
            };

            DataTable stockTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (stockTable.Rows.Count > 0)
            {
                DataRow row = stockTable.Rows[0];
                ItemId = Convert.ToInt32(row["item_id"]);
                CmbItemType.SelectedItem = row["item_type"].ToString();
                CmbBrand.Text = row["brand"].ToString();
                TbItemName.Text = row["item_name"].ToString();
                TbDate.Text = Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd");
                NmrcUpDwnQuantity.Value = Convert.ToInt32(row["quantity"]);
                NmrcUpDwnLevel.Value = Convert.ToInt32(row["reorder_level"]);
            }
            else
            {
                Home.ShowAlert("Failed to load stock details.", Alert.AlertType.Error);
            }
        }


        private int GetItemId()
        {
            // SQL query to fetch the item_id based on the item type, brand, and item name
            string sql = @"
        SELECT item_id 
        FROM vw_ItemDetails 
        WHERE item_type = @ItemType 
        AND brand = @Brand 
        AND item_name = @ItemName";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@ItemType", CmbItemType.SelectedItem.ToString()),
        new SqlParameter("@Brand", CmbBrand.Text),
        new SqlParameter("@ItemName", TbItemName.Text)
            };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);

            if (result != null && int.TryParse(result.ToString(), out int itemId))
            {
                return itemId; // Return the item_id if found
            }
            else
            {
                return -1; // Return -1 if item is not found
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Home.ShowAlert("Please fill in all required fields.", Alert.AlertType.Info);
                return;
            }

            // Get the item ID
            ItemId = GetItemId();

            if (ItemId <= 0)
            {
                Home.ShowAlert($"The selected item with ID {ItemId} does not exist in the database.", Alert.AlertType.Error);
                return;
            }

            Stock stock;
            try
            {
                if (IsUpdateMode && StockId.HasValue)
                {
                    stock = new Stock(StockId.Value, ItemId, Convert.ToDateTime(TbDate.Text), (int)NmrcUpDwnQuantity.Value, (int)NmrcUpDwnLevel.Value);
                    Stock.UpdateStock(stock.StockId, stock.ItemId, stock.Date, stock.Quantity, stock.ReorderLevel);
                    Home.ShowAlert("Stock updated successfully.", Alert.AlertType.Success);
                }
                else
                {
                    stock = new Stock(ItemId, Convert.ToDateTime(TbDate.Text), (int)NmrcUpDwnQuantity.Value, (int)NmrcUpDwnLevel.Value);
                    Stock.AddStock(stock.ItemId, stock.Date, stock.Quantity, stock.ReorderLevel);
                    Home.ShowAlert("Stock added successfully.", Alert.AlertType.Success);
                }

                this.Close();
            }
            catch (SqlException ex)
            {
                //Console.WriteLine("SQL Error: " + ex.Message);
                Home.ShowAlert("An error occurred while updating the stock record. Please try again.", Alert.AlertType.Error);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                Home.ShowAlert("An unexpected error occurred. Please try again.", Alert.AlertType.Error);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (CmbItemType.SelectedIndex == -1)
            {
                isValid = false;
                Home.ShowAlert("Item type is required.", Alert.AlertType.Info);
                CmbItemType.Focus();
            }

            if (CmbBrand.SelectedIndex == -1)
            {
                isValid = false;
                Home.ShowAlert("Brand is required.", Alert.AlertType.Info);
                CmbBrand.Focus();
            }

            if (string.IsNullOrWhiteSpace(TbItemName.Text))
            {
                isValid = false;
                Home.ShowAlert("Item name is required.", Alert.AlertType.Info);
                TbItemName.Focus();
            }

            if (string.IsNullOrWhiteSpace(TbDate.Text) || !DateTime.TryParse(TbDate.Text, out _))
            {
                isValid = false;
                Home.ShowAlert("Valid date is required.", Alert.AlertType.Info);
                TbDate.Focus();
            }

            if (NmrcUpDwnQuantity.Value <= 0)
            {
                isValid = false;
                Home.ShowAlert("Quantity must be greater than zero.", Alert.AlertType.Info);
                NmrcUpDwnQuantity.Focus();
            }

            if (NmrcUpDwnLevel.Value <= 0)
            {
                isValid = false;
                Home.ShowAlert("Reorder level must be greater than zero.", Alert.AlertType.Info);
                NmrcUpDwnLevel.Focus();
            }

            return isValid;
        }

        public Stock GetUpdatedStock()
        {
            // Assuming the fields are already filled out correctly, return the updated Stock object
            return new Stock(
                StockId.Value,
                ItemId,
                Convert.ToDateTime(TbDate.Text),
                (int)NmrcUpDwnQuantity.Value,
                (int)NmrcUpDwnLevel.Value
            );
        }

    }
}
