using Tafqeet.Arabic.Config;

namespace Tafqeet.Arabic
{
    public interface INumberToTextConverter
    {
        string Convert(decimal number, TafqeetOptions? options = null);
    }
}