using ADCoursework1.Entities;
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

namespace ADCoursework1.GUI.Forms
{
    public partial class UserForm : Form
    {
        private int? UserId { get; set; }
        private bool IsUpdateMode { get; set; }
        public bool IsViewMode { get; set; }

        public UserForm()
        {
            InitializeComponent();
        }

        // Constructor for updating an existing user
        public UserForm(bool isUpdateMode = false, int? userId = null, bool isViewMode = false) : this()
        {
            this.IsUpdateMode = isUpdateMode;
            this.UserId = userId;
            this.IsViewMode = isViewMode;

            if (IsViewMode)
            {
                LblFormHeading.Text = "View User";
                BtnSubmit.Visible = false; // Hide the Submit button in view mode
                DisableFields(); // Make all fields read-only
                LoadUserDetails(UserId.Value); // Load the user details
            }
            else if (isUpdateMode && userId.HasValue)
            {
                LblFormHeading.Text = "Update User";
                BtnSubmit.Text = "Update User";
                LoadUserDetails(userId.Value);
            }
            else
            {
                LblFormHeading.Text = "Add New User";
                BtnSubmit.Text = "Add User";
            }
        }

        private void DisableFields()
        {
            CmbUType.Enabled = false;
            TbFname.ReadOnly = true;
            TbLname.ReadOnly = true;
            TbAddress.ReadOnly = true;
            TbContact.ReadOnly = true;
            TbEmail.ReadOnly = true;
            TbPassword.Enabled = false; // Disable the password field
        }

        private void LoadUserDetails(int userId)
        {
            // Load user details from the database based on userId
            // Example:
            User user = User.SearchUser(userId);
            if (user != null)
            {
                // Populate form fields with the user's details
                CmbUType.SelectedItem = user.UserType;
                TbFname.Text = user.FirstName;
                TbLname.Text = user.LastName;
                TbAddress.Text = user.Address;
                TbContact.Text = user.ContactNo;
                TbEmail.Text = user.Email;

                // Disable password textbox and show a placeholder (e.g., "********")
                TbPassword.Text = "********";
                TbPassword.Enabled = false; // Disable the password textbox in update mode
                CmbUType.Enabled = false;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                {
                    Home.ShowAlert("Please fill in all required fields.", Alert.AlertType.Info);
                    return;
                }

                // Check if the password field is filled
                if (string.IsNullOrEmpty(TbPassword.Text))
                {
                    Home.ShowAlert("Password is required.", Alert.AlertType.Info);
                    return;
                }

                // Hash the password entered in the admin form
                string hashedPassword = PasswordHelper.HashPassword(TbPassword.Text);

                // Create new user object
                User user = new User
                {
                    FirstName = TbFname.Text,
                    LastName = TbLname.Text,
                    Address = TbAddress.Text,
                    ContactNo = TbContact.Text,
                    Email = TbEmail.Text,
                    UserType = CmbUType.SelectedItem.ToString(),
                    Password = hashedPassword  // Ensure password is hashed
                };

                if (IsUpdateMode && UserId.HasValue)
                {
                    user.UserId = UserId.Value; // Set the UserId for updating
                    user.UpdateUser(); // Call the method to update the existing user
                    Home.ShowAlert("User updated successfully.", Alert.AlertType.Success);
                }
                else
                {
                    user.Register(); // Call the method to insert a new user
                    Home.ShowAlert("User added successfully.", Alert.AlertType.Success);
                }

                //this.DialogResult = DialogResult.OK; // Set dialog result to OK
                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                Home.ShowAlert($"An error occurred: {ex.Message}", Alert.AlertType.Error);
            }
        }

        private bool ValidateForm()
        {
            // Example validation logic
            bool isValid = true;

            // Validate first name
            if (string.IsNullOrWhiteSpace(TbFname.Text))
            {
                isValid = false;
                Home.ShowAlert("First name is required.", Alert.AlertType.Info);
                TbFname.Focus();
            }

            // Validate last name
            if (string.IsNullOrWhiteSpace(TbLname.Text))
            {
                isValid = false;
                Home.ShowAlert("Last name is required.", Alert.AlertType.Info);
                TbLname.Focus();
            }

            // Validate contact number using ValidationHelper
            if (!ValidationHelper.IsValidContactNumber(TbContact.Text))
            {
                isValid = false;
                Home.ShowAlert("Invalid contact number.", Alert.AlertType.Error);
                TbContact.Clear();
                TbContact.Focus();
            }

            // Validate email using ValidationHelper
            if (!ValidationHelper.IsValidEmail(TbEmail.Text))
            {
                isValid = false;
                Home.ShowAlert("Invalid email address.", Alert.AlertType.Error);
                TbEmail.Clear();
                TbEmail.Focus();
            }

            // Validate password using ValidationHelper
            // Skip this validation if in update mode and the password hasn't been changed
            if (!IsUpdateMode || (TbPassword.Text != "********" && !string.IsNullOrWhiteSpace(TbPassword.Text)))
            {
                if (!ValidationHelper.IsValidPassword(TbPassword.Text))
                {
                    isValid = false;
                    Home.ShowAlert("Invalid password.", Alert.AlertType.Error);
                    Home.ShowAlert("Password must be at least 8 characters long, contain one uppercase letter, one lowercase letter, one digit, and one special character.", Alert.AlertType.Info);
                    TbPassword.Clear();
                    TbPassword.Focus();
                }
            }

            return isValid;
        }
    }
}
