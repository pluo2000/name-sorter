using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Models
{
    public class Names
    {
        private static readonly Names _instance = new Names();

        private Names()
        {

        }
        public static Names Instance()
        {
            return _instance;
        }

        public List<Name> UnSortedNames { get; set; }

        public List<Name> SortedNames { get; set; }
    }
}
