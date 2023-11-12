using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RentMeFurnitureRentalSystem.Utils
{
    public static class PasswordHasher
    {
        

        public static string HashPassword(string password)
        {
            var hasher = new PasswordHasher<string>();

            return hasher.HashPassword(null, password);
        }

        public static PasswordVerificationResult CheckHashedPassword(string hashedPassword,string inputtedPassword)
        {
            var hasher = new PasswordHasher<string>();

            return hasher.VerifyHashedPassword(null, hashedPassword, inputtedPassword);
        }
    }
}
