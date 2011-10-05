using System.Diagnostics;
using System.Security.Cryptography;

namespace MvcValidation.Web.Utilities
{
    public static class Crypto
    {
        [DebuggerHidden]
        private static byte[] Encrypt(byte[] bytes)
        {
            return new MD5CryptoServiceProvider().ComputeHash(bytes);
        }
        
        public static string Encrypt(string text)
        {
            var hash = Encrypt(text.AsBytes());
            return hash.AsString();
        }
    }
}