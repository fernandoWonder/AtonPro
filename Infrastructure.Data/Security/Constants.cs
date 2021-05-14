using System;
using System.Linq;

namespace Infrastructure.Data.Security
{
    public static class ConstantsPasswordKey
    {
        public const string SharedSecret = "*SellerJASC*";// "*adilsonABC*";

        public static string GetRandomPasswordKey()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
