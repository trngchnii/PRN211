using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();

            // Log some events
            logger.Log("Application started.");
            logger.Log("User logged in.");
            logger.Log("Error: Invalid input detected.");

            // Print logs
            logger.PrintLogs();
        }
    }
}
