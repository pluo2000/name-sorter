using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Models;
using name_sorter.Library.Interfaces;
using name_sorter.UI.Console.Factories;
using name_sorter.Library.Helpers;

namespace name_sorter.UI.Console.Helpers
{
    public class ReadNamesHelper
    {
        private IStorage storage;

        public ReadNamesHelper(IStorage store)
        {
            storage = store;
        }

        /// <summary>
        /// Help read data from a storage; convert data into list of name object
        /// </summary>
        /// <param name="file">storage file</param>
        /// <returns></returns>
        public List<Name> ReadNamesFromStorage()
        {  
            string namesString;
            List<Name> names;
            //
            //read name list into a string from a storage
            //
            namesString = storage.ReadData();

            //
            //make a list of name object from the names in string
            //
            names = NamesStringConverter.ConvertStringToNames(namesString);

            return names;
        }

        

    }
}
