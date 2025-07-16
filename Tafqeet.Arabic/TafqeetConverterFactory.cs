using Pro.Tafqeet.Arabic.Converters;
using Pro.Tafqeet.Arabic.Enums;
using System;

namespace Pro.Tafqeet.Arabic
{
    public static class TafqeetConverterFactory
    {
        public static INumberToTextConverter Create(TafqeetLanguage language = TafqeetLanguage.Arabic)
        {
            switch (language)
            {
                case TafqeetLanguage.Arabic:
                    return new ArabicNumberToTextConverter();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}