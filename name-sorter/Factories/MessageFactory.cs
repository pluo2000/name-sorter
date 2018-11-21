using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Models;

namespace name_sorter.UI.Console.Factories
{
    public static class MessageFactory
    {

        public static IMessage CreatMessage(Message.MessageType type)
        {
            if (type==Message.MessageType.Error)
            {
                return new ConsoleErrorMessage();
            }
            else
            {
                return new ConsolePromptMessage();
            }
        }
    }
}
