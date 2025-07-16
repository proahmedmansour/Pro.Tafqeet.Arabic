# Pro.Tafqeet.Arabic

**Tafqeet.Arabic** is a .NET library that converts numeric values to their Arabic textual representation (**تفقيط**) with full grammatical accuracy.

🔢 يدعم تحويل الأرقام إلى كلمات باللغة العربية بدقة نحوية، مع دعم العملات الأساسية والفرعية والمذكر/المؤنث.

---

## ✨ Features

- ✅ Convert integer and decimal numbers to Arabic words
- ✅ Supports singular, dual, and plural currency forms
- ✅ Supports both masculine and feminine grammatical forms
- ✅ Customizable currency configuration (ريال، دولار، جنيه، إلخ)
- ✅ Includes optional suffix ("فقط لا غير")

---

## 🧾 Example Usage

```csharp
using Pro.Tafqeet.Arabic;

var converter = new ArabicNumberToTextConverter();
var result = converter.Convert(1234.56m, new TafqeetOptions
{
    MainCurrency = CurrencyRepository.SAR,
    SubCurrency = CurrencyRepository.Halala
});

Console.WriteLine(result);
// Output: ألف ومئتان وأربعة وثلاثون ريال و ست وخمسون هللة فقط لا غير
