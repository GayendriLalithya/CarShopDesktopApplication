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

namespace ADCoursework1.GUI.Controller
{
    public partial class ManageProfile : UserControl
    {
        public ManageProfile()
        {
            InitializeComponent();
            LoadUserDetails(SessionManager.UserId); // Pass the UserId from SessionManager
        }

        private void LoadUserDetails(int userId)
        {
            // Load user details from the database based on the logged-in user's ID
            User user = User.SearchUser(SessionManager.UserId); // Directly use SessionManager.UserId
            if (user != null)
            {
                // Populate form fields with the user's details
                CmbUType.SelectedItem = user.UserType;
                TbFname.Text = user.FirstName;
                TbLname.Text = user.LastName;
                TbAddress.Text = user.Address;
                TbContact.Text = user.ContactNo;
                TbEmail.Text = user.Email;

                // Disable the email text box and user type combo box
                TbEmail.Enabled = false;
                CmbUType.Enabled = false;
            }
            else
            {
                Home.ShowAlert("User details could not be loaded.", Alert.AlertType.Error);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate form inputs
                if (!ValidateForm())
                {
                    Home.ShowAlert("Please fill in all required fields.", Alert.AlertType.Warning);
                    return;
                }

                // Create a new User object and populate it with data from the form
                User user = new User
                {
                    UserId = SessionManager.UserId, // Use the logged-in user's ID
                    FirstName = TbFname.Text,
                    LastName = TbLname.Text,
                    Address = TbAddress.Text,
                    ContactNo = TbContact.Text,
                    Email = TbEmail.Text, // Email should be disabled but still used for reference
                    UserType = CmbUType.SelectedItem.ToString() // UserType should also be disabled but still used
                };

                // Call the method to update the existing user's information
                user.UpdateUser();
                Home.ShowAlert("User information updated successfully.", Alert.AlertType.Success);

                // Optionally, you might want to notify the parent form or main application that the update was successful
                OnUserProfileUpdated(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Home.ShowAlert($"An error occurred: {ex.Message}", Alert.AlertType.Error);
            }
        }

        // Validation Method
        private bool ValidateForm()
        {
            // Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(TbFname.Text) ||
                string.IsNullOrWhiteSpace(TbLname.Text) ||
                string.IsNullOrWhiteSpace(TbAddress.Text) ||
                string.IsNullOrWhiteSpace(TbContact.Text) ||
                string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                Home.ShowAlert("All fields are required.", Alert.AlertType.Warning);
                return false;
            }

            // Validate Contact Number using the ValidationHelper
            if (!ValidationHelper.IsValidContactNumber(TbContact.Text))
            {
                Home.ShowAlert("Invalid contact number. Please enter a valid contact number.", Alert.AlertType.Warning);
                TbContact.Focus();
                return false;
            }

            // All validations passed
            return true;
        }

        // Optional event to notify when the profile is updated
        public event EventHandler UserProfileUpdated;

        protected virtual void OnUserProfileUpdated(EventArgs e)
        {
            UserProfileUpdated?.Invoke(this, e);
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            // Gather input from textboxes
            string currentPassword = TbCurrentPassword.Text.Trim();
            string newPassword = TbNewPassword.Text.Trim();
            string confirmPassword = TbConfirmPassword.Text.Trim();

            // Ensure all fields are filled
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                Home.ShowAlert("All fields are required.", Alert.AlertType.Warning);
                return;
            }

            // Ensure the new password matches the confirm password
            if (newPassword != confirmPassword)
            {
                Home.ShowAlert("New password and confirm password do not match.", Alert.AlertType.Error);
                return;
            }

            // Validate the new password using the ValidationHelper class
            if (!ValidationHelper.IsValidPassword(newPassword))
            {
                Home.ShowAlert("The new password does not meet the required criteria. Please ensure it is at least 8 characters long, contains one uppercase letter, one lowercase letter, one digit, and one special character.", Alert.AlertType.Warning);
                TbNewPassword.Clear();
                TbConfirmPassword.Clear();
                TbNewPassword.Focus();
                return;
            }

            try
            {
                // Retrieve the logged-in user's current password hash
                User user = User.SearchUser(SessionManager.UserId);
                if (user == null)
                {
                    Home.ShowAlert("User not found.", Alert.AlertType.Error);
                    return;
                }

                // Verify the current password
                if (!PasswordHelper.VerifyPassword(user.Password, currentPassword))
                {
                    Home.ShowAlert("Current password is incorrect.", Alert.AlertType.Error);
                    TbCurrentPassword.Clear();
                    TbCurrentPassword.Focus();
                    return;
                }

                // Hash the new password
                string hashedNewPassword = PasswordHelper.HashPassword(newPassword);

                // Update the user's password in the database
                user.Password = hashedNewPassword;
                user.UpdatePassword(); 

                // Notify the user of success
                Home.ShowAlert("Password changed successfully!", Alert.AlertType.Success);

                // Clear the password fields after success
                TbCurrentPassword.Clear();
                TbNewPassword.Clear();
                TbConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                Home.ShowAlert($"An error occurred: {ex.Message}", Alert.AlertType.Error);
            }
        }
    }
}
