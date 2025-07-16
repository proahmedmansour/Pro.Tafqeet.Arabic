namespace Tafqeet.Arabic.Config
{
    public static class CurrencyRepository
    {
        public static readonly CurrencyInfo SAR = new("ريال", "ريالان", "ريالات", false);
        public static readonly CurrencyInfo Halala = new("هللة", "هللتان", "هللات", true);

        public static readonly CurrencyInfo USD = new("دولار", "دولاران", "دولارات", false);
        public static readonly CurrencyInfo Cent = new("سنت", "سنتان", "سنتات", false);

        public static readonly CurrencyInfo EGP = new("جنيه", "جنيهان", "جنيهات", false);
        public static readonly CurrencyInfo Qirsh = new("قرش", "قرشان", "قروش", false);

        public static readonly CurrencyInfo AED = new("درهم", "درهمان", "دراهم", false);
        public static readonly CurrencyInfo Fils = new("فلس", "فلسان", "فلوس", false);
    }
}