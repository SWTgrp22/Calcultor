using NUnit.Framework;

namespace Calculator.Test.Unit
{
    public class Tests
    {
        private Calcultor.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calcultor.Calculator();
        }

        [TestCase(4, 4, 8)]
        [TestCase(4, 0, 4)]
        [TestCase(4, -4, 0)]
        [TestCase(4.2, 4.3, 8.5)]
        public void Add_aPlusb_ReturnsTheSum(double a, double b, double result)
        {
            //Arrange

            //Act
            double sum = uut.Add(a, b);

            //Assert
            Assert.That(sum, Is.EqualTo(result));

        }

        [TestCase(4, 4, 0)]
        [TestCase(4, 0, 4)]
        [TestCase(4, -4, 8)]
        [TestCase(4.2, 4.3, -0.1)]
        [TestCase(-3.2, 4.3, -7.5)]
        public void Subtract_aMinusb_ReturnsTheSum(double a, double b, double result)
        {
            //Arrange

            //Act
            double sum = uut.Subtract(a, b);

            //Assert
            Assert.That(sum, Is.EqualTo(result).Within(0.01));

        }

        [TestCase(4, 4, 16)]
        [TestCase(4, 0, 0)]
        [TestCase(4, -4, -16)]
        [TestCase(4.2, 4.3, 18.06)]
        [TestCase(-3.2, 4.3, -13.76)]
        public void Subtract_aMultiplyb_ReturnsTheSum(double a, double b, double result)
        {
            //Arrange

            //Act
            double sum = uut.Multiply(a, b);

            //Assert
            Assert.That(sum, Is.EqualTo(result));

        }

        [TestCase(4, 4, 256)]
        [TestCase(4, 0, 1)]
        [TestCase(4, -4, 0.0625)]
        [TestCase(4.2, 4.3, 478.599178)]
        public void Subtract_aPowerb_ReturnsTheSum(double x, double exp, double result)
        {
            //Arrange

            //Act
            double sum = uut.Power(x, exp);

            //Assert
            Assert.That(sum, Is.EqualTo(result).Within(0.1));

        }
    }
}