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

namespace ADCoursework1.GUI.Customer.Controller.DashboardCustomer
{
    public partial class MostPurchasedBrand : UserControl
    {
        public MostPurchasedBrand()
        {
            InitializeComponent();
            LoadMostPurchasedBrand();
        }

        private void LoadMostPurchasedBrand()
        {
            if (!SessionManager.IsLoggedIn || SessionManager.UserRole != "Customer")
            {
                MessageBox.Show("Access Denied. You must be logged in as a customer.");
                return;
            }

            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            // Retrieve the most purchased brand and its image
            var brandInfo = GetMostPurchasedBrand(customerId);

            if (brandInfo.HasValue)
            {
                var (brandName, imagePath) = brandInfo.Value;
                LblBrand.Text = brandName;
                LoadBrandImage(imagePath);
            }
            else
            {
                LblBrand.Text = "No Purchases Yet";
                PicBoxBrand.Image = null; // You might want to set a default image here
            }
        }

        private (string BrandName, string ImagePath)? GetMostPurchasedBrand(int customerId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"
                    SELECT TOP 1 
                        vw.brand, 
                        b.image 
                    FROM Orders o
                    JOIN OrderItem oi ON o.order_id = oi.order_id
                    JOIN vw_ItemDetails vw ON oi.item_id = vw.item_id
                    JOIN Brand b ON vw.brand = b.brand_name
                    WHERE o.customer_id = @CustomerId AND o.status = 'Completed'
                    GROUP BY vw.brand, b.image
                    ORDER BY COUNT(oi.item_id) DESC";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string brandName = reader["brand"].ToString();
                            string imagePath = reader["image"].ToString();

                            return (brandName, imagePath);
                        }
                    }
                }
            }

            return null; // No brand found
        }

        private void LoadBrandImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    PicBoxBrand.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Set a default or placeholder image if no image path is found
                    // PicBoxBrand.Image = Properties.Resources.DefaultBrandImage; 
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as the image file not being found
                Console.WriteLine("Failed to load image: " + ex.Message);
                // PicBoxBrand.Image = Properties.Resources.DefaultBrandImage;
            }
        }
    }
}
