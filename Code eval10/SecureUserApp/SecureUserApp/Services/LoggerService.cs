using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecureUserApp.Services
{
    public static class LoggerService
    {
        private static string filePath = "log.txt";

        public static void LogError(Exception ex)
        {
            File.AppendAllText(filePath,
                $"{DateTime.Now} ERROR: {ex.Message}\n{ex.StackTrace}\n");
        }

        public static void LogInfo(string message)
        {
            File.AppendAllText(filePath,
                $"{DateTime.Now} INFO: {message}\n");
        }
    }
}
