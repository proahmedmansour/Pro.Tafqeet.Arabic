namespace Pro.Tafqeet.Arabic.Config
{
    public class TafqeetOptions
    {
        public CurrencyInfo MainCurrency { get; set; } = CurrencyRepository.SAR;
        public CurrencyInfo SubCurrency { get; set; } = CurrencyRepository.Halala;
        public bool IncludeOnlyTextSuffix { get; set; } = true;
    }
}