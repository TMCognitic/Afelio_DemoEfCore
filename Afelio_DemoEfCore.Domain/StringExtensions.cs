using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoEfCore.Domain
{
    internal static class StringExtensions
    {
        internal static byte[]? Hash(this string? s)
        {
            if (s is null)
                return null;

            byte[] toHash = Encoding.Default.GetBytes(s);
            return SHA512.HashData(toHash);
        }
    }
}
