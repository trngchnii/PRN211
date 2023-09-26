using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger instance;
        private List<string> logs = new List<string>();

        private Logger() { }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            logs.Add(message);
        }

        public void PrintLogs()
        {
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
