using ADCoursework1.Entities;
using ADCoursework1.GUI.Admin.Recover;
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
    public partial class ManageUser : UserControl
    {
        public ManageUser()
        {
            InitializeComponent();
            LoadUsers();
            DataGridViewHelper.AddButtonsToUserGrid(this, DgvUsers, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        public void ReloadGrid()
        {
            // Get the selected user type filter
            string selectedUserType = GetSelectedUserType();

            // Reload the users with the selected filter
            LoadUsers(selectedUserType);
        }

        private string GetSelectedUserType()
        {
            if (BtnAdmin.Checked)
            {
                return "Admin";
            }
            else if (BtnCustomer.Checked)
            {
                return "Customer";
            }
            else
            {
                return null; // No filter applied, show all users
            }
        }

        private void LoadUsers(string userType = null, string searchUser = "")
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the size of the columns
            DgvUsers.Columns["colBtnUpdate"].Width = 80;
            DgvUsers.Columns["colBtnDelete"].Width = 80;
            DgvUsers.Columns["colBtnView"].Width = 80;

            // Set the row height
            DgvUsers.RowTemplate.Height = 80;

            // Base SQL query to select user data
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
                         WHERE deleted = 0";

            // List to hold SQL parameters
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add a WHERE clause if a user type is specified
            if (!string.IsNullOrEmpty(userType))
            {
                sql += " AND user_type = @UserType";
                parameters.Add(new SqlParameter("@UserType", userType));
            }

            // Add search conditions if a search term is provided
            if (!string.IsNullOrEmpty(searchUser))
            {
                sql += @"
                    AND (
                        LOWER(first_name) LIKE LOWER(@SearchUser)
                        OR LOWER(last_name) LIKE LOWER(@SearchUser)
                        OR LOWER(CONCAT(first_name, ' ', last_name)) LIKE LOWER(@SearchUser)
                        OR LOWER(contact_no) LIKE LOWER(@SearchUser)
                        OR LOWER(email) LIKE LOWER(@SearchUser)
                    )";
                parameters.Add(new SqlParameter("@SearchUser", "%" + searchUser.ToLower() + "%"));
            }

            // Fetch data from the database
            DataTable userTable = DatabaseHelper.ExecuteDataTable(sql, parameters.ToArray());

            if (userTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvUsers.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in userTable.Rows)
                {
                    DgvUsers.Rows.Add(
                        row["user_id"],
                        row["user_type"],
                        row["first_name"],
                        row["last_name"],
                        row["address"],
                        row["contact_no"],
                        row["email"],
                        "",  // Icon for the Update button
                        "",  // Icon for the Delete button
                        ""     // Icon for the View button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToUserGrid(this, DgvUsers, "colBtnUpdate", "colBtnDelete", "colBtnView");
        }

        private void RemoveAllButtons()
        {
            var buttonsToRemove = DgvUsers.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().ToList();
            foreach (var btn in buttonsToRemove)
            {
                DgvUsers.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            // Uncheck other buttons and check the All button
            BtnCustomer.Checked = false;
            BtnAdmin.Checked = false;
            BtnAll.Checked = true;

            // Load all users into the DataGridView
            LoadUsers();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            // Uncheck other buttons and check the Customer button
            BtnAll.Checked = false;
            BtnAdmin.Checked = false;
            BtnCustomer.Checked = true;

            // Load only customers into the DataGridView
            LoadUsers("Customer");
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            BtnAll.Checked = false;
            BtnCustomer.Checked = false;
            BtnAdmin.Checked = true;

            // Load only admins into the DataGridView
            LoadUsers("Admin");
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddUser form
            using (UserForm addUserForm = new UserForm())
            {
                // Show the modal with dimming effect
                ModalHelper.ShowModalWithMaximizedDimming(addUserForm);

                // Reload the grid based on the currently selected filter
                ReloadGrid();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchUser = TbSearchUser.Text.Trim();

            // Reload the grid with the search term
            LoadUsers(null, searchUser);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            TbSearchUser.Clear();
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            using (UserArchive userArchive = new UserArchive())
            {
                ModalHelper.ShowModalWithMaximizedDimming(userArchive);
            }
        }
    }
}