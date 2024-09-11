using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    public partial class StockManagement : UserControl
    {
        public StockManagement()
        {
            InitializeComponent();
            LoadStockOverview();
        }

        private void LoadStockOverview()
        {
            string sql = @"
                        SELECT 
                            s.stock_id,
                            s.date,  
                            v.item_name,
                            s.quantity,
                            s.reorder_level
                        FROM 
                            Stock s
                        INNER JOIN 
                            vw_ItemDetails v ON s.item_id = v.item_id
                        ORDER BY 
                            s.quantity ASC;";

            DataTable stockTable = DatabaseHelper.ExecuteDataTable(sql, null);

            // Set the row height
            DgvStockOverview.RowTemplate.Height = 60;

            // Clear existing rows if any
            DgvStockOverview.Rows.Clear();

            foreach (DataRow row in stockTable.Rows)
            {
                int quantity = Convert.ToInt32(row["quantity"]);
                int reorderLevel = Convert.ToInt32(row["reorder_level"]);
                string itemName = row["item_name"].ToString();
                string date = Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd");

                int rowIndex = DgvStockOverview.Rows.Add(
                    date,
                    itemName,
                    quantity
                );

                // Apply color coding based on the quantity and reorder level
                if (quantity < reorderLevel)
                {
                    DgvStockOverview.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    DgvStockOverview.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.ForestGreen;
                }
            }
        }

    }
}
