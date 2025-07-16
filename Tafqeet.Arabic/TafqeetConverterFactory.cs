using Tafqeet.Arabic.Converters;
using Tafqeet.Arabic.Enums;

namespace Tafqeet.Arabic
{
    public static class TafqeetConverterFactory
    {
        public static INumberToTextConverter Create(TafqeetLanguage language = TafqeetLanguage.Arabic)
        {
            return language switch
            {
                TafqeetLanguage.Arabic => new ArabicNumberToTextConverter(),
                _ => throw new NotImplementedException()
            };
        }
    }
}