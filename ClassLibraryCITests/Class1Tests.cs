﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}