using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Contactista.DataAccess.Extentions
{
    public static class ToHash
    {
        public static string ToHashText(this string TextwantEncrypt)
        {
            string result = "";
            if (!string.IsNullOrWhiteSpace(TextwantEncrypt))
            {
                byte[] data = Encoding.ASCII.GetBytes(TextwantEncrypt);

                using (SHA512 sha512 = SHA512.Create())
                {
                    result = Encoding.ASCII.GetString(sha512.ComputeHash(data));
                }
            }

            return result;
        }
    }
}
