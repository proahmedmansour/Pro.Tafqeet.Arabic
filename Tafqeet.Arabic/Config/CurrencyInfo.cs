namespace Pro.Tafqeet.Arabic.Config
{
    public class CurrencyInfo
    {
        public string Singular { get; set; }         // ريال
        public string Dual { get; set; }             // ريالان
        public string Plural { get; set; }           // ريالات
        public bool IsFeminine { get; set; }         // false = مذكر

        public CurrencyInfo(string singular, string dual, string plural, bool isFeminine)
        {
            Singular = singular;
            Dual = dual;
            Plural = plural;
            IsFeminine = isFeminine;
        }
    }
}