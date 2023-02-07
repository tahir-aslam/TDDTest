using NUnit.Framework;
using System;

namespace TDDTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 3, 125)]

        public void Add_Input_RetursPowerOfInput(double baseValue, double exponent, double expected)
        {
            double result = Formula.MathPower(baseValue, exponent);

            Assert.That(result, Is.EqualTo(expected));
        }      
    }

    internal class Formula
    {
        internal static double MathPower(double baseValue, double exponent)
        {
            double baseValueTotal = baseValue;

            for (int i = 1; i < exponent; i++)
            {
                baseValueTotal = baseValueTotal * baseValue;
            }

            double result = baseValueTotal;
            return result;
        }
    }
}