namespace Pro.Tafqeet.Arabic.Config
{
    public static class CurrencyRepository
    {
        public static readonly CurrencyInfo SAR = new CurrencyInfo("ريال", "ريالان", "ريالات", false);
        public static readonly CurrencyInfo Halala = new CurrencyInfo("هللة", "هللتان", "هللات", true);

        public static readonly CurrencyInfo USD = new CurrencyInfo("دولار", "دولاران", "دولارات", false);
        public static readonly CurrencyInfo Cent = new CurrencyInfo("سنت", "سنتان", "سنتات", false);

        public static readonly CurrencyInfo EGP = new CurrencyInfo("جنيه", "جنيهان", "جنيهات", false);
        public static readonly CurrencyInfo Qirsh = new CurrencyInfo("قرش", "قرشان", "قروش", false);

        public static readonly CurrencyInfo AED = new CurrencyInfo("درهم", "درهمان", "دراهم", false);
        public static readonly CurrencyInfo Fils = new CurrencyInfo("فلس", "فلسان", "فلوس", false);
    }
}