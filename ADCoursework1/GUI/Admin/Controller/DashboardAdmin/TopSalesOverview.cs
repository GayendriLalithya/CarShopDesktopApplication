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

namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    public partial class TopSalesOverview : UserControl
    {
        public TopSalesOverview()
        {
            InitializeComponent();
            LoadCarIncomeData(); 
            LoadCarPartIncomeData();
        }

        private void LoadCarIncomeData()
        {
            string carIncomeSql = @"
            SELECT 
                v.item_id,
                v.item_type,
                v.brand,
                v.item_name,
                SUM(oi.price * oi.quantity) AS total_income
            FROM 
                OrderItem oi
            INNER JOIN 
                Orders o ON oi.order_id = o.order_id
            INNER JOIN 
                vw_ItemDetails v ON oi.item_id = v.item_id
            WHERE 
                o.status = 'Completed' 
                AND v.item_type = 'Car'
            GROUP BY 
                v.item_id, v.item_type, v.brand, v.item_name
            ORDER BY 
                total_income DESC;
            ";

            LoadIncomeDataToGrid(carIncomeSql, DgvCarIncome, "colBrandImage", "colCarName", "colCarIncome");
            DgvCarIncome.RowTemplate.Height = 60;
        }

        private void LoadCarPartIncomeData()
        {
            string carPartIncomeSql = @"
            SELECT 
                v.item_id,
                v.item_type,
                v.brand,
                v.item_name,
                SUM(oi.price * oi.quantity) AS total_income
            FROM 
                OrderItem oi
            INNER JOIN 
                Orders o ON oi.order_id = o.order_id
            INNER JOIN 
                vw_ItemDetails v ON oi.item_id = v.item_id
            WHERE 
                o.status = 'Completed' 
                AND v.item_type = 'Car Part'
            GROUP BY 
                v.item_id, v.item_type, v.brand, v.item_name
            ORDER BY 
                total_income DESC;
            ";

            LoadIncomeDataToGrid(carPartIncomeSql, DgvPartIncome, "colPartBrandImage", "colPartName", "colPartIncome");
            DgvPartIncome.RowTemplate.Height = 60;
        }

        private void LoadIncomeDataToGrid(string sql, DataGridView dgv, string brandImageColumn, string nameColumn, string incomeColumn)
        {
            DataTable incomeTable = DatabaseHelper.ExecuteDataTable(sql, null);

            dgv.Rows.Clear();

            foreach (DataRow row in incomeTable.Rows)
            {
                string brandName = row["brand"].ToString();
                string itemName = row["item_name"].ToString();
                decimal totalIncome = Convert.ToDecimal(row["total_income"]);

                // Get the brand image based on the brand name
                Image brandImage = GetBrandImage(brandName);

                int rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].Cells[brandImageColumn].Value = brandImage;
                dgv.Rows[rowIndex].Cells[nameColumn].Value = itemName;
                dgv.Rows[rowIndex].Cells[incomeColumn].Value = totalIncome.ToString("C");  // Display as currency
            }
        }

        private Image GetBrandImage(string brandName)
        {
            string sql = "SELECT image FROM Brand WHERE brand_name = @BrandName";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@BrandName", brandName)
            };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);

            if (result != null)
            {
                string imagePath = result.ToString();

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    // Load the original image
                    Image originalImage = Image.FromFile(imagePath);

                    // Add padding to the image
                    int padding = 10; // Set the padding size here
                    int newWidth = originalImage.Width + padding * 2;
                    int newHeight = originalImage.Height + padding * 2;

                    // Create a new bitmap with the size of the original image plus padding
                    Bitmap paddedImage = new Bitmap(newWidth, newHeight);

                    // Make sure the bitmap supports transparency
                    paddedImage.MakeTransparent();

                    using (Graphics g = Graphics.FromImage(paddedImage))
                    {
                        // Set the background to transparent
                        g.Clear(Color.Transparent);

                        // Draw the original image onto the padded image, centered with padding
                        g.DrawImage(originalImage, padding, padding, originalImage.Width, originalImage.Height);
                    }

                    return paddedImage;
                }
            }

            // Return a default image or null if the brand image is not found
            return null; // Or return a default image: return Image.FromFile("default_image_path");
        }
    }
}
