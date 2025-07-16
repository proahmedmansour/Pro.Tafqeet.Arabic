# Tafqeet (تفقيط) - Number to Words Converter

**Tafqeet** is a multilingual .NET library that converts numeric values into their **textual representation** for purposes like check writing, receipts, and official documents.

🔢 مكتبة .NET لتحويل الأرقام إلى كلمات (تفقيط) باللغة العربية والإنجليزية، مع دعم العملات والقواعد النحوية الصحيحة.

---

## ✨ Features

- ✅ Converts integers and decimals to words
- ✅ Supports **Arabic** and **English**
- ✅ Currency-aware (main and sub-units)
- ✅ Correct singular, dual, and plural forms
- ✅ Gender-aware in Arabic (masculine/feminine)
- ✅ Optional suffix: "فقط لا غير" / "only"
- ✅ Easily extendable to other languages

---

## 🌍 Supported Languages

| Language | Class                          | Example                          |
|----------|--------------------------------|----------------------------------|
| 🇸🇦 Arabic  | `ArabicNumberToTextConverter` | 123.45 → مئة وثلاثة وعشرون ريال و خمس وأربعون هللة فقط لا غير |
| 🇬🇧 English | `EnglishNumberToTextConverter` | 123.45 → One hundred twenty-three dollars and forty-five cents only |

---

## 🧾 Example Usage (Arabic)

```csharp
using Tafqeet.Arabic;

var converter = TafqeetConverterFactory.Create(TafqeetLanguage.Arabic);

var result = converter.Convert(1234.56m, new TafqeetOptions
{
    MainCurrency = CurrencyRepository.SAR,
    SubCurrency = CurrencyRepository.Halala
});

Console.WriteLine(result);
// → ألف ومئتان وأربعة وثلاثون ريال و ست وخمسون هللة فقط لا غير
