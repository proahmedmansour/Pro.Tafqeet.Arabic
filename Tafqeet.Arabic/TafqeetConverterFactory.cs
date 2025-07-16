using Pro.Tafqeet.Arabic.Enums;

namespace Pro.Tafqeet.Arabic
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