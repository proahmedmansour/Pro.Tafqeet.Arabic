using Humanizer;
using System.Globalization;

namespace Tafqeet.Arabic
{
    public class ArabicNumberToTextConverter : INumberToTextConverter
    {
        public string Convert(decimal number, TafqeetOptions? options = null)
        {
            options ??= new TafqeetOptions();

            long wholePart = (long)Math.Floor(number);
            decimal fraction = number - wholePart;

            string wholeText = ConvertNumber(wholePart, options.MainCurrency.IsFeminine);
            string result = $"{wholeText} {GetCurrencyWord(wholePart, options.MainCurrency)}";

            if (fraction > 0.00001m)
            {
                int fractionalPart = (int)Math.Round(fraction * 100);
                string fractionalText = ConvertNumber(fractionalPart, options.SubCurrency.IsFeminine);
                result += $" و {fractionalText} {GetCurrencyWord(fractionalPart, options.SubCurrency)}";
            }

            if (options.IncludeOnlyTextSuffix)
                result += " فقط لا غير";

            return result;
        }

        private string ConvertNumber(long number, bool isFeminine)
        {
            var culture = new CultureInfo("ar");
            return number.ToWords(culture, isFeminine);
        }

        private string GetCurrencyWord(long number, CurrencyInfo currency)
        {
            return number switch
            {
                1 => currency.Singular,
                2 => currency.Dual,
                >= 3 and <= 10 => currency.Plural,
                _ => currency.Singular
            };
        }
    }
}