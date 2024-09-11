using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADCoursework1.Helper
{
    public static class ValidationHelper
    {
        // Validates an email address using a regular expression pattern.
        // The pattern ensures that the email contains a valid format like "example@domain.com"
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"; // Email format validation pattern
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email); // Returns true if the email matches the pattern
        }

        // Validates a password to ensure it contains at least:
        // one lowercase letter, one uppercase letter, one digit, one special character, and is at least 8 characters long
        public static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"; // Password complexity pattern
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password); // Returns true if the password matches the pattern
        }

        // Validates a contact number using a regular expression pattern.
        // The pattern supports formats like (123) 456-7890 or 123-456-7890
        public static bool IsValidContactNumber(string number)
        {
            string pattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"; // Contact number validation pattern
            Regex regex = new Regex(pattern);
            return regex.IsMatch(number); // Returns true if the contact number matches the pattern
        }
    }
}
