using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Models;

namespace name_sorter.Library.Interfaces
{
    public interface IDisplay
    {

        /// <summary>
        /// display names on the screen
        /// </summary>
        /// <param name="names">list of name object</param>
        void DisplayName(List<Name> names);
    }
}
