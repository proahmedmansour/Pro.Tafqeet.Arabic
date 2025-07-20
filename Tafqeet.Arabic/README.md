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

## 📦 Installation

Install via [NuGet](https://www.nuget.org/packages/Pro.Tafqeet.Arabic):

```shell
# .NET CLI
 dotnet add package Pro.Tafqeet.Arabic

# Or via Package Manager
 Install-Package Pro.Tafqeet.Arabic
```

**Requirements:**
- .NET Standard 2.0+, .NET 6.0+, or .NET 9.0+

---

## 🌍 Supported Languages

| Language | Class                          | Example                          |
|----------|--------------------------------|----------------------------------|
| 🇸🇦 Arabic  | `ArabicNumberToTextConverter` | 123.45 → مئة وثلاثة وعشرون ريال و خمس وأربعون هللة فقط لا غير |
| 🇬🇧 English | `EnglishNumberToTextConverter` | 123.45 → One hundred twenty-three dollars and forty-five cents only |

---

## 🧾 Basic Usage (Arabic)

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
```

---

## ⚙️ API & Configuration

### TafqeetConverterFactory
- `INumberToTextConverter Create(TafqeetLanguage language = TafqeetLanguage.Arabic)`
  - Supported: `TafqeetLanguage.Arabic`, `TafqeetLanguage.English`

### INumberToTextConverter
- `string Convert(decimal number, TafqeetOptions options = null)`

### TafqeetOptions
| Option                  | Type           | Default                | Description                                  |
|-------------------------|----------------|------------------------|----------------------------------------------|
| `MainCurrency`          | CurrencyInfo   | SAR                    | Main currency (e.g., SAR, USD, EGP, AED)     |
| `SubCurrency`           | CurrencyInfo   | Halala                 | Subunit (e.g., Halala, Cent, Qirsh, Fils)    |
| `IncludeOnlyTextSuffix` | bool           | true                   | Add "فقط لا غير" / "only" at the end         |

### CurrencyRepository
Predefined currencies:
- `SAR`, `Halala` (Saudi Riyal)
- `USD`, `Cent` (US Dollar)
- `EGP`, `Qirsh` (Egyptian Pound)
- `AED`, `Fils` (UAE Dirham)

#### Custom Currencies
You can define your own:
```csharp
var myCurrency = new CurrencyInfo("دينار", "ديناران", "دنانير", false);
```

---

## 🧩 Extending the Library

- **Add new language:**
  - Implement `INumberToTextConverter` for your language.
  - Register it in `TafqeetConverterFactory`.
- **Add new currency:**
  - Create a new `CurrencyInfo` and use it in `TafqeetOptions`.

---

## 🚀 Advanced Usage

- **Gender Awareness:**
  - Arabic numbers and currencies can be masculine or feminine. Set `IsFeminine` in `CurrencyInfo`.
- **Pluralization:**
  - Handles singular, dual, and plural forms for currencies.
- **Suffix:**
  - Control the "only"/"فقط لا غير" suffix with `IncludeOnlyTextSuffix`.
- **Zero and edge cases:**
  - Zero is handled grammatically in both languages.

---

## 🧪 Testing

Run unit tests (from the solution root):
```shell
dotnet test
```

---

## 🤝 Contributing

1. Fork the repo and create your branch.
2. Add your feature or fix.
3. Add/modify tests as needed.
4. Submit a pull request.

For issues, suggestions, or feature requests, please use the [GitHub Issues](https://github.com/proahmedmansour/Pro.Tafqeet.Arabic/issues).

---

## 📁 Project Structure

- `Tafqeet.Arabic/` - Main library
  - `Converters/` - Number to text logic
  - `Config/` - Currencies, options
  - `Enums/` - Language enums
  - `INumberToTextConverter.cs` - Interface
  - `TafqeetConverterFactory.cs` - Factory
- `Tafqeet.Arabic.Tests/` - Unit tests

---

## 📄 License

MIT License. See [LICENSE.txt](LICENSE.txt).

---

## 🔗 Links
- [NuGet Package](https://www.nuget.org/packages/Pro.Tafqeet.Arabic)
- [GitHub Repository](https://github.com/proahmedmansour/Pro.Tafqeet.Arabic)
- [Report Issues](https://github.com/proahmedmansour/Pro.Tafqeet.Arabic/issues)

---

_Made with ❤️ by Ahmed Mansour_
