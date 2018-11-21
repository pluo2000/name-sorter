using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Interfaces
{
    public interface ILogger
    {

        /// <summary>
        /// Log the message in a storage
        /// </summary>
        /// <param name="message">message in string</param>
        void Log(String message);

    }
}
