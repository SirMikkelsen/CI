using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCI.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            // Arrange
            Class1 c1 = new Class1();

            string actualResult = "Gordon";

            // Act
            var expectedResult = c1.GetName();

            // Assert

            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void GetAdress()
        {

            // Arrange
            Class1 c2 = new Class1();

            string actualResult = "Elisagaardsvej 5";

            // Act
            var expectedResult = c2.GetAdress();

            // Assert

            Assert.AreEqual(actualResult, expectedResult);

        }



    }
    
}