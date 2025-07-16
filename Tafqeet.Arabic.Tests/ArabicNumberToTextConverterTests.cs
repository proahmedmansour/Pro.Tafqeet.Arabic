using FluentAssertions;
using Pro.Tafqeet.Arabic.Config;

namespace Pro.Tafqeet.Arabic.Tests
{
    public class ArabicNumberToTextConverterTests
    {
        [Theory]
        [InlineData(0, "صفر ريال فقط لا غير")]
        [InlineData(1, "ريال فقط لا غير")]
        [InlineData(2, "ريالان فقط لا غير")]
        [InlineData(3, "ثلاثة ريالات فقط لا غير")]
        [InlineData(11, "أحد عشر ريال فقط لا غير")]
        [InlineData(100, "مئة ريال فقط لا غير")]
        public void Convert_IntegerAmounts_ShouldReturnCorrectText(decimal amount, string expected)
        {
            var result = TafqeetConverterFactory.Create().Convert(amount, new TafqeetOptions
            {
                MainCurrency = CurrencyRepository.SAR,
                SubCurrency = CurrencyRepository.Halala
            });

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(123.45, "مئة و ثلاثة و عشرون ريال و خمسة و أربعون هللة فقط لا غير")]
        [InlineData(0.5, "صفر ريال و خمسون هللة فقط لا غير")]
        [InlineData(1.01, "ريال و هللة فقط لا غير")]
        [InlineData(2.99, "ريالان و تسعة و تسعون هللة فقط لا غير")]
        public void Convert_WithFractions_ShouldReturnCorrectText(decimal amount, string expected)
        {
            var result = TafqeetConverterFactory.Create().Convert(amount, new TafqeetOptions
            {
                MainCurrency = CurrencyRepository.SAR,
                SubCurrency = CurrencyRepository.Halala
            });

            result.Should().Be(expected);
        }

        [Fact]
        public void Convert_WithUsdCurrency_ShouldReturnCorrectText()
        {
            var result = TafqeetConverterFactory.Create().Convert(12.34m, new TafqeetOptions
            {
                MainCurrency = CurrencyRepository.USD,
                SubCurrency = CurrencyRepository.Cent
            });

            result.Should().Be("اثنا عشر دولار و أربعة و ثلاثون سنت فقط لا غير");
        }
    }
}