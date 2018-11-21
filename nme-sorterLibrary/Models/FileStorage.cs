using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Globals;

namespace name_sorter.Library.Models
{
    public class FileStorage : IStorage
    {
        private NamesFile _file;
        public FileStorage(NamesFile file)
        {
            _file = file;
        }

       /// <summary>
       /// read content from a file storage
       /// </summary>
       /// <returns>content in string</returns>
        public string ReadData()
        {
            String line;
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(_file.ReadFilePath);

            //Read the first line of text
            line = sr.ReadLine();

            //Continue to read until you reach end of file
            while (line != null)
            {
              
                //
                //put a separator after line so the content can be split
                //
                sb.Append(line + Constants.NAMES_SEPARATOR);

                //Read the next line
                line = sr.ReadLine();
               
            }

            
            return sb.ToString();
        }

        /// <summary>
        /// Write the content to a file storage
        /// </summary>
        /// <param name="namesString">content to write</param>
        public void WriteData(string namesString)
        {
            StreamWriter sw = new StreamWriter(_file.WriteFilePath, false);
            try
            {
                sw.WriteLine(namesString);
            }
            finally
            {
                //Close the file
                sw.Close();
            }
            
        }
    }
}
