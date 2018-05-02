using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Extensions.Utility
{
    public static class Extensions
    {
        public static string GetMD5Hash(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return null;
            var sb = new StringBuilder();
            var csp = new MD5CryptoServiceProvider();
            var bytes = csp.ComputeHash(Encoding.UTF8.GetBytes(source));
            bytes.ToList().ForEach(b => { sb.Append(b.ToString("x2")); });
            return sb.ToString();
        }

        //public static string CryptWithToken(this string source, string token)
        //{
        //    if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(token))
        //        return null;

        //}


        public static bool IsEven(this int num)
        {
            return (num % 2 == 0 ? true : false);
        }
        public static bool IsEven(this long num)
        {
            return (num % 2 == 0 ? true : false);
        }
        public static bool IsEven(this double num)
        {
            return (num % 2 == 0 ? true : false);
        }
        public static bool IsEven(this float num)
        {
            return (num % 2 == 0 ? true : false);
        }
        public static bool IsEven(this short num)
        {
            return (num % 2 == 0 ? true : false);
        }
        public static bool IsEven(this decimal num)
        {
            return (num % 2 == 0 ? true : false);
        }
    }
}
