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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ADCoursework1.GUI.Customer.Controller
{
    public partial class ViewCart : UserControl
    {
        public ViewCart()
        {
            InitializeComponent();
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }
        
        private void LoadCartItems()
        {
            flwPnlCart.Controls.Clear();  // Clear the existing controls in the FlowLayoutPanel

            decimal totalAmount = 0;

            // Load Car Cart Items and add their total to totalAmount
            totalAmount += LoadCarCartItems();

            // Load Car Part Cart Items and add their total to totalAmount
            totalAmount += LoadCarPartCartItems();

            // Update the total label with the final amount
            LblTotal.Text = $"Total: ${totalAmount:F2}";
        }


        // Usage of VIEW for vw_CarCartDetails
        private decimal LoadCarCartItems()
        {
            flwPnlCart.SuspendLayout(); // Suspend layout to prevent flickering

            // Retrieve the CustomerId using the UserId from SessionManager
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            decimal totalAmount = 0;

            if (customerId > 0)
            {
                string sql = "SELECT * FROM vw_CarCartDetails WHERE customer_id = @CustomerId";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerId", customerId)  // Use the CustomerId retrieved
                };

                DataTable carCartTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

                foreach (DataRow row in carCartTable.Rows)
                {
                    decimal price = Convert.ToDecimal(row["price"]);
                    int quantity = Convert.ToInt32(row["quantity"]);
                    decimal itemTotal = price * quantity;
                    totalAmount += itemTotal;

                    CarCartItem carCartItem = new CarCartItem(flwPnlCart)  // Pass the parent panel here
                    {
                        CartId = Convert.ToInt32(row["cart_id"]),
                        CarId = Convert.ToInt32(row["car_id"]),
                        Brand = row["brand_name"].ToString(),
                        Model = row["model"].ToString(),
                        Year = row["year"].ToString(),
                        Price = price.ToString("F2"),
                        Quantity = quantity,
                        ImagePath = row["image"].ToString()
                    };

                    flwPnlCart.Controls.Add(carCartItem);
                }
            }
            else
            {
                // Show error alert for Item ID issue
                Home.ShowAlert("Failed to find Customer ID.", Alert.AlertType.Error);
            }

            flwPnlCart.ResumeLayout(); // Resume layout after all items are added

            return totalAmount; // Return the calculated total for car part items
        }



        private decimal LoadCarPartCartItems()
        {
            flwPnlCart.SuspendLayout(); // Suspend layout to prevent flickering

            // Retrieve the CustomerId using the UserId from SessionManager
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            decimal totalAmount = 0;

            if (customerId > 0)
            {
                // Use the view instead of joining tables directly
                string sql = "SELECT * FROM vw_CarPartCartDetails WHERE customer_id = @CustomerId";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerId", customerId)  // Use the CustomerId retrieved
                };

                DataTable carPartCartTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

                foreach (DataRow row in carPartCartTable.Rows)
                {
                    decimal partPrice = Convert.ToDecimal(row["part_price"]);
                    int quantity = Convert.ToInt32(row["quantity"]);
                    decimal itemTotal = partPrice * quantity;
                    totalAmount += itemTotal;

                    CarPartCartItem carPartCartItem = new CarPartCartItem(flwPnlCart)  // Pass the parent panel here
                    {
                        CartId = Convert.ToInt32(row["cart_id"]),
                        CarPartId = Convert.ToInt32(row["car_part_id"]),
                        Brand = row["brand_name"].ToString(),
                        CarPartName = row["car_part_name"].ToString(),
                        PartNumber = row["part_number"].ToString(),
                        PartPrice = partPrice.ToString("F2"),
                        Quantity = quantity,
                        ImagePath = row["image"].ToString()
                    };

                    flwPnlCart.Controls.Add(carPartCartItem);
                }
            }
            else
            {
                // Show error alert for Item ID issue
                Home.ShowAlert("Failed to find Customer ID.", Alert.AlertType.Error);
            }

            flwPnlCart.ResumeLayout(); // Resume layout after all items are added

            return totalAmount; // Return the calculated total for car part items
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
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
                // Show error alert for Item ID issue
                Home.ShowAlert("Orders can only be placed by customers. Please log in as a customer to place an order.", Alert.AlertType.Info);
                return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                // Retrieve all items in the cart for the logged-in customer
                List<CartItem> cartItems = CartHelper.GetCartItems(customerId); // Implement this method to get cart items from the database

                if (cartItems == null || cartItems.Count == 0)
                {
                    // Show error alert for Item ID issue
                    Home.ShowAlert("Your cart is empty.", Alert.AlertType.Info);
                    return;
                }

                // Create order items and calculate total price
                List<OrderItem> orderItems = new List<OrderItem>();
                decimal totalPrice = 0;

                foreach (var cartItem in cartItems)
                {
                    var orderItem = new OrderItem
                    {
                        ItemId = cartItem.ItemId,
                        Quantity = cartItem.Quantity,
                        Price = cartItem.Quantity * cartItem.ItemPrice
                    };
                    orderItems.Add(orderItem);
                    totalPrice += orderItem.Price;
                }

                // Modify the call to PlaceOrder to not pass totalPrice
                int orderId = Order.PlaceOrder(customerId, orderItems, DateTime.Now);

                // Clear the cart in the database
                CartHelper.ClearCart(customerId); // Implement this method to clear the cart in the database

                // Immediately refresh the cart UI to reflect the empty cart
                LoadCartItems();

                // Show error alert for Item ID issue
                Home.ShowAlert("Order placed successfully!", Alert.AlertType.Success);

                // Redirect to view orders tab
                CartHelper.RedirectCustomerToViewOrders();
            }
            catch (Exception ex)
            {
                // Show error alert for Item ID issue
                //Console.WriteLine("Error placing order: " + ex.Message);
                Home.ShowAlert("Error placing order: " + ex.Message, Alert.AlertType.Error);
            }
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn)
            {
                // Show login form if the user is not logged in
                Login login = new Login();
                login.ShowDialog();

                if (!SessionManager.IsLoggedIn)  // Check again after attempting login
                    return;
            }

            try
            {
                int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

                if (customerId > 0)
                {
                    // Clear the cart in the database
                    CartHelper.ClearCart(customerId);

                    // Immediately refresh the cart UI to reflect the empty cart
                    LoadCartItems();

                    // Show error alert for Item ID issue
                    Home.ShowAlert("Cart cleared successfully!", Alert.AlertType.Success);
                }
                else
                {
                    // Show error alert for Item ID issue
                    Home.ShowAlert("Failed to find Customer ID.", Alert.AlertType.Error);
                }
            }
            catch (Exception ex)
            {
                // Show error alert for Item ID issue
                Home.ShowAlert("Error clearing cart: " + ex.Message, Alert.AlertType.Error);
            }
        }
    }
}
