using System.Collections.Generic;
using System.Linq;

namespace CryptographyBase.Classes
{
    public static class MonoAlphabetic
    {
        public static string Decrypt(string key, string ciphertext)
        {
            Dictionary<char, char> map = Mapinng(key).ToDictionary(x => x.Value, x => x.Key);

            string plainText = string.Empty;

            foreach (char item in ciphertext)
            {
                if (char.IsWhiteSpace(item))
                {
                    plainText += ' '; // Preserve spaces
                    continue;
                }
                plainText += map[item];
            }

            return plainText;
        }

        public static string Encrypt(string key, string plainText)
        {
            plainText = plainText.ToUpper();

            Dictionary<char, char> map = Mapinng(key);

            string cipherText = string.Empty;

            foreach (char item in plainText)
            {
                if (char.IsWhiteSpace(item))
                {
                    cipherText += ' '; // Preserve spaces
                    continue;
                }
                cipherText += map[item];
            }

            return cipherText;
        }
        private static Dictionary<char, char> Mapinng(string key)
        {

            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string newUpperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            key = key.ToUpper();
            key = key.Replace(" ", "");

            List<char> distinctChar = key.Distinct().ToList<char>();
            int i = 0;
            foreach (char item in distinctChar)
            {
                newUpperAlphabetic = newUpperAlphabetic.Insert(i++, item.ToString());
            }

            List<char> newDistincitUpperAlphabetic = newUpperAlphabetic.Distinct().ToList();

            Dictionary<char, char> map = new Dictionary<char, char>();
            int j = 0;
            foreach (char item in upperAlphabetic)
            {
                map.Add(item, newDistincitUpperAlphabetic[j++]);

            }
            return map;
        }
    }
}