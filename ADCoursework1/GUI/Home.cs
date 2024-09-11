using ADCoursework1.GUI.Controller;
using ADCoursework1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADCoursework1.Helper;
using ADCoursework1.GUI.Admin;
using ADCoursework1.GUI.Customer;
using System.Configuration;
using System.Data.SqlClient;
using ADCoursework1.GUI.Forms;
using static ADCoursework1.GUI.Forms.Alert;

namespace ADCoursework1.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            InitializeHome();
        }

        private void InitializeHome()
        {
            UpdateLoginButton();

            // Check if the user is logged in
            if (!SessionManager.IsLoggedIn)
            {
                CricleBtnCartCount.Visible = false;  // Hide the button if not logged in
            }
            else
            {
                // Check if the logged-in user is a customer
                if (SessionManager.UserRole == "Customer")
                {
                    CricleBtnCartCount.Visible = true;  // Show the button if logged in as a customer
                    UpdateCartItemCount();  // Load and display the cart item count
                }
                else
                {
                    CricleBtnCartCount.Visible = false;  // Hide the button if logged in as an admin
                }
            }
        }


        public void UpdateCartItemCount()
        {
            // Only update the cart count if the user is a customer
            if (SessionManager.UserRole == "Customer")
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                if (customerId > 0)
                {
                    // Call the method from the Cart class to get the item count
                    int itemCount = Cart.GetCartItemCount(customerId);

                    // Set the CircleButton text to the item count
                    CricleBtnCartCount.Text = itemCount.ToString();
                }
                else
                {
                    CricleBtnCartCount.Text = "0";  // Set to 0 if customer ID is not found
                }
            }
        }

        private void LoadCarCards()
        {
            List<Car> cars = Car.GetAllCars();  // Fetch all cars
            flwPnlCar.Controls.Clear();  // Clear existing controls in the FlowLayoutPanel

            foreach (Car car in cars)
            {
                CarCard card = new CarCard();
                card.CarId = car.CarId ?? 0;  // Use 0 if car.CarId is null
                card.Brand = car.Brand;
                card.Model = car.Model;
                card.Year = car.Year.ToString();
                card.Price = $"${car.Price}";
                card.ImagePath = car.Image;  // Ensure this is the correct property from Car object
                flwPnlCar.Controls.Add(card);
            }
        }

        private void LoadBrandCards()
        {
            List<Brand> brands = Brand.GetAllBrands();  // Correct method call
            flwPnlBrand.Controls.Clear();  // Clear existing controls in the FlowLayoutPanel

            foreach (Brand brand in brands)
            {
                BrandCard card = new BrandCard();
                card.BrandName = brand.BrandName; 
                card.ImagePath = brand.Image;  // Correct property reference
                flwPnlBrand.Controls.Add(card);
            }
        }

        private void LoadCarPartCards()
        {
            List<CarPart> carParts = CarPart.GetAllCarParts();  // Fetch all car parts
            flwPnlCarPart.Controls.Clear();  // Clear existing controls in the FlowLayoutPanel

            foreach (CarPart carPart in carParts)
            {
                CarPartCard card = new CarPartCard();
                card.CarPartId = carPart.CarPartId ?? 0;
                card.Brand = carPart.BrandName;
                card.CarPartName = carPart.CarPartName;
                card.PartNumber = carPart.PartNumber;
                card.PartPrice = $"${carPart.PartPrice:N2}";  // Format price as currency with 2 decimal places
                card.ImagePath = carPart.Image;

                // Optionally, check if the image path is not null or empty before assigning
                if (!string.IsNullOrEmpty(carPart.Image))
                {
                    card.ImagePath = carPart.Image;
                }

                flwPnlCarPart.Controls.Add(card);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Explicit call to load cars if not triggering from SelectedIndexChanged
            LoadBrandCards();
            LoadCarCards();
            LoadCarPartCards();
        }

        private void BtnLoginOrDashboard_Click(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn)
            {
                RedirectToDashboard();
            }
            else
            {
                // Redirect to the login page
                Login loginPage = new Login();
                loginPage.Show();
            }

            this.Hide();  // Hide the current home page
        }

        private void UpdateLoginButton()
        {
            if (SessionManager.IsLoggedIn)
            {
                BtnLoginOrDashboard.Text = "Dashboard";
            }
            else
            {
                BtnLoginOrDashboard.Text = "Login";
            }
        }

        private void RedirectToDashboard()
        {
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);  // Ensure this method exists and is correct

            if (SessionManager.UserRole == "Admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else if (SessionManager.UserRole == "Customer")
            {
                CustomerDashboard customerDashboard = new CustomerDashboard(customerId);  // Now passing customerId
                customerDashboard.Show();
            }

            this.Hide(); // Optionally hide the HomePage
        }


        private void BtnCart_Click(object sender, EventArgs e)
        {
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            if (SessionManager.IsLoggedIn)
            {
                if (SessionManager.UserRole == "Customer")
                {
                    // Redirect to the customer dashboard and select the Cart tab
                    CustomerDashboard customerDashboard = new CustomerDashboard(customerId);
                    customerDashboard.Show();
                    customerDashboard.SelectTab("TbPageCart"); // Ensure "TbPageCart" matches the actual TabPage name
                }
                else if (SessionManager.UserRole == "Admin")
                {
                    // Display a message if the logged-in user is an admin
                    ShowAlert("Admins do not have a cart. Please log in as a customer to access the cart.", Alert.AlertType.Info);
                }
            }
            else
            {
                // If not logged in, open the login form
                Login loginPage = new Login();
                loginPage.Show();
            }
        }

        private void BtnViewMoreCar_Click(object sender, EventArgs e)
        {
            OpenViewMoreForm(isCar: true);
        }

        private void BtnViewMoreCarPart_Click(object sender, EventArgs e)
        {
            OpenViewMoreForm(isCar: false);
        }

        private void OpenViewMoreForm(bool isCar)
        {
            ViewMoreItem viewMoreForm = new ViewMoreItem(isCar);
            viewMoreForm.Show();

            this.Hide();
        }

        private void CtrlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void ShowAlert(string message, Alert.AlertType type)
        {
            Alert alertForm = new Alert();
            alertForm.ShowAlert(message, type);
        }
    }
}
