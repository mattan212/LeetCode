using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Problems41_50;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class RotateImageTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new int[,]
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };

            var expected = new int[,]
            {
                {7, 4, 1},
                {8, 5, 2},
                {9, 6, 3}
            };
            
            //Act
            var solver = new RotateImage.Solution();
            solver.Rotate(input);

            //Assert
            var length = input.GetLength(0);
            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    Assert.AreEqual(expected[i, j], input[i, j]);
                }
            }
        }
    }
}
