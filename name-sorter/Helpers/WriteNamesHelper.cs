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
    public class WriteNamesHelper
    {
        /// <summary>
        /// Write the list of name to storage
        /// </summary>
        /// <param name="file">file name and path</param>
        /// <param name="names">list of name object</param>
        public static void WriteNamesToStorage(NamesFile file,List<Name> names)
        {
            
            string namesString;

            //
            //create storage and message object from the factory
            //
            IStorage storage = StorageFactory.CreatStorage(file);
            IMessage promptMessage = MessageFactory.CreatMessage(Message.MessageType.Prompt);

           
            //
            //convert list of name object to a string
            //
            namesString = NamesStringConverter.ConvertNamesToString(names);

            //
            //write names string to storage 
            //
            storage.WriteData(namesString);

            //
            //give user a message of writing completion at the end 
            //
            promptMessage.DisplayMessage("Writing data to " + file.WriteFilePath + " is completed");

        }
    }
}
