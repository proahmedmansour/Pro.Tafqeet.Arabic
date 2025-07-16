using Pro.Tafqeet.Arabic.Config;

namespace Pro.Tafqeet.Arabic
{
    public interface INumberToTextConverter
    {
        string Convert(decimal number, TafqeetOptions? options = null);
    }
}