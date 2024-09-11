using ADCoursework1.Entities;
using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            // Ensure the password is hidden initially
            TbPassword.UseSystemPasswordChar = true;

            // User Type Combo box adjustments
            CmbUtype.SelectedItem = "Customer"; // Set "Customer" as the default by name
            CmbUtype.Enabled = false; // Disable the UserType ComboBox by default
            this.KeyPreview = true; // Allows the form to capture key events
            this.KeyDown += new KeyEventHandler(RegistrationForm_KeyDown); // Attach the KeyDown event handler
        }

        private void RegistrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key combination Ctrl + Shift + U is pressed
            if (e.Control && e.Shift && e.KeyCode == Keys.U)
            {
                CmbUtype.Enabled = !CmbUtype.Enabled; // Toggle the enabled state of the UserType ComboBox
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Gather input from textboxes
            string email = TbEmail.Text.Trim();
            string password = TbPassword.Text.Trim();
            string contactNo = TbContact.Text.Trim();
            string firstName = TbFname.Text.Trim();
            string lastName = TbLname.Text.Trim();
            string address = TbAddress.Text.Trim();

            // Check if any required field is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(contactNo) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("All fields are required. Please ensure no field is left blank.");
                return;
            }

            // Validate using Regular Expressions from the ValidationHelper
            bool hasError = false;

            // Validate Email
            if (ValidationHelper.IsValidEmail(email))
            {
                LblEmailError.Text = ""; // Clear the error if valid
            }
            else
            {
                LblEmailError.Text = "Invalid email address.";
                LblEmailError.ForeColor = Color.Red;
                TbEmail.Clear();
                TbEmail.Focus();
                hasError = true;
            }

            // Validate Password
            if (ValidationHelper.IsValidPassword(password))
            {
                LblPasswordError.Text = ""; // Clear the error if valid
            }
            else
            {
                LblPasswordError.Text = "Invalid Password";
                LblPasswordError.ForeColor = Color.Red;
                TbPassword.Clear();
                TbPassword.Focus();
                hasError = true;
            }

            // Validate Contact Number
            if (ValidationHelper.IsValidContactNumber(contactNo))
            {
                LblContactError.Text = ""; // Clear the error if valid
            }
            else
            {
                LblContactError.Text = "Invalid contact number.";
                LblContactError.ForeColor = Color.Red;
                TbContact.Clear();
                TbContact.Focus();
                hasError = true;
            }

            // Check if there were any validation errors
            if (hasError)
            {
                return; // Do not proceed if there's any error
            }

            // Get user type from ComboBox
            string userType = CmbUtype.SelectedItem?.ToString();

            // Ensure userType is selected
            if (string.IsNullOrEmpty(userType))
            {
                //MessageBox.Show("Please select a user type.");
                Home.ShowAlert("Please select a user type.", Alert.AlertType.Info);
                return;
            }

            // Getting the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

            // Instantiate and set properties of User object
            User user = new User(connectionString)
            {
                UserType = userType,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                ContactNo = contactNo,
                Email = email,
                Password = password
            };

            // Call the register method in the user class
            try
            {
                user.Register();
                //MessageBox.Show("User registered successfully!");
                Home.ShowAlert("User registered successfully!", Alert.AlertType.Success);

                // Show the login form before closing the current form
                Login login = new Login();
                login.Show();

                // Now close the registration page
                this.Hide();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Registration failed. " + ex.Message);
                Home.ShowAlert("Registration failed. " + ex.Message, Alert.AlertType.Success);
            }
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();  // Create a new instance of the registration form
            login.Show();  // Show the registration form
            this.Hide();  // Close the current login form
        }

        private void CtrlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (BtnShowPassword.Checked == true)
            {
                TbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
