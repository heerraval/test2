using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace ClassLibrary1
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input3point4and5point6_Returns8point0()
            {
                //Arrange
                double number1 = 3.4;
                double number2 = 5.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input3point6and2point6_Returns6point2()
            {
                //Arrange
                double number1 = 3.6;
                double number2 = 2.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input5point4and9point6_Returns15point0()
            {
                //Arrange
                double number1 = 5.4;
                double number2 = 9.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input5point4and9point6_Returns4point2()
            {
                //Arrange
                double number1 = 5.4;
                double number2 = 9.6;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input6point3and4point1_Returns2point2()
            {
                //Arrange
                double number1 = 6.3;
                double number2 = 4.1;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtraction_Input2point1and1point1_Returns1point1()
            {
                //Arrange
                double number1 = 2.1;
                double number2 = 1.1;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input2point1and1point1_Returns2point3()
            {
                //Arrange
                double number1 = 2.1;
                double number2 = 1.1;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input8point9and3point4_Returns30point26()
            {
                //Arrange
                double number1 = 8.9;
                double number2 = 3.4;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiplication_Input6point9and4point4_Returns30point036()
            {
                //Arrange
                double number1 = 6.9;
                double number2 = 4.4;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input8point3and3point4_Returns1point8()
            {
                //Arrange
                double number1 = 8.3;
                double number2 = 4.4;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input5point3and4point2_Returns1point2()
            {
                //Arrange
                double number1 = 5.3;
                double number2 = 4.2;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input9point9and6point5_Returns1point52()
            {
                //Arrange
                double number1 = 9.9;
                double number2 = 6.5;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }


   
    }
}
