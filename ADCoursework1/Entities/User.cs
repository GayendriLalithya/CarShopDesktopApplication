using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADCoursework1.GUI;
using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;

namespace ADCoursework1.Entities
{
    public class User
    {
        // Attributes of the user class
        public int UserId { get; set; } // Changed to non-nullable
        public string UserType { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // Database Connection
        private readonly string connectionString;

        // Default Constructor
        public User() { }

        // Parameterized Constructor for user details
        public User(string userType, string firstName, string lastName, string address, string contactNo, string email, string password)
        {
            this.UserType = userType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.ContactNo = contactNo;
            this.Email = email;
            this.Password = password;
        }

        // Parameterized Constructor for database connection
        public User(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // User Register Method
        public void Register()
        {
            string storedProcedure = "usp_InsertUser";
            string hashedPassword = PasswordHelper.HashPassword(this.Password);

            SqlParameter[] userParams =
            {
                new SqlParameter("@UserType", UserType),
                new SqlParameter("@FirstName", FirstName),
                new SqlParameter("@LastName", LastName),
                new SqlParameter("@Address", Address),
                new SqlParameter("@ContactNo", ContactNo),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Password", hashedPassword),
                new SqlParameter("@UserId", SqlDbType.Int) { Direction = ParameterDirection.Output }  // Define the output parameter
            };

            // Execute the stored procedure
            DatabaseHelper.ExecuteNonQuery(storedProcedure, userParams, System.Data.CommandType.StoredProcedure);

            // Retrieve the generated UserId
            UserId = (int)userParams[7].Value;

            // Additional logic for adding to Customers or Admins table
            if (UserType.Equals("Customer", StringComparison.OrdinalIgnoreCase))
            {
                AddToCustomerTable();
            }
            else if (UserType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                AddToAdminTable();
            }
        }

        // User Login Method
        public virtual bool Login(string email, string password, out string userType)
        {
            userType = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT user_type, password, deleted FROM Users WHERE email = @Email";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        bool isDeleted = Convert.ToBoolean(reader["deleted"]);

                        if (isDeleted)
                        {
                            MessageBox.Show("Your account has been deleted. Please contact the admin.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        string storedHashedPassword = reader["password"].ToString();
                        if (PasswordHelper.VerifyPassword(storedHashedPassword, password))
                        {
                            userType = reader["user_type"].ToString();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No account found with this email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error during login: " + ex.Message);
            }

            return false;
        }

        // Admin Manage User Adding Customers using a stored procedure
        private void AddToCustomerTable()
        {
            string storedProcedure = "usp_InsertCustomer";
            SqlParameter[] customerParams =
            {
                new SqlParameter("@UserId", UserId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, customerParams, System.Data.CommandType.StoredProcedure);
        }

        // Admin manage User Adding Admins using a stored procedure
        private void AddToAdminTable()
        {
            string storedProcedure = "usp_InsertAdmin";
            SqlParameter[] adminParams =
            {
                new SqlParameter("@UserId", UserId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, adminParams, System.Data.CommandType.StoredProcedure);
        }

        // Method to update an existing user using a stored procedure
        public void UpdateUser()
        {
            string storedProcedure = "usp_UpdateUser";
            SqlParameter[] userParams =
            {
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@FirstName", FirstName),
                new SqlParameter("@LastName", LastName),
                new SqlParameter("@Address", Address),
                new SqlParameter("@ContactNo", ContactNo),
                new SqlParameter("@Email", Email)
            };

            // Execute the stored procedure
            DatabaseHelper.ExecuteNonQuery(storedProcedure, userParams, System.Data.CommandType.StoredProcedure);
        }

        // Method to permanently delete an existing user that are already temporary deleted
        public static void DeleteUser(int userId)
        {
            string storedProcedure = "usp_DeleteUser";
            SqlParameter[] userParams =
            {
                new SqlParameter("@UserId", userId)
            };

            // Execute the stored procedure
            DatabaseHelper.ExecuteNonQuery(storedProcedure, userParams, System.Data.CommandType.StoredProcedure);
        }

        // Temporary delete a user
        public static void TemporaryDeleteUser(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("UserId must be a positive number.", nameof(userId));

            try
            {
                string sql = "UPDATE Users SET deleted = 1 WHERE user_id = @UserId";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId", userId)
            };

                DatabaseHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while temporarily deleting the user.", ex);
            }
        }

        // Recover temporary deleted user
        public static void RecoverUser(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("UserId must be a positive number.", nameof(userId));

            try
            {
                string sql = "UPDATE Users SET deleted = 0 WHERE user_id = @UserId";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@UserId", userId)
                };

                DatabaseHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                // Log the exception and handle it appropriately
                throw new ApplicationException("An error occurred while recovering the user.", ex);
            }
        }

        // Update Password method
        public void UpdatePassword()
        {
            string storedProcedure = "usp_UpdateUserPassword"; // Assume you have a stored procedure to update the password
            SqlParameter[] userParams =
            {
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@Password", Password)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, userParams, CommandType.StoredProcedure);
        }

        // Search user method
        public static User SearchUser(int userId)
        {
            string sql = "SELECT * FROM Users WHERE user_id = @UserId";
            SqlParameter[] userParams =
            {
                new SqlParameter("@UserId", userId)
            };

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(sql, userParams))
            {
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = reader.GetInt32(0),
                        UserType = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        LastName = reader.GetString(3),
                        Address = reader.GetString(4),
                        ContactNo = reader.GetString(5),
                        Email = reader.GetString(6),
                        Password = reader.GetString(7)
                    };
                }
            }
            return null;
        }


        // Update user profile
        public void UpdateProfile()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sql = @"
                                UPDATE Users 
                                SET first_name = @FirstName, 
                                    last_name = @LastName, 
                                    address = @Address, 
                                    contact_no = @ContactNo, 
                                    email = @Email
                                WHERE user_id = @UserId";

                            SqlCommand cmd = new SqlCommand(sql, conn, tran);
                            cmd.Parameters.AddWithValue("@FirstName", FirstName);
                            cmd.Parameters.AddWithValue("@LastName", LastName);
                            cmd.Parameters.AddWithValue("@Address", Address);
                            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
                            cmd.Parameters.AddWithValue("@Email", Email);
                            cmd.Parameters.AddWithValue("@UserId", UserId);

                            cmd.ExecuteNonQuery();
                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw new ApplicationException("Error updating profile: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating profile: " + ex.Message);
            }
        }

        // User logout
        public void Logout(Form currentForm)
        {
            try
            {
                // Clear session data
                SessionManager.Logout();

                // Show success message
                Home.ShowAlert("You have been logged out successfully.", Alert.AlertType.Success);

                // Open the login form
                Login login = new Login();
                login.Show();

                // Close or hide the current form
                currentForm.Hide();
            }
            catch (Exception ex)
            {
                // Log the error (this can be to a file, event log, etc.)
                throw new ApplicationException("Error during logout: " + ex.Message);
            }
        }
    }
}
