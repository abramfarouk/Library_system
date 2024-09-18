using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class PasswordHaser
    {
        // Constants
        private const int SaltSize = 16; // 128 bit 
        private const int KeySize = 32;  // 256 bit
        private const int Iterations = 10000; // Number of iterations

        public static string HashPassword(string password)
        {
            // Generate a salt
            using (var rng = new RNGCryptoServiceProvider())
            {
                var saltBytes = new byte[SaltSize];
                rng.GetBytes(saltBytes);
                var salt = Convert.ToBase64String(saltBytes);

                // Hash the password with the salt
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations))
                {
                    var hash = pbkdf2.GetBytes(KeySize);
                    return $"{Iterations}.{salt}.{Convert.ToBase64String(hash)}";
                }
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Split the stored hash into its components
            var parts = storedHash.Split('.');
            var iterations = int.Parse(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var storedPasswordHash = Convert.FromBase64String(parts[2]);

            // Hash the entered password using the stored salt
            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, iterations))
            {
                var hash = pbkdf2.GetBytes(KeySize);
                // Compare the computed hash with the stored hash
                return AreHashesEqual(hash, storedPasswordHash);
            }
        }

        private static bool AreHashesEqual(byte[] hash1, byte[] hash2)
        {
            var diff = (uint)hash1.Length ^ (uint)hash2.Length;
            for (var i = 0; i < hash1.Length && i < hash2.Length; i++)
                diff |= (uint)(hash1[i] ^ hash2[i]);
            return diff == 0;
        }
    }
}
