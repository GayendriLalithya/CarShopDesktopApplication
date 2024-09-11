using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class Admin : User
    {
        // Constructor
        public Admin(string connectionString) : base(connectionString)
        {
        }

        // Override the Login method with Admin-specific logic
        public override bool Login(string email, string password, out string userType)
        {
            // Admin-specific logic, if any (e.g., additional checks)
            userType = "Admin";

            // Call the base Login method to handle common login functionality
            return base.Login(email, password, out userType);
        }
    }

}
