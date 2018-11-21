using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using name_sorter.Library.Interfaces;

namespace name_sorter.Library.Models
{
    public class FileLogger:ILogger
    {
        private const string logFilePath = "./log.txt";

        /// <summary>
        /// Log the message in log.txt
        /// </summary>
        /// <param name="message">message to log</param>
        public void Log(String message)
        {
            StreamWriter sw = new StreamWriter(logFilePath, true);
            try
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(message);
                sw.WriteLine(Environment.NewLine);
            }

            finally
            {
                sw.Close();
            }

        }
    }
}
