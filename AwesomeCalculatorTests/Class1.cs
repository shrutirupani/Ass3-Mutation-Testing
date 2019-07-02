using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input5point5and5point5_Returns11point0()
        {

            //Arrange
            double number1 = 5.5;
            double number2 = 5.5;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input8and4_Returns12()
        {

            //Arrange
            double number1 = 8;
            double number2 = 4;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_InputNegative5andNegative10_ReturnsNegative15()
        {

            //Arrange
            double number1 = -5;
            double number2 = -10;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input9point8and5point4_Returns5point4()
        {

            //Arrange
            double number1 = 9.8;
            double number2 = 5.4;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input22and11_Returns10()
        {

            //Arrange
            double number1 = 22;
            double number2 = 11;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_InputNegative9and5_ReturnsNegative4()
        {

            //Arrange
            double number1 = -9;
            double number2 = 5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input3point3and5point4_Returns17point82()
        {

            //Arrange
            double number1 = 3.3;
            double number2 = 5.4;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_InputNegative3andNegative5_ReturnsNegative15()
        {

            //Arrange
            double number1 = -3;
            double number2 = -5;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input2and5_Returns10()
        {

            //Arrange
            double number1 = 2;
            double number2 = 5;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input12and4_Returns3()
        {

            //Arrange
            double number1 = 12;
            double number2 = 4;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input25and5_Returns5()
        {

            //Arrange
            double number1 = 25;
            double number2 = 5;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input10and10_Returns1()
        {

            //Arrange
            double number1 = 10;
            double number2 = 10;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input1and3_Returns0point33()
        {

            //Arrange
            double number1 = 1;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input2and1_Returns2()
        {

            //Arrange
            double number1 = 2;
            double number2 = 1;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input9and3_Returns3()
        {

            //Arrange
            double number1 = 9;
            double number2 = 3;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
