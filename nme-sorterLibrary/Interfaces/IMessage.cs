using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Interfaces
{
    public interface IMessage
    {
        /// <summary>
        /// display message on the media
        /// </summary>
        /// <param name="message">message in string</param>
        void DisplayMessage(string message);

    }
}
