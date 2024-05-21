
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Services
{
    public static class EncDec
    {
        public static string Cryp(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }
        public static bool Decryp(string password, string passwordHash)
        {
            bool verified = BCrypt.Net.BCrypt.Verify(password, passwordHash);
            return verified;
        }

    }
}
