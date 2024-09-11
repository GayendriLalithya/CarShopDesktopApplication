using ADCoursework1.Entities;
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

namespace ADCoursework1.GUI.Forms
{
    public partial class SingleCar : Form
    {
        private int CarId;

        public SingleCar(int carId)
        {
            InitializeComponent();
            this.CarId = carId;
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            string sql = @"
            SELECT c.model, b.brand_name, c.year, c.price, c.description, c.image
            FROM Car c
            INNER JOIN Brand b ON c.brand_id = b.brand_id
            WHERE c.car_id = @CarId";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CarId", CarId)
            };

            DataTable carDetails = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (carDetails.Rows.Count > 0)
            {
                DataRow row = carDetails.Rows[0];

                LblCarName.Text = $"{row["brand_name"]} {row["model"]}";
                LblYear.Text = row["year"].ToString();
                LblDescription.Text = row["description"].ToString();
                LblPrice.Text = $"${row["price"].ToString()}";
                LoadCarImage(row["image"].ToString());
            }
            else
            {
                MessageBox.Show("Car details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    PicBoxCar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Set a default image if the path is empty or null
                    //PicBoxCar.Image = Properties.Resources.DefaultImage; // Make sure you have a default image in your resources
                }
            }
            catch (Exception ex)
            {
                // Log the error and set a fallback image
                Console.WriteLine("Failed to load car image: " + ex.Message);
                //PicBoxCar.Image = Properties.Resources.DefaultImage; // Use the default image as a fallback
            }
        }

        private async void BtnAddToCart_Click(object sender, EventArgs e)
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
                // Show error alert for admin attempting to add to cart
                Home.ShowAlert("Admins cannot add items to the cart.", Alert.AlertType.Info);
                return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                // Retrieve the item_id from the Item table corresponding to the carId
                int itemId = GetItemIdFromCar();

                // Ensure item_id is valid
                if (itemId <= 0)
                {
                    throw new Exception("Invalid item ID. Cannot add to cart.");
                }

                // Retrieve the current quantity from the database or start at 1
                //int quantity = 1;

                // Get the quantity from the NumericUpDown control
                int quantity = (int)NmrcUpDwnQuantity.Value;

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
            }
            catch (Exception ex)
            {
                Home.ShowAlert("Error adding item to cart: " + ex.Message, Alert.AlertType.Error);
            }
        }

        private async void BtnQuickOrder_Click(object sender, EventArgs e)
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
                Home.ShowAlert("Admins cannot place orders.", Alert.AlertType.Info);
                return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                // Retrieve the item_id from the Item table corresponding to the carId
                int itemId = GetItemIdFromCar();

                // Ensure item_id is valid
                if (itemId <= 0)
                {
                    throw new Exception("Invalid item ID. Cannot place order.");
                }

                // Retrieve the current quantity from the database or start at 1
                //int quantity = 1;

                // Get the quantity from the NumericUpDown control
                int quantity = (int)NmrcUpDwnQuantity.Value;

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
    }
}
