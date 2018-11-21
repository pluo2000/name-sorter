using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Models;

namespace name_sorter.Library.Helpers
{
    public class NameSorter
    {

        public static List<Name> Sort(List<Name> names)
        {
            return names.ToArray().OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToArray().ToList();
        }

    }
}
