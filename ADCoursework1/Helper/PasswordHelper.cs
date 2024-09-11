using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Helper
{
    internal class PasswordHelper
    {
        // Constants for password hashing: Salt size (128 bits), key size (256 bits), and PBKDF2 iteration count
        private const int SaltSize = 16; // 128 bit
        private const int KeySize = 32; // 256 bit
        private const int Iterations = 10000; // Number of PBKDF2 iterations

        // Hashes the password using PBKDF2 algorithm with SHA256 and returns the hashed password as a Base64 string
        public static string HashPassword(string password)
        {
            // Create an Rfc2898DeriveBytes object to hash the password with the specified salt size, iterations, and SHA256
            using (var algorithm = new Rfc2898DeriveBytes(
                password, // The password to hash
                SaltSize, // Salt size (in bytes)
                Iterations, // Number of PBKDF2 iterations
                HashAlgorithmName.SHA256)) // Hashing algorithm
            {
                // Generate the salt used in hashing
                var salt = algorithm.Salt;

                // Generate the key (derived hash of the password)
                var key = algorithm.GetBytes(KeySize);

                // Combine salt and key into a single byte array
                var hashBytes = new byte[SaltSize + KeySize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize); // Copy salt to the beginning of the array
                Array.Copy(key, 0, hashBytes, SaltSize, KeySize); // Append key after the salt

                // Convert the combined salt and key to a Base64 string for storage
                var base64Hash = Convert.ToBase64String(hashBytes);
                return base64Hash; // Return the hashed password in Base64 format
            }
        }

        // Verifies a password by comparing the provided plain text password to the stored hashed password
        public static bool VerifyPassword(string hashedPassword, string password)
        {
            // Decode the stored Base64 hashed password to a byte array
            var hashBytes = Convert.FromBase64String(hashedPassword);

            // Extract the salt from the hash (first part of the array)
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Recreate the PBKDF2 algorithm with the extracted salt and the plain text password to be verified
            using (var algorithm = new Rfc2898DeriveBytes(
                password, // The plain text password to verify
                salt, // The extracted salt used during hashing
                Iterations, // The number of iterations
                HashAlgorithmName.SHA256)) // The hash algorithm used
            {
                // Generate the key (derived hash) from the plain text password and extracted salt
                var key = algorithm.GetBytes(KeySize);

                // Compare each byte of the key with the stored hash to check if the password is valid
                for (int i = 0; i < KeySize; i++)
                {
                    // If any byte doesn't match, return false (password is incorrect)
                    if (hashBytes[SaltSize + i] != key[i])
                    {
                        return false;
                    }
                }
                // If all bytes match, return true (password is correct)
                return true;
            }
        }
    }
}
