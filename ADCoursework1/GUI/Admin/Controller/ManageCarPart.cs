using ADCoursework1.GUI.Admin.Recover;
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
    public partial class ManageCarPart : UserControl
    {
        public ManageCarPart()
        {
            InitializeComponent();
            LoadCarParts();
            LoadComboBoxes();
            DataGridViewHelper.AddButtonsToCarPartGrid(this, DgvCarParts, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        private void LoadComboBoxes()
        {
            ComboBoxHelper.LoadBrandsIntoComboBox(CmbBrand);
            ComboBoxHelper.LoadPriceRangesIntoComboBox(CmbPriceRange);

            // Attach event handlers to combo boxes
            CmbBrand.SelectedIndexChanged += ComboBox_SelectionChanged;
            CmbPriceRange.SelectedIndexChanged += ComboBox_SelectionChanged;
        }

        private void ComboBox_SelectionChanged(object sender, EventArgs e)
        {
            // Reload the cars when any combo box selection changes
            LoadCarParts();
        }

        public void ReloadGrid()
        {
            LoadCarParts();
        }

        private void LoadCarParts(string searchCarPart = "")
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the size of the columns
            DgvCarParts.Columns["colBtnUpdate"].Width = 80;
            DgvCarParts.Columns["colBtnDelete"].Width = 80;
            DgvCarParts.Columns["colBtnView"].Width = 80;

            // Set the row height
            DgvCarParts.RowTemplate.Height = 80;

            // Construct the SQL query with filters
            string sql = @"
                         SELECT 
                            cp.car_part_id, 
                            cp.car_part_name, 
                            b.brand_name, 
                            cp.part_number, 
                            cp.part_price, 
                            cp.image 
                         FROM CarPart cp
                         INNER JOIN Brand b ON cp.brand_id = b.brand_id
                         INNER JOIN Item i ON cp.item_id = i.item_id
                         WHERE i.deleted = 0";

            // List to hold SQL parameters
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add filters based on selected brand and price range
            if (CmbBrand.SelectedIndex > 0) // Index 0 is "All"
            {
                sql += " AND brand_id = @BrandID";
                parameters.Add(new SqlParameter("@BrandID", CmbBrand.SelectedValue));
            }

            if (CmbPriceRange.SelectedIndex > 0) // Index 0 is "All"
            {
                string[] priceRange = CmbPriceRange.SelectedValue.ToString().Split('-');
                sql += " AND part_price BETWEEN @PriceMin AND @PriceMax";
                parameters.Add(new SqlParameter("@PriceMin", priceRange[0]));
                parameters.Add(new SqlParameter("@PriceMax", priceRange[1]));
            }

            // If a search term is provided, add a WHERE clause and parameters
            if (!string.IsNullOrEmpty(searchCarPart))
            {
                sql += @"
                AND (LOWER(car_part_name) LIKE LOWER(@SearchCarPart) 
                OR LOWER((SELECT brand_name FROM Brand WHERE brand_id = CarPart.brand_id)) LIKE LOWER(@SearchCarPart) 
                OR LOWER(part_number) LIKE LOWER(@SearchCarPart))";

                parameters.Add(new SqlParameter("@SearchCarPart", "%" + searchCarPart.ToLower() + "%"));
            }

            // Fetch data from the database
            DataTable carPartTable = DatabaseHelper.ExecuteDataTable(sql, parameters.ToArray());

            if (carPartTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvCarParts.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in carPartTable.Rows)
                {
                    Image carPartImage = null;
                    if (!string.IsNullOrEmpty(row["image"].ToString()))
                    {
                        string imagePath = row["image"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            carPartImage = Image.FromFile(imagePath);
                            // Resize the image to fit within the row height
                            carPartImage = DataGridViewHelper.ResizeImageWithPadding(carPartImage, DgvCarParts.RowTemplate.Height, 5);
                        }
                    }

                    DgvCarParts.Rows.Add(
                        row["car_part_id"],
                        row["car_part_name"],
                        row["brand_name"],
                        row["part_number"],
                        row["part_price"],
                        carPartImage, // Assign the resized Image object here
                        "",  // Icon for the Update button
                        "",  // Icon for the Delete button
                        ""   // Icon for the View button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToCarPartGrid(this, DgvCarParts, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        private void RemoveAllButtons()
        {
            var buttonsToRemove = DgvCarParts.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().ToList();
            foreach (var btn in buttonsToRemove)
            {
                DgvCarParts.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void BtnAddCarPart_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddCarPart form
            using (Forms.CarPartForm addCarPartForm = new Forms.CarPartForm())
            {
                // Show the modal with dimming effect
                ModalHelper.ShowModalWithMaximizedDimming(addCarPartForm);

                // Check the DialogResult to ensure the user was added/updated before reloading the grid
                if (addCarPartForm.DialogResult == DialogResult.OK)
                {
                    ReloadGrid(); // Reload the grid only after the form is closed and the operation is successful
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchCarPart = TbSearchCarPart.Text.Trim();

            // Reload the grid with the search term
            LoadCarParts(searchCarPart);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            TbSearchCarPart.Clear();
            CmbBrand.SelectedIndex = 0;
            CmbPriceRange.SelectedIndex = 0;
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            using (CarPartArchive carPartArchive = new CarPartArchive())
            {
                ModalHelper.ShowModalWithMaximizedDimming(carPartArchive);
            }
        }
    }
}
