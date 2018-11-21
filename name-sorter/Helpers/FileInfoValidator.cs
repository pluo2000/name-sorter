using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.UI.Console.Factories;
using System.IO;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Models;

namespace name_sorter.UI.Console.Helpers
{
    public class FileInfoValidator
    {
       /// <summary>
       /// get file name/path from command parameter,otherwise display an error mesasge
       /// </summary>
       /// <param name="args">commad parameters</param>
       /// <param name="writeFilePath"></param>
       /// <returns></returns>
        public static NamesFile GetFile(string[] args, string writeFilePath)
        {
            NamesFile file = null;

            //
            //first command parameter is file name/path for reading names 
            //
            int argsReadFileElementIndex = 0;

            //
            //create a error message object from the factory
            //
            IMessage errorMessage = MessageFactory.CreatMessage(Message.MessageType.Error);

            //
            //if command parameter is not suppied or file does not exist,give an error message on screen.
            //otherwise return the file object 
            //
            if (args.Length == 0 || string.IsNullOrEmpty(args[argsReadFileElementIndex]))
            {
                errorMessage.DisplayMessage("No unsorted names file path being supplied!");
            }
            else if (!File.Exists(args[argsReadFileElementIndex]))
            {
                errorMessage.DisplayMessage("File not existed " + args[argsReadFileElementIndex]);
            }
            else
            {
                file = new NamesFile(args[argsReadFileElementIndex], writeFilePath);
            }

            return file;
        }
    }

}
