using ADCoursework1.Entities;
using ADCoursework1.GUI.Controller;
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

namespace ADCoursework1.GUI
{
    public partial class ViewMoreItem : Form
    {
        private bool isCar;
        private List<Car> cars; // Store all cars fetched from the database
        private List<CarPart> carParts; // Store all car parts fetched from the database

        public ViewMoreItem(bool _isCar)
        {
            InitializeComponent();
            isCar = _isCar; // Corrected the assignment
            LoadBrands();  // Load the brands into the ComboBox
            LoadItems();   // Load cars or car parts based on the isCar flag
            LoadPriceRanges();  // Load the appropriate price ranges

            // Add event handlers for filtering
            CmbBrand.SelectedIndexChanged += CmbBrand_SelectedIndexChanged;
            CmbPriceRange.SelectedIndexChanged += CmbPriceRange_SelectedIndexChanged;
        }

        private void LoadBrands()
        {
            ComboBoxHelper.LoadBrandsIntoComboBox(CmbBrand); 
        }

        private void LoadItems()
        {
            if (isCar)
            {
                LoadCarsIntoFlowLayout();
            }
            else
            {
                LoadCarPartsIntoFlowLayout();
            }
        }

        private void LoadCarsIntoFlowLayout()
        {
            // Fetch all cars from the database
            cars = Car.GetAllCars();

            // Initially display all cars
            DisplayFilteredCars(cars);
        }

        private void LoadCarPartsIntoFlowLayout()
        {
            // Fetch all car parts from the database
            carParts = CarPart.GetAllCarParts();

            // Initially display all car parts
            DisplayFilteredCarParts(carParts);
        }

        private void LoadPriceRanges()
        {
            if (isCar)
            {
                ComboBoxHelper.LoadPriceRangesIntoComboBox(CmbPriceRange); 
            }
            else
            {
                ComboBoxHelper.LoadCarPartPriceRangesIntoComboBox(CmbPriceRange);
            }
        }

        private void CmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFiltering();
        }

        private void CmbPriceRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFiltering();
        }

        private void ApplyFiltering()
        {
            if (isCar)
            {
                var filteredCars = FilterCars(TbSearch.Text.Trim());
                DisplayFilteredCars(filteredCars);
            }
            else
            {
                var filteredCarParts = FilterCarParts(TbSearch.Text.Trim());
                DisplayFilteredCarParts(filteredCarParts);
            }
        }

        private List<Car> FilterCars(string searchTerm)
        {
            var filteredCars = cars.AsEnumerable();

            // Brand Filtering
            string selectedBrand = CmbBrand.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedBrand) && selectedBrand != "All")
            {
                filteredCars = filteredCars.Where(car => car.BrandId.ToString() == selectedBrand);
            }

            // Price Filtering
            string selectedPriceRange = CmbPriceRange.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedPriceRange) && selectedPriceRange != "0-1000000")
            {
                try
                {
                    var priceRangeParts = selectedPriceRange.Split('-');
                    if (priceRangeParts.Length == 2 &&
                        decimal.TryParse(priceRangeParts[0].Trim(), out decimal minPrice) &&
                        decimal.TryParse(priceRangeParts[1].Trim(), out decimal maxPrice))
                    {
                        filteredCars = filteredCars.Where(car => car.Price >= minPrice && car.Price <= maxPrice);
                    }
                    else
                    {
                        // Handle case where price range format is incorrect
                        MessageBox.Show("Invalid price range format. Please ensure it is in the format 'min-max'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while parsing the price range: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Search Filtering
            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredCars = filteredCars.Where(car =>
                    car.Model.ToLower().Contains(searchTerm.ToLower()) ||
                    $"{car.Brand} {car.Model}".ToLower().Contains(searchTerm.ToLower()));
            }

            return filteredCars.ToList();
        }

        private List<CarPart> FilterCarParts(string searchTerm)
        {
            var filteredCarParts = carParts.AsEnumerable();

            // Brand Filtering
            string selectedBrand = CmbBrand.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedBrand) && selectedBrand != "All")
            {
                filteredCarParts = filteredCarParts.Where(part => part.BrandId.ToString() == selectedBrand);
            }

            // Price Filtering
            string selectedPriceRange = CmbPriceRange.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedPriceRange) && selectedPriceRange != "0-100000")
            {
                try
                {
                    var priceRangeParts = selectedPriceRange.Split('-');
                    if (priceRangeParts.Length == 2 &&
                        decimal.TryParse(priceRangeParts[0].Trim(), out decimal minPrice) &&
                        decimal.TryParse(priceRangeParts[1].Trim(), out decimal maxPrice))
                    {
                        filteredCarParts = filteredCarParts.Where(part => part.PartPrice >= minPrice && part.PartPrice <= maxPrice);
                    }
                    else
                    {
                        // Handle case where price range format is incorrect
                        MessageBox.Show("Invalid price range format. Please ensure it is in the format 'min-max'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while parsing the price range: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Search Filtering
            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredCarParts = filteredCarParts.Where(part =>
                    part.CarPartName.ToLower().Contains(searchTerm.ToLower()) ||
                    part.PartNumber.ToLower().Contains(searchTerm.ToLower()) ||
                    part.BrandName.ToLower().Contains(searchTerm.ToLower()));
            }

            return filteredCarParts.ToList();
        }

        private void DisplayFilteredCars(List<Car> filteredCars)
        {
            flwLayoutPanel.Controls.Clear();  // Clear the existing controls in the panel

            foreach (var car in filteredCars)
            {
                CarCard carCard = new CarCard
                {
                    CarId = car.CarId ?? 0, // Set the CarId
                    ItemId = car.ItemId ?? 0, // Set the ItemId
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year.ToString(),
                    Price = car.Price.ToString("N2"),
                    ImagePath = car.Image
                };
                flwLayoutPanel.Controls.Add(carCard);
            }
        }

        private void DisplayFilteredCarParts(List<CarPart> filteredCarParts)
        {
            flwLayoutPanel.Controls.Clear();  // Clear the existing controls in the panel

            foreach (var carPart in filteredCarParts)
            {
                CarPartCard carPartCard = new CarPartCard
                {
                    CarPartId = carPart.CarPartId ?? 0, // Set the CarPartId
                    ItemId = carPart.ItemId ?? 0, // Set the ItemId
                    Brand = carPart.BrandName,
                    CarPartName = carPart.CarPartName,
                    PartNumber = carPart.PartNumber,
                    PartPrice = carPart.PartPrice.ToString("N2"),
                    ImagePath = carPart.Image
                };
                flwLayoutPanel.Controls.Add(carPartCard);
            }
        }

        private void ImgBtnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();  // Hide the dashboard page
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyFiltering();
        }
    }
}
