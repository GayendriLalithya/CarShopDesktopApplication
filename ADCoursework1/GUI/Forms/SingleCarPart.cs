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
    public partial class SingleCarPart : Form
    {
        private int CarPartId;

        public SingleCarPart(int carPartId)
        {
            InitializeComponent();
            this.CarPartId = carPartId;
            LoadCarPartDetails();
        }

        private void LoadCarPartDetails()
        {
            string sql = @"
            SELECT cp.car_part_name, b.brand_name, cp.part_number, cp.part_price, cp.description, cp.image
            FROM CarPart cp
            INNER JOIN Brand b ON cp.brand_id = b.brand_id
            WHERE cp.car_part_id = @CarPartId";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CarPartId", CarPartId)
            };

            DataTable carPartDetails = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (carPartDetails.Rows.Count > 0)
            {
                DataRow row = carPartDetails.Rows[0];

                LblCarPartName.Text = $"{row["brand_name"]} {row["car_part_name"]}";
                LblPartNo.Text = row["part_number"].ToString();
                LblDescription.Text = row["description"].ToString();
                LblPrice.Text = $"${row["part_price"].ToString()}";
                LoadCarPartImage(row["image"].ToString());
            }
            else
            {
                MessageBox.Show("Car part details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarPartImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    PicBoxCarPart.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Optionally load a default image or handle missing image path
                    //PicBoxCarPart.Image = Properties.Resources.DefaultImage; // Make sure you have a default image in your resources
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load image: " + ex.Message);
                // Optionally load a default image if there's an error loading the specified image
                //PicBoxCarPart.Image = Properties.Resources.DefaultImage;
            }
        }

        private async void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn)
            {
                Login login = new Login();
                login.ShowDialog();

                if (!SessionManager.IsLoggedIn)
                    return;
            }

            if (SessionManager.UserRole == "Admin")
            {
                Home.ShowAlert("Admins cannot add items to cart or place orders.", Alert.AlertType.Info);
                return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);
                int itemId = GetItemIdFromCarPart();

                if (itemId <= 0)
                {
                    throw new Exception("Invalid item ID. Cannot add to cart.");
                }

                // Get the quantity from the NumericUpDown control
                int quantity = (int)NmrcUpDwnQuantity.Value;

                Cart cart = new Cart
                {
                    CustomerId = customerId,
                    ItemId = itemId,
                    Quantity = quantity
                };

                cart.AddToCart();

                Home.ShowAlert("Item added to cart successfully.", Alert.AlertType.Success);

                await Task.Delay(2000);

                this.Close(); // Close the form after adding to cart
            }
            catch (Exception ex)
            {
                Home.ShowAlert("Error adding to cart: " + ex.Message, Alert.AlertType.Error);
            }
        }

        private async void BtnQuickOrder_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn)
            {
                Login login = new Login();
                login.ShowDialog();

                if (!SessionManager.IsLoggedIn)
                    return;
            }

            if (SessionManager.UserRole == "Admin")
            {
                Home.ShowAlert("Admins cannot add items to cart or place orders.", Alert.AlertType.Info);
                return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);
                int itemId = GetItemIdFromCarPart();

                if (itemId <= 0)
                {
                    throw new Exception("Invalid item ID. Cannot place order.");
                }

                // Get the quantity from the NumericUpDown control
                int quantity = (int)NmrcUpDwnQuantity.Value;

                Cart cart = new Cart
                {
                    CustomerId = customerId,
                    ItemId = itemId,
                    Quantity = quantity
                };

                cart.AddToCart();

                Home.ShowAlert("Item added to cart successfully.", Alert.AlertType.Success);

                await Task.Delay(2000);

                this.Close(); // Close the form after adding to cart

                CartHelper.RedirectToCartPage(); // Redirect to cart page after placing quick order
            }
            catch (Exception ex)
            {
                Home.ShowAlert("Error placing order: " + ex.Message, Alert.AlertType.Error);
            }
        }

        private int GetItemIdFromCarPart()
        {
            if (this.CarPartId > 0)
            {
                string sql = "SELECT item_id FROM CarPart WHERE car_part_id = @CarPartId";
                SqlParameter[] parameters = { new SqlParameter("@CarPartId", this.CarPartId) };

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
