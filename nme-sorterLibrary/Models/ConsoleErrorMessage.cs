using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Models
{
    public class ConsoleErrorMessage:Message
    {
        /// <summary>
        /// display an error message on console screen.
        /// </summary>
        /// <param name="message">error message in string</param>
        public override void DisplayMessage(string message)
        {
            Console.WriteLine("Error occured: " + message);
            Console.WriteLine("Press Enter key to exit");
            Console.ReadLine();
        }

    }
}
