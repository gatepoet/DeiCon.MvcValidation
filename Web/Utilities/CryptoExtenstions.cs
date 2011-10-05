using System.Text;

namespace MvcValidation.Web.Utilities
{
    internal static class CryptoExtenstions
    {
        internal static byte[] AsBytes(this string text)
        {
            return Encoding.ASCII.GetBytes(text);
        }
        internal static string AsString(this byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }
    }
}