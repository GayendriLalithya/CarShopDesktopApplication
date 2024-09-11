using ADCoursework1.Entities;
using ADCoursework1.GUI;
using ADCoursework1.GUI.Admin.Controller;
using ADCoursework1.GUI.Admin.Forms;
using ADCoursework1.GUI.Controller;
using ADCoursework1.GUI.Customer.Controller;
using ADCoursework1.GUI.Customer.Forms;
using ADCoursework1.GUI.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.Helper
{
    internal class DataGridViewHelper
    {
        // Method to resize image with padding
        public static Image ResizeImageWithPadding(Image image, int rowHeight, int padding)
        {
            // Calculate the new height for the image based on the row height and padding
            int newHeight = rowHeight - 2 * padding; // Adjust height based on padding

            // Calculate the new width while maintaining the aspect ratio
            int newWidth = (int)((float)newHeight / image.Height * image.Width);

            // Create a new bitmap with the calculated width and height
            Bitmap bmp = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent); // Optional: Set the background color to transparent

                // Draw the image centered within the new dimensions
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return bmp;
        }

        public static void AddButtonWithEvents(DataGridView dgv, DataGridViewRow row, string columnName, Action<int> onClickAction, Image buttonImage, Color buttonColor)
        {
            // Create and configure the Guna2Button
            Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
            button.Size = new Size(45, 45);
            button.FillColor = buttonColor;
            button.BorderRadius = 5;
            button.Image = buttonImage;
            button.Cursor = Cursors.Hand; // Set the cursor to hand

            // Align button to center of cell
            Rectangle rect = dgv.GetCellDisplayRectangle(row.Cells[columnName].ColumnIndex, row.Index, true);
            button.Location = new Point(rect.X + (rect.Width - button.Width) / 2, rect.Y + (rect.Height - button.Height) / 2);

            // Wire up the click event handler
            button.Click += (s, e) => onClickAction(row.Index);

            // Add the button to the DataGridView's parent control (e.g., the form)
            dgv.Controls.Add(button);
        }

        // Brand Grid Button
        public static void AddButtonsToBrandGrid(ManageBrand manageBrandControl, DataGridView dgv, string updateColumnBrand, string deleteColumnBrand)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the Update button
                AddButtonWithEvents(
                    dgv,
                    row,
                    updateColumnBrand,
                    (rowIndex) =>
                    {
                        // Logic for updating a brand
                        int brandId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colBrandID"].Value);

                        // Open the BrandForm in update mode
                        using (BrandForm brandForm = new BrandForm(true, brandId))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(brandForm);
                        }

                        // Reload the grid after update
                        manageBrandControl.ReloadGrid();
                    },
                    global::ADCoursework1.Properties.Resources.edit_white,
                    System.Drawing.SystemColors.Highlight
                );

                // Add the Delete button
                AddButtonWithEvents(
                    dgv,
                    row,
                    deleteColumnBrand,
                    (rowIndex) =>
                    {
                        // Confirm before deletion
                        if (MessageBox.Show("Are you sure you want to delete this brand?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int brandId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colBrandID"].Value);
                            Brand.DeleteBrandTemp(brandId); // Call the delete method

                            // Reload the grid after deletion
                            manageBrandControl.ReloadGrid();

                            GUI.Home.ShowAlert("Brand deleted successfully.", Alert.AlertType.Success);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.detete_white,
                    System.Drawing.Color.Red
                );
            }
        }

        // Car Grid Button
        public static void AddButtonsToCarGrid(ManageCar manageCarControl, DataGridView dgv, string updateColumnName, string deleteColumnName, string viewColumnName)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the Update button
                AddButtonWithEvents(
                    dgv,
                    row,
                    updateColumnName,
                    (rowIndex) =>
                    {
                        // Logic for updating a car
                        int carId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colCarID"].Value);

                        // Open the CarForm in update mode
                        using (CarForm carForm = new CarForm(true, carId))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(carForm);
                        }

                        // Reload the grid after update
                        manageCarControl.ReloadGrid();
                    },
                    global::ADCoursework1.Properties.Resources.edit_white,
                    System.Drawing.SystemColors.Highlight
                );

                // Add the Delete button
                AddButtonWithEvents(
                    dgv,
                    row,
                    deleteColumnName,
                    (rowIndex) =>
                    {
                        // Confirm before deletion
                        if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int carId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colCarID"].Value);
                            Car.TemporaryDeleteCar(carId); // Call the delete method

                            // Reload the grid after deletion
                            manageCarControl.ReloadGrid();

                            GUI.Home.ShowAlert("Car deleted successfully.", Alert.AlertType.Success);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.detete_white,
                    System.Drawing.Color.Red
                );

                // Add the View button (if necessary)
                AddButtonWithEvents(
                    dgv,
                    row,
                    viewColumnName,
                    (rowIndex) =>
                    {
                        // Logic for updating a car
                        int carId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colCarID"].Value);

                        // Open the CarForm in view mode
                        using (CarForm carForm = new CarForm(isUpdateMode: false, carId: carId, isViewMode: true))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(carForm);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.view_white,
                    System.Drawing.Color.FromArgb(33, 42, 57)
                );
            }
        }

        // Car Part Grid Buttons
        public static void AddButtonsToCarPartGrid(ManageCarPart manageCarPartControl, DataGridView dgv, string updateColumnName, string deleteColumnName, string viewColumnName)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the Update button
                AddButtonWithEvents(
                    dgv,
                    row,
                    updateColumnName,
                    (rowIndex) =>
                    {
                        // Logic for updating a car part
                        int carPartId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colCarPartID"].Value);

                        // Open the CarPartForm in update mode
                        using (CarPartForm carPartForm = new CarPartForm(true, carPartId))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(carPartForm);
                        }

                        // Reload the grid after update
                        manageCarPartControl.ReloadGrid();
                    },
                    global::ADCoursework1.Properties.Resources.edit_white,
                    System.Drawing.SystemColors.Highlight
                );

                // Add the Delete button
                AddButtonWithEvents(
                    dgv,
                    row,
                    deleteColumnName,
                    (rowIndex) =>
                    {
                        // Confirm before deletion
                        if (MessageBox.Show("Are you sure you want to delete this car part?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int carPartId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colCarPartID"].Value);
                            CarPart.TemporaryDeleteCarPart(carPartId); // Call the delete method

                            // Reload the grid after deletion
                            manageCarPartControl.ReloadGrid();

                            GUI.Home.ShowAlert("Car Part deleted successfully.", Alert.AlertType.Success);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.detete_white,
                    System.Drawing.Color.Red
                );

                // Add the View button (if necessary)
                AddButtonWithEvents(
                    dgv,
                    row,
                    viewColumnName,
                    (rowIndex) =>
                    {
                        // Logic for updating a car part
                        int carPartId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colCarPartID"].Value);

                        // Open the CarPartForm in view mode
                        using (CarPartForm carPartForm = new CarPartForm(isUpdateMode: false, carPartId: carPartId, isViewMode: true))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(carPartForm);
                        }


                    },
                    global::ADCoursework1.Properties.Resources.view_white,
                    System.Drawing.Color.FromArgb(33, 42, 57)
                );
            }
        }

        // User Grid Buttons
        public static void AddButtonsToUserGrid(ManageUser manageUserControl, DataGridView dgv, string updateColumnName, string deleteColumnName, string viewColumnName)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the Update button
                AddButtonWithEvents(
                    dgv,
                    row,
                    updateColumnName,
                    (rowIndex) =>
                    {
                        // Logic for updating a user
                        int userId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colUserID"].Value);

                        // Open the UserForm in update mode
                        using (UserForm userForm = new UserForm(true, userId))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(userForm);
                        }

                        // Reload the grid after update
                        manageUserControl.ReloadGrid();
                    },
                    global::ADCoursework1.Properties.Resources.edit_white,
                    System.Drawing.SystemColors.Highlight
                );

                // Add the Delete button
                AddButtonWithEvents(
                    dgv,
                    row,
                    deleteColumnName,
                    (rowIndex) =>
                    {
                        // Confirm before deletion
                        if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int userId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colUserID"].Value);
                            User.TemporaryDeleteUser(userId); // Call the delete method

                            // Reload the grid after deletion
                            manageUserControl.ReloadGrid();

                            GUI.Home.ShowAlert("User deleted successfully.", Alert.AlertType.Success);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.detete_white,
                    System.Drawing.Color.Red
                );

                // Add the View button
                AddButtonWithEvents(
                    dgv,
                    row,
                    viewColumnName,
                    (rowIndex) =>
                    {
                        int userId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colUserID"].Value);

                        // Open the UserForm in view mode
                        using (UserForm userForm = new UserForm(isUpdateMode: false, userId: userId, isViewMode: true))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(userForm);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.view_white,
                    System.Drawing.Color.FromArgb(33, 42, 57)
                );
            }
        }

        // Customer Order Grid Buttons
        public static void AddButtonsToOrderGrid(ViewOrder viewOrderControl, DataGridView dgv, string viewColumnOrder)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the View button
                AddButtonWithEvents(
                    dgv,
                    row,
                    viewColumnOrder,
                    (rowIndex) =>
                    {
                        int orderId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colOrderID"].Value);

                        // Open the OrderDetails form in view mode
                        using (OrderDetails orderDetailsForm = new OrderDetails(orderId))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(orderDetailsForm);
                        }

                        // Reload the grid after viewing the order details
                        viewOrderControl.ReloadGrid();
                    },
                    global::ADCoursework1.Properties.Resources.view_white,
                    System.Drawing.Color.FromArgb(33, 42, 57)
                );
            }
        }

        // Admin Order Grid Buttons
        public static void AddViewAllOrdersButton(ManageOrder manageOrderControl, DataGridView dgv, string viewColumnOrder)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the View button
                AddButtonWithEvents(
                    dgv,
                    row,
                    viewColumnOrder,
                    (rowIndex) =>
                    {
                        int orderId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colOrderID"].Value);

                        // Open a form to view all orders
                        using (OrderForm orderForm = new OrderForm(orderId))
                        {
                            // Use the modal helper to show the form with dimming effect
                            ModalHelper.ShowModalWithMaximizedDimming(orderForm);
                        }

                        // Optionally reload the grid if you want to refresh after viewing (for any potential changes)
                        manageOrderControl.ReloadGrid(); // Implement ReloadGrid to refresh the data in dgv
                    },
                    global::ADCoursework1.Properties.Resources.view_white,
                    System.Drawing.Color.FromArgb(33, 42, 57)
                );
            }
        }

        // Inventory Grid Buttons
        public static void AddButtonsToInventoryGrid(ManageInventory manageInventoryControl, DataGridView dgv, string updateColumnInventory, string deleteColumnInventory, string viewColumnInventory)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // Add the Update button
                AddButtonWithEvents(
                    dgv,
                    row,
                    updateColumnInventory,
                    (rowIndex) =>
                    {
                        try
                        {
                            // Logic for updating stock
                            int stockId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colStockID"].Value);

                            // Open the StockForm in update mode
                            using (StockForm stockForm = new StockForm(true, stockId))
                            {
                                // Show the stock form to get the updated values
                                ModalHelper.ShowModalWithMaximizedDimming(stockForm);

                                if (stockForm.DialogResult == DialogResult.OK)
                                {
                                    // The updated stock object should be passed from the StockForm
                                    Stock stock = stockForm.GetUpdatedStock();
                                    Stock.UpdateStock(stock.StockId, stock.ItemId, stock.Date, stock.Quantity, stock.ReorderLevel);
                                }
                            }

                            // Reload the grid after update
                            manageInventoryControl.ReloadGrid();
                            Home.ShowAlert("Stock updated successfully.", Alert.AlertType.Success);
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("SQL Error: " + ex.Message);
                            MessageBox.Show("An error occurred while updating the stock record. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            MessageBox.Show("An unexpected error occurred. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.edit_white,
                    System.Drawing.SystemColors.Highlight
                );

                // Add the Delete button
                AddButtonWithEvents(
                    dgv,
                    row,
                    deleteColumnInventory,
                    (rowIndex) =>
                    {
                        // Confirm before deletion
                        if (MessageBox.Show("Are you sure you want to delete this stock entry?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int stockId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colStockID"].Value);
                            Stock.DeleteStock(stockId); // Call the delete method

                            // Reload the grid after deletion
                            manageInventoryControl.ReloadGrid();

                            Home.ShowAlert("Stock entry deleted successfully.", Alert.AlertType.Success);
                        }
                    },
                    global::ADCoursework1.Properties.Resources.detete_white,
                    System.Drawing.Color.Red
                );

                // Add the View button
                AddButtonWithEvents(
                    dgv,
                    row,
                    viewColumnInventory,
                    (rowIndex) =>
                    {
                        // Get the stock ID from the grid
                        int stockId = Convert.ToInt32(dgv.Rows[rowIndex].Cells["colStockID"].Value);

                        // Fetch the item ID and item type associated with the stock ID
                        var (itemId, itemType) = GetItemIdAndTypeFromStockId(stockId);

                        if (itemType.Equals("car", StringComparison.OrdinalIgnoreCase))
                        {
                            // Fetch the car ID from the database based on the item_id
                            int carId = GetCarIdFromItemId(itemId);

                            // Open the CarForm in view mode
                            using (CarForm carForm = new CarForm(isUpdateMode: false, carId: carId, isViewMode: true))
                            {
                                // Use the modal helper to show the form with dimming effect
                                ModalHelper.ShowModalWithMaximizedDimming(carForm);
                            }
                        }
                        else if (itemType.Equals("car part", StringComparison.OrdinalIgnoreCase))
                        {
                            // Fetch the car part ID from the database based on the item_id
                            int carPartId = GetCarPartIdFromItemId(itemId);

                            // Open the CarPartForm in view mode
                            using (CarPartForm carPartForm = new CarPartForm(isUpdateMode: false, carPartId: carPartId, isViewMode: true))
                            {
                                // Use the modal helper to show the form with dimming effect
                                ModalHelper.ShowModalWithMaximizedDimming(carPartForm);
                            }
                        }

                        // No need to reload the grid since it's view-only
                    },
                    global::ADCoursework1.Properties.Resources.view_white,
                    System.Drawing.Color.FromArgb(33, 42, 57)
                );
            }
        }

        // Method to get the item ID and type from the stock ID
        private static (int itemId, string itemType) GetItemIdAndTypeFromStockId(int stockId)
        {
            string sql = @"
                        SELECT i.item_id, i.item_type
                        FROM Item i
                        INNER JOIN Stock s ON s.item_id = i.item_id
                        WHERE s.stock_id = @StockId";

            SqlParameter[] parameters = { new SqlParameter("@StockId", stockId) };
            DataTable resultTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (resultTable.Rows.Count > 0)
            {
                DataRow row = resultTable.Rows[0];
                int itemId = Convert.ToInt32(row["item_id"]);
                string itemType = row["item_type"].ToString();
                return (itemId, itemType);
            }

            return (-1, null); // Return -1 if no item is found
        }

        // Method to get the car ID based on the item ID
        private static int GetCarIdFromItemId(int itemId)
        {
            string sql = "SELECT car_id FROM Car WHERE item_id = @ItemId";
            SqlParameter[] parameters = { new SqlParameter("@ItemId", itemId) };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            return result != null ? Convert.ToInt32(result) : -1; // Return -1 if no car is found
        }

        // Method to get the car part ID based on the item ID
        private static int GetCarPartIdFromItemId(int itemId)
        {
            string sql = "SELECT car_part_id FROM CarPart WHERE item_id = @ItemId";
            SqlParameter[] parameters = { new SqlParameter("@ItemId", itemId) };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            return result != null ? Convert.ToInt32(result) : -1; // Return -1 if no car part is found
        }
    }
}