using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Interfaces;

namespace name_sorter.Library.Models
{
    public abstract class Message: IMessage
    {

        public enum MessageType
        {
            Error,
            Prompt
        }
        public abstract void DisplayMessage(string message);
        
    }
}
