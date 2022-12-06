using System;

namespace BusinessLogic.App.Logic
{
    /// <summary>
    /// Сущность майнера валюту для Unit - тестирования
    /// </summary>
    public class BitcoinMainer
    {
        /// <summary>
        /// Свойство, которое хранит результат последнего обращения к методу валидации
        /// </summary>
        public bool WasLastCoinNameValid { get; set; }

        /// <summary>
        /// Метод проверяет наименование валюты на корректность
        /// </summary>
        /// <returns></returns>
        public bool IsValidCoinName(string coinName)
        {
            this.WasLastCoinNameValid = false;

            FileExtensionManager manager = new FileExtensionManager();

            var result = manager.IsValid(coinName);

            this.WasLastCoinNameValid = manager.IsValid(coinName);

            return this.WasLastCoinNameValid;
        }
    }
}
