using System;
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
            //double sum = uut.Add(a, b); -> f�r accumulator
            uut.Add(a, b);

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(result));

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
            //double sum = uut.Subtract(a, b); -> f�r accumulator
            uut.Subtract(a, b);

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(result).Within(0.01));

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
            //double sum = uut.Multiply(a, b);-> f�r accumulator
            uut.Multiply(a, b);

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(result));

        }

        [TestCase(4, 4, 256)]
        [TestCase(4, 0, 1)]
        [TestCase(4, -4, 0.0625)]
        [TestCase(4.2, 4.3, 478.599178)]
        public void Subtract_aPowerb_ReturnsTheSum(double x, double exp, double result)
        {
            //Arrange

            //Act
            //double sum = uut.Power(x, exp);-> f�r accumulator
            uut.Power(x, exp);

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(result).Within(0.1));

        }

        [TestCase(4, 4, 1)]
        [TestCase(4, -1, -4)]
        [TestCase(4, -4, -1)]
        [TestCase(4.2, 4.3, 0.9767)]
        public void Divide_aDevidedByb_ReturnsTheSum(double a, double b, double result)
        {
            //Arrange

            //Act
            //double sum = uut.Divide(a,b); -> f�r accumulator
            uut.Divide(a, b);

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(result).Within(0.0001));

        }

        [TestCase(4, 0)]
        [TestCase(7, 0)]
        [TestCase(4.2, 0)]
        public void Divide_aDivedBy0_ThrowsAnArgumentException(double a, double b)
        {
            //Arrange

            //Act
            var ex = Assert.Throws<ArgumentException>(() => uut.Divide(a, b));

            //Assert
            
            Assert.That(ex.Message, Is.EqualTo("Invalid number. V�rdien b skal v�re forskellig fra 0"));

        }

        [Test]
        public void Clear_Add_accumulatorIsEqualto0()
        {
            //Arrange

            //Act
            uut.Add(4, 4);
            uut.Clear();

            //Assert
            Assert.That(uut.accumulator,Is.EqualTo(0));
        }

        [Test]
        public void Clear_Subtract_accumulatorIsEqualto0()
        {
            //Arrange

            //Act
            uut.Subtract(4, 4);
            uut.Clear();

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_Multiply_accumulatorIsEqualto0()
        {
            //Arrange

            //Act
            uut.Multiply(4, 4);
            uut.Clear();

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(0));
        }
        [Test]
        public void Clear_Power_accumulatorIsEqualto0()
        {
            //Arrange

            //Act
            uut.Power(4, 4);
            uut.Clear();

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(0));
        }

        [TestCase(4,4)]
       // [TestCase(4,0)]
        public void Clear_Divide_accumulatorIsEqualto0(double a, double b)
        {
            //Arrange

            //Act
            uut.Divide(a, b);
            uut.Clear();

            //Assert
            Assert.That(uut.accumulator, Is.EqualTo(0));
        }

    }
}