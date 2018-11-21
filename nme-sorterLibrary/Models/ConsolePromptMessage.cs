using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Models
{
    public class ConsolePromptMessage : Message
    {
        /// <summary>
        /// Display a message on console screen
        /// </summary>
        /// <param name="message">message in string</param>
        public override void DisplayMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }

    }
}
