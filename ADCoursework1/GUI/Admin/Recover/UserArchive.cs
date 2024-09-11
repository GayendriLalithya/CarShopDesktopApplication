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
    public partial class UserArchive : Form
    {
        public UserArchive()
        {
            InitializeComponent();
            LoadDeletedUsers();
        }

        private void LoadDeletedUsers()
        {
            // Clear any existing rows
            DgvDeletedUsers.Rows.Clear();

            // SQL query to select deleted users
            string sql = @"
                         SELECT 
                            user_id, 
                            user_type, 
                            first_name, 
                            last_name, 
                            address, 
                            contact_no, 
                            email 
                         FROM Users
                         WHERE deleted = 1";

            // Fetch data from the database
            DataTable deletedUserTable = DatabaseHelper.ExecuteDataTable(sql, null, CommandType.Text);

            if (deletedUserTable != null)
            {
                foreach (DataRow row in deletedUserTable.Rows)
                {
                    // Load button images from resources
                    Image recoverButtonImage = Properties.Resources.btn_recover;  // Ensure this resource exists in your project
                    Image deleteButtonImage = Properties.Resources.btn_delete;  // Ensure this resource exists in your project

                    // Resize the "recover" (edit) button image to be smaller
                    int recoverButtonSize = DgvDeletedUsers.RowTemplate.Height - 20; // Adjust as needed for smaller size
                    recoverButtonImage = DataGridViewHelper.ResizeImageWithPadding(recoverButtonImage, recoverButtonSize, 5);

                    // Resize the delete button image to fit the DataGridView row height
                    deleteButtonImage = DataGridViewHelper.ResizeImageWithPadding(deleteButtonImage, DgvDeletedUsers.RowTemplate.Height, 5);

                    // Add rows to the DataGridView
                    DgvDeletedUsers.Rows.Add(
                        row["user_id"],
                        row["user_type"],
                        row["first_name"],
                        row["last_name"],
                        row["address"],
                        row["contact_no"],
                        row["email"],
                        recoverButtonImage, // Smaller recover button image
                        deleteButtonImage   // Delete button image
                    );
                }
            }

            // Set AutoSizeMode to None to prevent resizing
            DgvDeletedUsers.Columns["colBtnRecover"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvDeletedUsers.Columns["colBtnDelete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Adjust column widths, row heights, or other properties as needed
            DgvDeletedUsers.Columns["colBtnRecover"].Width = 80;
            DgvDeletedUsers.Columns["colBtnDelete"].Width = 80;
            DgvDeletedUsers.RowTemplate.Height = 80;

            // Adjust padding for the image columns
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Padding = new Padding(10);  // Adjust the padding value as needed
            DgvDeletedUsers.Columns["colBtnRecover"].DefaultCellStyle = style;
            DgvDeletedUsers.Columns["colBtnDelete"].DefaultCellStyle = style;

            // Subscribe to the CellClick event
            DgvDeletedUsers.CellClick += DgvDeletedUsers_CellClick;
            DgvDeletedUsers.CellMouseEnter += DgvDeletedUsers_CellMouseEnter;
            DgvDeletedUsers.CellMouseLeave += DgvDeletedUsers_CellMouseLeave;
        }

        private void DgvDeletedUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedUsers.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedUsers.Columns.Count)
            {
                // Determine which column was clicked
                var columnName = DgvDeletedUsers.Columns[e.ColumnIndex].Name;
                var userId = Convert.ToInt32(DgvDeletedUsers.Rows[e.RowIndex].Cells["colUserID"].Value);

                if (columnName == "colBtnRecover")
                {
                    // Logic to recover the user
                    User.RecoverUser(userId);

                    // Reload the grid after recovery
                    LoadDeletedUsers();

                    GUI.Home.ShowAlert("User recovered successfully.", Alert.AlertType.Success);
                }
                else if (columnName == "colBtnDelete")
                {
                    // Confirm before permanent deletion
                    if (MessageBox.Show("Are you sure you want to permanently delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        User.DeleteUser(userId);

                        // Reload the grid after deletion
                        LoadDeletedUsers();

                        GUI.Home.ShowAlert("User permanently deleted.", Alert.AlertType.Success);
                    }
                }
            }
        }

        private void DgvDeletedUsers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedUsers.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedUsers.Columns.Count)
            {
                var columnName = DgvDeletedUsers.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedUsers.Cursor = Cursors.Hand; // Change cursor to hand
                }
            }
        }

        private void DgvDeletedUsers_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DgvDeletedUsers.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DgvDeletedUsers.Columns.Count)
            {
                var columnName = DgvDeletedUsers.Columns[e.ColumnIndex].Name;
                if (columnName == "colBtnRecover" || columnName == "colBtnDelete")
                {
                    DgvDeletedUsers.Cursor = Cursors.Default; // Change cursor back to default
                }
            }
        }
    }
}
