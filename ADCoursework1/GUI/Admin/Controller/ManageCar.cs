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
    public partial class ManageCar : UserControl
    {
        public ManageCar()
        {
            InitializeComponent();
            LoadCars();
            LoadComboBoxes();
            DataGridViewHelper.AddButtonsToCarGrid(this, DgvCars, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        private void LoadComboBoxes()
        {
            ComboBoxHelper.LoadBrandsIntoComboBox(CmbBrand);
            ComboBoxHelper.LoadYearsIntoComboBox(CmbYear);
            ComboBoxHelper.LoadPriceRangesIntoComboBox(CmbPriceRange);

            // Attach event handlers to combo boxes
            CmbBrand.SelectedIndexChanged += ComboBox_SelectionChanged;
            CmbYear.SelectedIndexChanged += ComboBox_SelectionChanged;
            CmbPriceRange.SelectedIndexChanged += ComboBox_SelectionChanged;
        }

        private void ComboBox_SelectionChanged(object sender, EventArgs e)
        {
            // Reload the cars when any combo box selection changes
            LoadCars();
        }

        public void ReloadGrid()
        {
            LoadCars();
        }

        private void LoadCars(string searchCar = "")
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the size of the columns
            DgvCars.Columns["colBtnUpdate"].Width = 80;
            DgvCars.Columns["colBtnDelete"].Width = 80;
            DgvCars.Columns["colBtnView"].Width = 80;

            // Set the row height
            DgvCars.RowTemplate.Height = 80;

            // Construct the SQL query with filters
            string sql = @"
                         SELECT 
                            c.car_id, 
                            b.brand_name, 
                            c.model, 
                            c.year, 
                            c.price, 
                            c.image 
                         FROM Car c
                         INNER JOIN Brand b ON c.brand_id = b.brand_id
                         INNER JOIN Item i ON c.item_id = i.item_id
                         WHERE i.deleted = 0";

            // List to hold SQL parameters
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add filters based on selected brand, year, and price range
            if (CmbBrand.SelectedIndex > 0) // Index 0 is "All"
            {
                sql += " AND brand_id = @BrandID";
                parameters.Add(new SqlParameter("@BrandID", CmbBrand.SelectedValue));
            }

            if (CmbYear.SelectedIndex > 0) // Index 0 is "All"
            {
                sql += " AND year = @Year";
                parameters.Add(new SqlParameter("@Year", CmbYear.SelectedValue));
            }

            if (CmbPriceRange.SelectedIndex > 0) // Index 0 is "All"
            {
                string[] priceRange = CmbPriceRange.SelectedValue.ToString().Split('-');
                sql += " AND price BETWEEN @PriceMin AND @PriceMax";
                parameters.Add(new SqlParameter("@PriceMin", priceRange[0]));
                parameters.Add(new SqlParameter("@PriceMax", priceRange[1]));
            }

            // If a search term is provided, add a WHERE clause and parameters
            if (!string.IsNullOrEmpty(searchCar))
            {
                sql += " AND (LOWER(model) LIKE LOWER(@SearchCar) OR LOWER(CONCAT((SELECT brand_name FROM Brand WHERE brand_id = Car.brand_id), ' ', model)) LIKE LOWER(@SearchCar))";
                parameters.Add(new SqlParameter("@SearchCar", "%" + searchCar.ToLower() + "%"));
            }

            // Fetch data from the database
            DataTable carTable = DatabaseHelper.ExecuteDataTable(sql, parameters.ToArray());

            if (carTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvCars.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in carTable.Rows)
                {
                    Image carImage = null;
                    if (!string.IsNullOrEmpty(row["image"].ToString()))
                    {
                        string imagePath = row["image"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            carImage = Image.FromFile(imagePath);
                            // Resize the image to fit within the row height
                            carImage = DataGridViewHelper.ResizeImageWithPadding(carImage, DgvCars.RowTemplate.Height, 5);
                        }
                    }

                    DgvCars.Rows.Add(
                        row["car_id"],
                        row["brand_name"],
                        row["model"],
                        row["year"],
                        row["price"],
                        carImage, // Assign the resized Image object here
                        "",  // Text for the Update button
                        "",   // Text for the Delete button
                        ""   // Text for the View button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToCarGrid(this, DgvCars, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        private void RemoveAllButtons()
        {
            var buttonsToRemove = DgvCars.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().ToList();
            foreach (var btn in buttonsToRemove)
            {
                DgvCars.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddCar form
            using (Forms.CarForm addCarForm = new Forms.CarForm())
            {
                // Show the modal with dimming effect
                ModalHelper.ShowModalWithMaximizedDimming(addCarForm);
                ReloadGrid();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchCar = TbSearchCar.Text.Trim();

            // Reload the grid with the search term
            LoadCars(searchCar);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            TbSearchCar.Clear();
            CmbBrand.SelectedIndex = 0;
            CmbYear.SelectedIndex = 0;
            CmbPriceRange.SelectedIndex = 0;
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            using (CarArchive carArchive = new CarArchive())
            {
                ModalHelper.ShowModalWithMaximizedDimming(carArchive);
            }
        }
    }
}
