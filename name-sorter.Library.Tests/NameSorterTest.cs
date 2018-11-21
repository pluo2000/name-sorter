using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Helpers;
using name_sorter.Library.Models;
using Xunit;

namespace name_sorte.Tests
{
    public class NameSorterTest
    {

        [Fact]
        public void Sort_NamesShouldSort()
        {
            //
            //names for testing
            //
            Name name1 = new Name("John", "Smith");
            Name name2 = new Name("Jake Jackson", "Lee");
            Name name3 = new Name("Rob", "Smyth");
            Name name4 = new Name("Angela", "Nash");


            //
            //unsorted name list
            //
            List<Name> unsorted = new List<Name>();
            unsorted.Add(name1);
            unsorted.Add(name2);
            unsorted.Add(name3);
            unsorted.Add(name4);


            //
            //sorted name list
            //
            List<Name> expected = new List<Name>();
            expected.Add(name2);
            expected.Add(name4);
            expected.Add(name1);
            expected.Add(name3);
           

            //
            //actual sorted name list
            //
            List<Name> actual = NameSorter.Sort(unsorted);

            //
            //Assert
            //
            Assert.Equal(expected, actual);

        }

    }
}
