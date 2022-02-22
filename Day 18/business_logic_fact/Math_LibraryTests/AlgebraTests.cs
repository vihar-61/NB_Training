using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_zero_input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

            //Assert.Fail();
        }
        [TestMethod()]
        public void FactorialTest_one_to_seven_input()
        {
            //Arrange
            int n = 6;
            int expected = 720;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_negative_input()
        {
            //Arrange
            int n = -61;
            int expected = -9999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_greater_than_seven_input()
        {
            //Arrange
            int n = 61;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Palindrome_test_input()
        {
            //Arrange
            int n = 14541;
            bool expected = true;

            //Act
            bool actual = Algebra.IsPalindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}