using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Contributions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CountValleysTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = "UDDDUDUU";
            var expected = 1;

            //Act
            var solver = new CountingValleys();
            var res = solver.CountValleys(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var input = "DDDUUUUD";
            var expected = 1;

            //Act
            var solver = new CountingValleys();
            var res = solver.CountValleys(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var input = "DUDDUUDDDUUUDDDDUUUUDDDDDUUUUU";
            var expected = 5;

            //Act
            var solver = new CountingValleys();
            var res = solver.CountValleys(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var input = "UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD";
            var expected = 0;

            //Act
            var solver = new CountingValleys();
            var res = solver.CountValleys(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var input = "";
            var expected = 0;

            //Act
            var solver = new CountingValleys();
            var res = solver.CountValleys(input);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
