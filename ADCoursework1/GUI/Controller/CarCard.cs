using ADCoursework1.Entities;
using ADCoursework1.GUI.Customer;
using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using Guna.UI2.WinForms;
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
    public partial class CarCard : UserControl
    {
        public int CarId { get; set; }
        public int ItemId { get; set; } // Added ItemId Property

        public CarCard()
        {
            InitializeComponent();

            // Enable double buffering To stop screen flickering 
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        // Property for Image
        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                LoadImage(value);
            }
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    // If the imagePath is a file path
                    PicBoxCar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // If not specified, use a default image
                    //pictureBoxCar.Image = Properties.Resources.DefaultImage; // Make sure this resource is added to your project
                }
            }
            catch (Exception ex)
            {
                // Log the error or display a default error image
                //pictureBoxCar.Image = Properties.Resources.DefaultImage; // Fallback if image fails to load
                Console.WriteLine("Failed to load image: " + ex.Message);
            }
        }

        // Property for Brand
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
                LblBrand.Text = value; 
            }
        }

        // Property for Model
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                LblModel.Text = value; 
            }
        }

        // Property for Year
        private string _year;
        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                LblYear.Text = value; 
            }
        }

        // Property for Price
        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                LblPrice.Text = "$" + value; 
            }
        }


        // Property for ItemId (to identify the car in the database)

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (SessionManager.IsLoggedIn)
            {
                // User is logged in, add the item to the cart
                AddItemToCart();
            }
            else
            {
                // User is not logged in, open the login form
                OpenLoginForm();
            }
        }

        // Method to Add Item to Cart
        private void AddItemToCart()
        {
            int itemId = GetItemIdFromCar();

            if (itemId > 0)
            {
                // Retrieve the CustomerId using the UserId
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                if (customerId > 0)
                {
                    // Retrieve the current quantity from the database or start at 1
                    int quantity = 1;

                    Cart cart = new Cart
                    {
                        CustomerId = customerId,
                        ItemId = itemId,
                        Quantity = quantity
                    };

                    cart.AddToCart();

                    // Show success alert
                    Home.ShowAlert("Item added to cart successfully.", Alert.AlertType.Success);

                    // Update the cart item count on the home page
                    UpdateCartItemCountOnHomePage();
                }
                else
                {
                    // Show error alert for Customer ID issue
                    Home.ShowAlert("Failed to find Customer ID.", Alert.AlertType.Error);
                }
            }
            else
            {
                // Show error alert for Item ID issue
                Home.ShowAlert("Failed to find item ID.", Alert.AlertType.Error);
            }
        }

        // Method to update the cart item count on the home page
        private void UpdateCartItemCountOnHomePage()
        {
            Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.UpdateCartItemCount();
            }
        }

        // Method to Retrieve ItemId
        private int GetItemIdFromCar()
        {
            if (this.CarId > 0)
            {
                string sql = "SELECT item_id FROM Car WHERE car_id = @CarId";
                SqlParameter[] parameters = { new SqlParameter("@CarId", this.CarId) };

                Console.WriteLine($"Executing SQL: {sql} with CarId: {this.CarId}");

                object result = DatabaseHelper.ExecuteScalar(sql, parameters);

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return -1;
        }

        private void OpenLoginForm()
        {
            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Login was successful, try adding the item to the cart again
                    AddItemToCart();
                }
            }
        }

        private async void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn)
            {
                // Show login form if the user is not logged in
                Login login = new Login();
                login.ShowDialog();

                if (!SessionManager.IsLoggedIn)  // Check again after attempting login
                    return;
            }

            // Check if the logged-in user is an admin
            if (SessionManager.UserRole == "Admin")
            {
                // Show error alert for admin attempting to place an order
                Home.ShowAlert("Orders can only be placed by customers. Please log in as a customer to place an order.", Alert.AlertType.Info);
                return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                // Retrieve the item_id from the Item table corresponding to the carId
                int itemId = GetItemIdFromCar(); // Implement this method to get itemId based on carId or partId

                // Ensure item_id is valid
                if (itemId <= 0)
                {
                    throw new Exception("Invalid item ID. Cannot place order.");
                }

                // Retrieve the current quantity from the database or start at 1
                int quantity = 1;

                Cart cart = new Cart
                {
                    CustomerId = customerId,
                    ItemId = itemId,
                    Quantity = quantity
                };

                cart.AddToCart();

                // Show success alert
                Home.ShowAlert("Item added to cart successfully.", Alert.AlertType.Success);

                // Wait for the alert to be visible for 2 seconds
                await Task.Delay(2000);

                // Redirect to the cart tab/page within the customer dashboard
                CartHelper.RedirectToCartPage();
            }
            catch (Exception ex)
            {
                Home.ShowAlert("Error placing order: " + ex.Message, Alert.AlertType.Error);
            }
        }

        private void BtnViewMore_Click(object sender, EventArgs e)
        {
            SingleCar singleCarForm = new SingleCar(this.CarId);
            singleCarForm.ShowDialog();
        }
    }
}
