using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Models
{
    public class NamesFile
    {
        private string _readFilePath = "";
        private string _writeFilePath;
        public NamesFile(string filePathToRead,string filePathToWrite)
        {
            ReadFilePath = filePathToRead;
            WriteFilePath = filePathToWrite;
        }

        public string ReadFilePath
        {
            get
            {
                return _readFilePath;
            }
            set
            {
                _readFilePath = value;
            }
        }
        public string WriteFilePath
        {
            get
            {
                return _writeFilePath;
            }
            set
            {
                _writeFilePath = value;
            }

        }

    }
}
