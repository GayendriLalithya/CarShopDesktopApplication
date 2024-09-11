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
    public partial class CarPartArchive : Form
    {
        public CarPartArchive()
        {
            InitializeComponent();
            LoadDeletedCarParts();
        }

        private void LoadDeletedCarParts()
        {
            // Clear any existing rows
            DgvDeletedCarParts.Rows.Clear();

            // SQL query to select deleted car parts
            string sql = @"
                         SELECT 
                            cp.car_part_id, 
                            cp.car_part_name, 
                            b.brand_name, 
                            cp.part_number, 
                            cp.part_price, 
                            cp.image 
                         FROM CarPart cp
                         INNER JOIN Brand b ON cp.brand_id = b.brand_id
                         INNER JOIN Item i ON cp.item_id = i.item_id
                         WHERE i.deleted = 1";

            // Fetch data from the database
            DataTable deletedCarPartTable = DatabaseHelper.ExecuteDataTable(sql, null, CommandType.Text);

            if (deletedCarPartTable != null)
            {
                foreach (DataRow row in deletedCarPartTable.Rows)
                {
                    Image carPartImage = null;
                    if (!string.IsNullOrEmpty(row["image"].ToString()))
                    {
                        string imagePath = row["image"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            carPartImage = Image.FromFile(imagePath);
                            // Resize the image to fit within the row height
                            carPartImage = DataGridViewHelper.ResizeImageWithPadding(carPartImage, DgvDeletedCarParts.RowTemplate.Height, 5);
                        }
                    }

                    // Load button images from resources
                    Image recoverButtonImage = Properties.Resources.btn_recover;  // Ensure this resource exists in your project
                    Image deleteButtonImage = Properties.Resources.btn_delete;  // Ensure this resource exists in your project

                    // Resize the "recover" (edit) button image to be smaller
                    int recoverButtonSize = DgvDeletedCarParts.RowTemplate.Height - 20; // Adjust as needed for smaller size
                    recoverButtonImage = DataGridViewHelper.ResizeImageWithPadding(recoverButtonImage, recoverButtonSize, 5);

                    // Resize the delete button image to fit the DataGridView row height
                    deleteButtonImage = DataGridViewHelper.ResizeImageWithPadding(deleteButtonImage, DgvDeletedCarParts.RowTemplate.Height, 5);

                    // Add rows to the DataGridView
                    DgvDeletedCarParts.Rows.Add(
                        row["car_part_id"],
                        row["car_part_name"],
                        row["brand_name"],
                        row["part_number"],
                        row["part_price"],
                        carPartImage,         // Car part image
                        recoverButtonImage, // Smaller recover button image
                        deleteButtonImage   // Delete button image
                    );
                }
            }

            // Set AutoSizeMode to None to prevent resizing
            DgvDeletedCarParts.Columns["colBtnRecover"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvDeletedCarParts.Columns["colBtnDelete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Adjust column widths, row heights, or other properties as needed
            DgvDeletedCarParts.Columns["colBtnRecover"].Width = 80;
            DgvDeletedCarParts.Columns["colBtnDelete"].Width = 80;
            DgvDeletedCarParts.RowTemplate.Height = 80;

            // Adjust padding for the image columns
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Padding = new Padding(10);  // Adjust the padding value as needed
            DgvDeletedCarParts.Columns["colBtnRecover"].DefaultCellStyle = style;
            DgvDeletedCarParts.Columns["colBtnDelete"].DefaultCellStyle = style;

            // Subscribe to the CellClick event
            DgvDeletedCarParts.CellClick += DgvDeletedCarParts_CellClick;
            DgvDeletedCarParts.CellMouseEnter += DgvDeletedCarParts_CellMouseEnter;
            DgvDeletedCarParts.CellMouseLeave += DgvDeletedCarParts_CellMouseLeave;
        }

        private void DgvDeletedCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedCarParts.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedCarParts.Columns.Count)
            {
                // Determine which column was clicked
                var columnName = DgvDeletedCarParts.Columns[e.ColumnIndex].Name;
                var carPartId = Convert.ToInt32(DgvDeletedCarParts.Rows[e.RowIndex].Cells["colCarPartID"].Value);

                if (columnName == "colBtnRecover")
                {
                    // Logic to recover the car part
                    CarPart.RecoverCarPart(carPartId);

                    // Reload the grid after recovery
                    LoadDeletedCarParts();

                    GUI.Home.ShowAlert("Car part recovered successfully.", Alert.AlertType.Success);
                }
                else if (columnName == "colBtnDelete")
                {
                    // Confirm before permanent deletion
                    if (MessageBox.Show("Are you sure you want to permanently delete this car part?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CarPart.DeleteCarPart(carPartId);

                        // Reload the grid after deletion
                        LoadDeletedCarParts();

                        GUI.Home.ShowAlert("Car part permanently deleted.", Alert.AlertType.Success);
                    }
                }
            }
        }

        private void DgvDeletedCarParts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedCarParts.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedCarParts.Columns.Count)
            {
                var columnName = DgvDeletedCarParts.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedCarParts.Cursor = Cursors.Hand; // Change cursor to hand
                }
            }
        }

        private void DgvDeletedCarParts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedCarParts.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedCarParts.Columns.Count)
            {
                var columnName = DgvDeletedCarParts.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedCarParts.Cursor = Cursors.Default; // Change cursor back to default
                }
            }
        }
    }
}
