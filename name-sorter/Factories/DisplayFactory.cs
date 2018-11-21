using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Models;

namespace name_sorter.UI.Console.Factories
{
    public class DisplayFactory
    {

        public static IDisplay CreatDisplay()
        {
            return new ConsoleDisplay();
        }

    }
}
