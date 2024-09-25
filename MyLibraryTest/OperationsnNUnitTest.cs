using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsnNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber()
        {
            //1. Arrange
            //Operations operations = new Operations();
            //perations operations = new();
            var operations = new Operations();
            int number1 = 2;
            int number2 = 5;
            int expectedResult = 7;

            //2 Act
            int result = operations.Add(number1,number2);

            //3. Assert
            Assert.That(result,Is.EqualTo(expectedResult));

        }
        [Test]
        public void isEven_InputNumber_ReturnTrue()
        {
            //1. Arrange
            Operations operations = new Operations();
            int number = 10;

            var result = operations.isEven(number);
            Assert.That(result, Is.True);
        }
    }
}
