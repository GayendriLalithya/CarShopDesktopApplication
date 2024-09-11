using ADCoursework1.Entities;
using ADCoursework1.GUI.Forms;
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

namespace ADCoursework1.GUI.Admin.Recover
{
    public partial class CarArchive : Form
    {
        public CarArchive()
        {
            InitializeComponent();
            LoadDeletedCars(); 
        }

        private void LoadDeletedCars()
        {
            // Clear any existing rows
            DgvDeletedCars.Rows.Clear();

            // SQL query to select deleted cars
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
                         WHERE i.deleted = 1";

            // Fetch data from the database
            DataTable deletedCarTable = DatabaseHelper.ExecuteDataTable(sql, null, CommandType.Text);

            if (deletedCarTable != null)
            {
                foreach (DataRow row in deletedCarTable.Rows)
                {
                    Image carImage = null;
                    if (!string.IsNullOrEmpty(row["image"].ToString()))
                    {
                        string imagePath = row["image"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            carImage = Image.FromFile(imagePath);
                            // Resize the image to fit within the row height
                            carImage = DataGridViewHelper.ResizeImageWithPadding(carImage, DgvDeletedCars.RowTemplate.Height, 5);
                        }
                    }

                    // Load button images from resources
                    Image recoverButtonImage = Properties.Resources.btn_recover;  // Ensure this resource exists in your project
                    Image deleteButtonImage = Properties.Resources.btn_delete;  // Ensure this resource exists in your project

                    // Resize the "recover" (edit) button image to be smaller
                    int recoverButtonSize = DgvDeletedCars.RowTemplate.Height - 20; // Adjust as needed for smaller size
                    recoverButtonImage = DataGridViewHelper.ResizeImageWithPadding(recoverButtonImage, recoverButtonSize, 5);

                    // Resize the delete button image to fit the DataGridView row height
                    deleteButtonImage = DataGridViewHelper.ResizeImageWithPadding(deleteButtonImage, DgvDeletedCars.RowTemplate.Height, 5);

                    // Add rows to the DataGridView
                    DgvDeletedCars.Rows.Add(
                        row["car_id"],
                        row["brand_name"],
                        row["model"],
                        row["year"],
                        row["price"],
                        carImage,         // Car image
                        recoverButtonImage, // Smaller recover button image
                        deleteButtonImage   // Delete button image
                    );
                }
            }

            // Set AutoSizeMode to None to prevent resizing
            DgvDeletedCars.Columns["colBtnRecover"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvDeletedCars.Columns["colBtnDelete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Adjust column widths, row heights, or other properties as needed
            DgvDeletedCars.Columns["colBtnRecover"].Width = 80;
            DgvDeletedCars.Columns["colBtnDelete"].Width = 80;
            DgvDeletedCars.RowTemplate.Height = 80;

            // Adjust padding for the image columns
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Padding = new Padding(10);  // Adjust the padding value as needed
            DgvDeletedCars.Columns["colBtnRecover"].DefaultCellStyle = style;
            DgvDeletedCars.Columns["colBtnDelete"].DefaultCellStyle = style;

            // Subscribe to the CellClick event
            DgvDeletedCars.CellClick += DgvDeletedCars_CellClick;
            DgvDeletedCars.CellMouseEnter += DgvDeletedCars_CellMouseEnter;
            DgvDeletedCars.CellMouseLeave += DgvDeletedCars_CellMouseLeave;
        }

        private void DgvDeletedCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedCars.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedCars.Columns.Count)
            {
                // Determine which column was clicked
                var columnName = DgvDeletedCars.Columns[e.ColumnIndex].Name;
                var carId = Convert.ToInt32(DgvDeletedCars.Rows[e.RowIndex].Cells["colCarID"].Value);

                if (columnName == "colBtnRecover")
                {
                    // Logic to recover the car
                    Car.RecoverCar(carId);

                    // Reload the grid after recovery
                    LoadDeletedCars();

                    GUI.Home.ShowAlert("Car recovered successfully.", Alert.AlertType.Success);
                }
                else if (columnName == "colBtnDelete")
                {
                    // Confirm before permanent deletion
                    if (MessageBox.Show("Are you sure you want to permanently delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Car.DeleteCar(carId);

                        // Reload the grid after deletion
                        LoadDeletedCars();

                        GUI.Home.ShowAlert("Car permanently deleted.", Alert.AlertType.Success);
                    }
                }
            }
        }

        private void DgvDeletedCars_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedCars.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedCars.Columns.Count)
            {
                var columnName = DgvDeletedCars.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedCars.Cursor = Cursors.Hand; // Change cursor to hand
                }
            }
        }

        private void DgvDeletedCars_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedCars.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedCars.Columns.Count)
            {
                var columnName = DgvDeletedCars.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedCars.Cursor = Cursors.Default; // Change cursor back to default
                }
            }
        }
    }
}