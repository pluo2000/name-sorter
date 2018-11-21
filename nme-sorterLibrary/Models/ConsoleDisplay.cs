using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Models;

namespace name_sorter.Library.Models
{
    public class ConsoleDisplay:IDisplay
    {
     
        /// <summary>
        /// Display name list on console screen
        /// </summary>
        /// <param name="names">list of name object</param>
        public void DisplayName(List<Name> names)
        {
            Console.WriteLine();
            Console.WriteLine("Sorted name list:");
            Console.WriteLine();
            foreach (Name name in names)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
            Console.ReadLine();
        }
    }

}
