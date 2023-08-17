using System.Text;

namespace RetailApp.Utility.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string ToBase64(this string textToConvert)
        {
            if (string.IsNullOrWhiteSpace(textToConvert))
            {
                return textToConvert;
            }

            byte[] textToConvertAsBytes = Encoding.UTF8.GetBytes(textToConvert);
            return Convert.ToBase64String(textToConvertAsBytes);
        }
    }
}
