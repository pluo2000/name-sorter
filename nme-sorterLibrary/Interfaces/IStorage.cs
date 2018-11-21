using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Models;

namespace name_sorter.Library.Interfaces
{
    public interface IStorage
    {
        /// <summary>
        /// read content from a stoarage
        /// </summary>
        /// <returns>content in string</returns>
        string ReadData();

        /// <summary>
        /// Write content of string into a storage
        /// </summary>
        /// <param name="namesString">content to write</param>
        void WriteData(string namesString);

    }
}
