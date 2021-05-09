using BusinessLogic.App.Logic;
using NUnit.Framework;
using System;

namespace BusinessLogic.NUnit.Tests
{
    [TestFixture]
    [Category("BitcoinMainerTests")]
    class BitcoinMainerTests
    {
        /// <summary>
        /// Фабричный метод для создания экземпляра тестируемого класса
        /// </summary>
        /// <returns></returns>
        private BitcoinMainer MakeTestMainer()
        {
            return new BitcoinMainer();
        }

        [Test]
        public void IsValidCoinName_BadCoinName_ReturnsFalse()
        {
            BitcoinMainer testMainer = new BitcoinMainer();
            bool result = testMainer.IsValidCoinName("BadCurrencyName");
            Assert.False(result);
        }

        [Test]
        public void IsValidCoinName_EmptyCoinName_Throws()
        {
            BitcoinMainer testMainer = new BitcoinMainer();

            //  Если код внутри лямбда-выражения возбуждает исключение, то тест проходит.
            //  Если исключение возбуждает какая-то строка вне лямбда - выражения, то тест не проходит.
            var exception = Assert.Catch<Exception>( () => testMainer.IsValidCoinName("") );            
        }

        [Test]
        [Ignore("Тест устарел, не нужен")]
        public void IsValidCoinName_ValidFile_ReturnsTrue()
        {
            /// Тест будет игнорироваться, не положив остальные тесты, но не рекомендуется так делать!!!
        }

        [Test]
        [Ignore("Тест устарел, версия 1.0")]
        public void IsValidCoinName_WhenCalled_ChangesWasLastCoinNameValid_OldVersion()
        {
            BitcoinMainer testMainer = new BitcoinMainer();
            testMainer.IsValidCoinName("BadCurrencyName");
            Assert.False(testMainer.WasLastCoinNameValid);
        }

        [TestCase("BadCurrencyName", false)]
        [TestCase("GoodCurrencyName.Valuta", true)]
        public void IsValidCoinName_WhenCalled_ChangesWasLastCoinNameValid(string coinName, bool expected)
        {
            BitcoinMainer testMainer = MakeTestMainer();
            testMainer.IsValidCoinName(coinName);
            
            Assert.AreEqual(expected, testMainer.WasLastCoinNameValid);
        }
    }
}