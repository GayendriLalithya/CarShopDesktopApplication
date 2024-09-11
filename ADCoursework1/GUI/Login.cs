using ADCoursework1.Entities;
using ADCoursework1.GUI.Admin;
using ADCoursework1.GUI.Customer;
using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Ensure the password is hidden initially
            TbPassword.UseSystemPasswordChar = true;
        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();  // Create a new instance of the registration form
            register.Show();  // Show the registration form
            this.Hide();  // Close the current login form
        }

        private void CtrlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Gather input from textboxes
            string email = TbUname.Text.Trim();
            string password = TbPassword.Text.Trim();

            // Ensure email and password fields are not empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Home.ShowAlert("Please enter both email and password.", Alert.AlertType.Error);
                return;
            }

            // Create an instance of the User class
            string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;
            User user = new User(connectionString);

            // Attempt to log in
            try
            {
                string userType;
                bool loginSuccessful = user.Login(email, password, out userType);

                if (loginSuccessful)
                {
                    // Perform session login and set session variables
                    SessionManager.PerformLogin(email, password);

                    //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the login form
                    this.Close();

                    // Open the home page
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    Home.ShowAlert("Login failed. Please check your email and password.", Alert.AlertType.Error);

                }
            }
            catch (Exception ex)
            {
                Home.ShowAlert("An error occurred during login: " + ex.Message, Alert.AlertType.Error);
            }
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
