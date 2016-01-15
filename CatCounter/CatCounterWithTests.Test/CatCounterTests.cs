using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatCounter;

namespace CatCounterWithTests.Test {
    [TestClass]
    public class CatCounterTests {
        [TestMethod]
        public void TestCountCats() {

            //Arrange
            var cat = new CountAllCats();
            //Act
            var result = cat.CountCats("The cat in the cats box is such a kitty cat.");
            //Assert
            Assert.AreEqual(3, result);



        }
    }
}
