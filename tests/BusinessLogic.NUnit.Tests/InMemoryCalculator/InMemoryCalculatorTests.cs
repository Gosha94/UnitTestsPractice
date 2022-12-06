using BusinessLogic.App.Logic;
using NUnit.Framework;
using System;

namespace BusinessLogic.NUnit.Tests
{
    [TestFixture]
    [Category("InMemoryCalculatorTests")]
    class InMemoryCalculatorTests
    {
        /// <summary>
        /// Фабричный метод для создания экземпляра тестируемого класса
        /// </summary>
        /// <returns></returns>
        private InMemoryCalculator MakeTestInMemoryCalculator()
        {
            return new InMemoryCalculator();
        }

        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            // Arrange
            InMemoryCalculator testCalc = MakeTestInMemoryCalculator();
            // Act
            int lastSum = testCalc.FinalSum();
            // Assert
            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            InMemoryCalculator testCalc = MakeTestInMemoryCalculator();

            testCalc.Add(1);
            int sum = testCalc.FinalSum();

            Assert.AreEqual(1, sum);
        }

    }
}
