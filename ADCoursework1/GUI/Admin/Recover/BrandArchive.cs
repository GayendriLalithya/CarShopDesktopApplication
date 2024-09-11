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
    public partial class BrandArchive : Form
    {
        public BrandArchive()
        {
            InitializeComponent();
            LoadDeletedBrands();
        }

        private void LoadDeletedBrands()
        {
            // Clear any existing rows
            DgvDeletedBrands.Rows.Clear();

            // SQL query to select deleted brands
            string sql = "SELECT brand_id, brand_name, image FROM Brand WHERE deleted = 1";

            // Fetch data from the database
            DataTable deletedBrandTable = DatabaseHelper.ExecuteDataTable(sql, null, CommandType.Text);

            if (deletedBrandTable != null)
            {
                foreach (DataRow row in deletedBrandTable.Rows)
                {
                    Image brandImage = null;
                    if (!string.IsNullOrEmpty(row["image"].ToString()))
                    {
                        string imagePath = row["image"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            brandImage = Image.FromFile(imagePath);
                            // Resize the image to fit within the row height
                            brandImage = DataGridViewHelper.ResizeImageWithPadding(brandImage, DgvDeletedBrands.RowTemplate.Height, 5);
                        }
                    }

                    // Load button images from resources
                    Image recoverButtonImage = Properties.Resources.btn_recover;  // Ensure this resource exists in your project
                    Image deleteButtonImage = Properties.Resources.btn_delete;  // Ensure this resource exists in your project

                    // Resize the "recover" (edit) button image to be smaller
                    int recoverButtonSize = DgvDeletedBrands.RowTemplate.Height - 20; // Adjust as needed for smaller size
                    recoverButtonImage = DataGridViewHelper.ResizeImageWithPadding(recoverButtonImage, recoverButtonSize, 5);

                    // Resize the delete button image to fit the DataGridView row height
                    deleteButtonImage = DataGridViewHelper.ResizeImageWithPadding(deleteButtonImage, DgvDeletedBrands.RowTemplate.Height, 5);

                    // Add rows to the DataGridView
                    DgvDeletedBrands.Rows.Add(
                        row["brand_id"],
                        row["brand_name"],
                        brandImage,         // Brand image
                        recoverButtonImage, // Smaller recover button image
                        deleteButtonImage   // Delete button image
                    );
                }
            }

            // Set AutoSizeMode to None to prevent resizing
            DgvDeletedBrands.Columns["colBtnRecover"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvDeletedBrands.Columns["colBtnDelete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Adjust column widths, row heights, or other properties as needed
            DgvDeletedBrands.Columns["colBtnRecover"].Width = 80;
            DgvDeletedBrands.Columns["colBtnDelete"].Width = 80;
            DgvDeletedBrands.RowTemplate.Height = 80;

            // Adjust padding for the image columns
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Padding = new Padding(10);  // Adjust the padding value as needed
            DgvDeletedBrands.Columns["colBtnRecover"].DefaultCellStyle = style;
            DgvDeletedBrands.Columns["colBtnDelete"].DefaultCellStyle = style;

            // Subscribe to the CellClick event
            DgvDeletedBrands.CellClick += DgvDeletedBrands_CellClick;
            DgvDeletedBrands.CellMouseEnter += DgvDeletedBrands_CellMouseEnter;
            DgvDeletedBrands.CellMouseLeave += DgvDeletedBrands_CellMouseLeave;
        }

        private void DgvDeletedBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedBrands.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedBrands.Columns.Count)
            {
                // Determine which column was clicked
                var columnName = DgvDeletedBrands.Columns[e.ColumnIndex].Name;
                var brandId = Convert.ToInt32(DgvDeletedBrands.Rows[e.RowIndex].Cells["colBrandID"].Value);

                if (columnName == "colBtnRecover")
                {
                    // Logic to recover the brand
                    Brand.RecoverBrand(brandId);

                    // Reload the grid after recovery
                    LoadDeletedBrands();

                    Home.ShowAlert("Brand recovered successfully.", Alert.AlertType.Success);
                }
                else if (columnName == "colBtnDelete")
                {
                    // Confirm before permanent deletion
                    if (MessageBox.Show("Are you sure you want to permanently delete this brand?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Brand.DeleteBrand(brandId);

                        // Reload the grid after deletion
                        LoadDeletedBrands();

                        Home.ShowAlert("Brand permanently deleted.", Alert.AlertType.Success);
                    }
                }
            }
        }

        private void DgvDeletedBrands_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedBrands.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedBrands.Columns.Count)
            {
                var columnName = DgvDeletedBrands.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedBrands.Cursor = Cursors.Hand; // Change cursor to hand
                }
            }
        }

        private void DgvDeletedBrands_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedBrands.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedBrands.Columns.Count)
            {
                var columnName = DgvDeletedBrands.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedBrands.Cursor = Cursors.Default; // Change cursor back to default
                }
            }
        }

    }
}