using ADCoursework1.Entities;
using ADCoursework1.GUI.Admin.Recover;
using ADCoursework1.GUI.Forms;
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

namespace ADCoursework1.GUI.Controller
{
    public partial class ManageBrand : UserControl
    {
        public ManageBrand()
        {
            InitializeComponent();
            LoadBrands();
            DataGridViewHelper.AddButtonsToBrandGrid(this, DgvBrands, "colBtnUpdate", "colBtnDelete");
        }

        public void ReloadGrid()
        {
            LoadBrands();
        }

        private void LoadBrands(string searchBrand = "")
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the size of the columns
            DgvBrands.Columns["colBtnUpdate"].Width = 80;
            DgvBrands.Columns["colBtnDelete"].Width = 80;

            // Set the row height
            DgvBrands.RowTemplate.Height = 80;

            // Base SQL query to select brand data
            string sql = "SELECT brand_id, brand_name, image FROM Brand WHERE deleted = 0";

            // List to hold SQL parameters
            List<SqlParameter> parameters = new List<SqlParameter>();

            // If a search term is provided, add a WHERE clause and parameter
            if (!string.IsNullOrEmpty(searchBrand))
            {
                sql += " WHERE LOWER(brand_name) LIKE LOWER(@SearchBrand)";
                parameters.Add(new SqlParameter("@SearchBrand", "%" + searchBrand.ToLower() + "%"));
            }

            // Fetch data from the database, passing the parameters array
            DataTable brandTable = DatabaseHelper.ExecuteDataTable(sql, parameters.ToArray());

            if (brandTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvBrands.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in brandTable.Rows)
                {
                    Image brandImage = null;
                    if (!string.IsNullOrEmpty(row["image"].ToString()))
                    {
                        string imagePath = row["image"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            brandImage = Image.FromFile(imagePath);
                            // Resize the image to fit within the row height
                            brandImage = DataGridViewHelper.ResizeImageWithPadding(brandImage, DgvBrands.RowTemplate.Height, 5);
                        }
                    }

                    DgvBrands.Rows.Add(
                        row["brand_id"],
                        row["brand_name"],
                        brandImage, // Assign the resized Image object here
                        "",  // Text for the Update button
                        ""  // Text for the Delete button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToBrandGrid(this, DgvBrands, "colBtnUpdate", "colBtnDelete");
        }

        private void RemoveAllButtons()
        {
            var buttonsToRemove = DgvBrands.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().ToList();
            foreach (var btn in buttonsToRemove)
            {
                DgvBrands.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void BtnAddBrand_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddBrand form
            using (BrandForm addBrandForm = new BrandForm())
            {
                // Show the modal with dimming effect
                ModalHelper.ShowModalWithMaximizedDimming(addBrandForm);
                ReloadGrid();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchBrand = TbSearchBrand.Text.Trim();

            // Reload the grid with the search term
            LoadBrands(searchBrand);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            TbSearchBrand.Clear();
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            using (BrandArchive brandArchive = new BrandArchive())
            {
                ModalHelper.ShowModalWithMaximizedDimming(brandArchive);
            }
        }
    }
}
