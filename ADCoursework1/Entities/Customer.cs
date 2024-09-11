using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class Customer : User
    {
        // Constructor
        public Customer(string connectionString) : base(connectionString)
        {
        }

        // Override the Login method with Customer-specific logic
        public override bool Login(string email, string password, out string userType)
        {
            // Customer-specific logic, if any (e.g., additional checks)
            userType = "Customer";

            // Call the base Login method to handle common login functionality
            return base.Login(email, password, out userType);
        }
    }
}
