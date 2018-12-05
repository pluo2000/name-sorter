using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using name_sorter.Library.Interfaces;
using name_sorter.Library.Models;
using name_sorter.UI.Console.Helpers;

namespace name_sorte.Tests
{
    public class FileStorageTest
    {

        [Fact]

        public void ReadData_ShouldCallStorage()
        {
            var dataSource = new Mock<IStorage>();
            dataSource.Setup(m => m.ReadData()).Returns("Anna Smith");
           
            var Helper = new ReadNamesHelper(dataSource.Object);   

            Helper.ReadNamesFromStorage();

            dataSource.Verify(m => m.ReadData(),Times.Once);




        }
    }
}
