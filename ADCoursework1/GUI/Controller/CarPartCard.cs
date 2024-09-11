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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Controller
{
    public partial class CarPartCard : UserControl
    {
        public int CarPartId { get; set; }
        public int ItemId { get; set; }


        public CarPartCard()
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
                LoadPartImage(value);
            }
        }

        private void LoadPartImage(string imagePath)
        {
            Console.WriteLine("Loading image from path: " + imagePath);  // Log the path to debug
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    PicBoxCarPart.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Optionally, log when no path is provided
                    Console.WriteLine("No image path provided.");
                }
            }
            catch (Exception ex)
            {
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

        // Property for Car Part Name
        private string _carpartname;
        public string CarPartName
        {
            get { return _carpartname; }
            set
            {
                _carpartname = value;
                LblPartName.Text = value;
            }
        }

        // Property for Car Part Name
        private string _partnumber;
        public string PartNumber
        {
            get { return _partnumber; }
            set
            {
                _partnumber = value;
                LblPartNo.Text = value;
            }
        }

        // Property for Part Price
        private string _partprice;
        public string PartPrice
        {
            get { return _partprice; }
            set
            {
                _partprice = value;
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

        private void AddItemToCart()
        {
            int itemId = GetItemIdFromCarPart();

            if (itemId > 0)
            {
                // Retrieve the CustomerId using the UserId
                int customerId = GetCustomerIdFromUserId(SessionManager.UserId);

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


        // Method to Retrieve ItemId
        private int GetItemIdFromCarPart()
        {
            if (this.CarPartId > 0)
            {
                string sql = "SELECT item_id FROM CarPart WHERE car_part_id = @CarPartId";
                SqlParameter[] parameters = { new SqlParameter("@CarPartId", this.CarPartId) };

                Console.WriteLine($"Executing SQL: {sql} with CarPartId: {this.CarPartId}");

                object result = DatabaseHelper.ExecuteScalar(sql, parameters);

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return -1;
        }

        private int GetCustomerIdFromUserId(int userId)
        {
            string sql = "SELECT customer_id FROM Customers WHERE user_id = @UserId";
            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId)
            };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return -1; // Return -1 or throw an exception if CustomerId is not found
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

                // Retrieve the item_id from the Item table corresponding to the car part
                int itemId = GetItemIdFromCarPart(); // Implement this method to get itemId based on CarPartId

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
            SingleCarPart singleCarPartForm = new SingleCarPart(this.CarPartId);
            singleCarPartForm.ShowDialog();
        }
    }
}