using Humanizer;
using Pro.Tafqeet.Arabic.Config;
using System.Globalization;

namespace Pro.Tafqeet.Arabic.Converters
{
    public class ArabicNumberToTextConverter : INumberToTextConverter
    {
        public string Convert(decimal number, TafqeetOptions? options = null)
        {
            options ??= new TafqeetOptions();

            long wholePart = (long)Math.Floor(number);
            decimal fraction = number - wholePart;

            string wholeText = ShouldSuppressNumber(wholePart) ? "" : ConvertNumber(wholePart, options.MainCurrency.IsFeminine);
            string result = FormatWithCurrency(wholeText, GetCurrencyWord(wholePart, options.MainCurrency));

            if (fraction > 0.00001m)
            {
                int fractionalPart = (int)Math.Round(fraction * 100);
                string fractionalText = ShouldSuppressNumber(fractionalPart) ? "" : ConvertNumber(fractionalPart, options.SubCurrency.IsFeminine);
                result += " و " + FormatWithCurrency(fractionalText, GetCurrencyWord(fractionalPart, options.SubCurrency));
            }

            if (options.IncludeOnlyTextSuffix)
                result += " فقط لا غير";

            return result;
        }

        private string ConvertNumber(long number, bool isFeminine)
        {
            return number.ToWords(new CultureInfo("ar"), isFeminine);
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

        private bool ShouldSuppressNumber(long number)
        {
            return number == 1 || number == 2;
        }

        private string FormatWithCurrency(string numberText, string currencyText)
        {
            return string.IsNullOrWhiteSpace(numberText)
                ? currencyText
                : $"{numberText} {currencyText}";
        }
    }
}