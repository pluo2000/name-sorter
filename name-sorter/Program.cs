using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using name_sorter.UI.Console.Factories;
using name_sorter.Library.Helpers;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Models;
using name_sorter.UI.Console.Helpers;

namespace name_sorter.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileNamePathToWrite;
            ILogger logger = LogFactory.CreatLogger();
            IMessage errorMessage = MessageFactory.CreatMessage(Message.MessageType.Error);
            IDisplay display;
            NamesFile file;
            List<Name> names;

            try
            {
                //
                //Get file name/path from app.config
                //
                FileNamePathToWrite = ConfigurationManager.AppSettings["FileNamePathToWrite"];

                //
                //create screen display object from the factory
                //
                display = DisplayFactory.CreatDisplay();

                //
                //get file name and path for reading names from command parameter; file name and path for writing names to is set by program
                //
                file = FileInfoValidator.GetFile(args, FileNamePathToWrite);

                //
                //only proceed further if file is available 
                //
                if (file != null)
                {
                    
                    //
                    // get list of name object by reading
                    //
                    names = ReadNamesHelper.ReadNamesFromStorage(file);

                    //
                    //do sorting on names
                    //
                    names = NameSorter.Sort(names);

                   //
                   //writing sorted names to a storage
                   //
                    WriteNamesHelper.WriteNamesToStorage(file, names);


                    //
                    //display sorted name list on screen
                    //
                    display.DisplayName(names);
                }
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
                errorMessage.DisplayMessage(ex.Message);
            }
        }
    }
}
