using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Library.Models
{
    public class Name
    {
        //string lastName;
        //string firstName;
        public Name()
        {

        }

        public Name(string firstname,string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public string LastName { get; set; }

        public string FirstName { get; set; }
    }
}
