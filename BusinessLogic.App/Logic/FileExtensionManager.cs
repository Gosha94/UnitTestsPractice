using BusinessLogic.App.Interfaces;
using System;

namespace BusinessLogic.App.Logic
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string currencyName)
        {
            if (string.IsNullOrEmpty(currencyName))
            {
                throw new ArgumentException("имя валюты должно быть задано");
            }

            if (!currencyName
                    .EndsWith(".Valuta", StringComparison.CurrentCultureIgnoreCase)
               )

            {
                return false;
            }

            return true;
        }
    }
}
