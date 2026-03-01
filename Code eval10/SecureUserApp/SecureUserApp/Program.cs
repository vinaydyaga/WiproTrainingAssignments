using SecureUserApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureUserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthService auth = new AuthService();

            auth.Register("vinay", "password123");

            bool login = auth.Authenticate("vinay", "password123");

            if (login)
                Console.WriteLine("Login Successful");
            else
                Console.WriteLine("Login Failed");

            string encrypted = EncryptionService.Encrypt("SensitiveData");
            Console.WriteLine("Encrypted: " + encrypted);

            string decrypted = EncryptionService.Decrypt(encrypted);
            Console.WriteLine("Decrypted: " + decrypted);
        }
    }
}
