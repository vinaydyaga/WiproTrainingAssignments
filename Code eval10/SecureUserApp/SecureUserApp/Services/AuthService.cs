using SecureUserApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureUserApp.Services
{
    public class AuthService
    {
        private List<User> users = new List<User>();

        public bool Register(string username, string password)
        {
            try
            {
                if (users.Exists(u => u.Username == username))
                    return false;

                string hashedPassword = PasswordHelper.HashPassword(password);
                users.Add(new User(username, hashedPassword));
                LoggerService.LogInfo("User registered successfully.");
                return true;
            }
            catch (Exception ex)
            {
                LoggerService.LogError(ex);
                return false;
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                var user = users.Find(u => u.Username == username);
                if (user == null)
                    return false;

                string hashedPassword = PasswordHelper.HashPassword(password);
                return user.HashedPassword == hashedPassword;
            }
            catch (Exception ex)
            {
                LoggerService.LogError(ex);
                return false;
            }
        }
    }
}
