namespace CryptographyBase.Classes
{

    public static class VIGENÈRE
    {
        public static string Decrypt(string key, string cipherText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            key = key.ToUpper();
            cipherText = cipherText.ToUpper();

            string plainText = string.Empty;

            for (int i = 0; i < cipherText.Length; i++)
            {
                char cipherChar = cipherText[i];
                char keyChar = key[i % key.Length];

                if (char.IsWhiteSpace(cipherChar))
                {
                    plainText += ' '; // Preserve spaces
                    continue;
                }

                int originalCharIndex = (upperAlphabetic.IndexOf(cipherChar) - upperAlphabetic.IndexOf(keyChar) + 26) % 26;
                plainText += upperAlphabetic[originalCharIndex];
            }

            return plainText;
        }

        public static string Encrypt(string key, string plainText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            key = key.ToUpper();
            plainText = plainText.ToUpper();

            string cipherText = string.Empty;

            for (int i = 0; i < plainText.Length; i++)
            {
                char plainChar = plainText[i];
                char keyChar = key[i % key.Length];

                if (char.IsWhiteSpace(plainChar))
                {
                    cipherText += ' '; // Preserve spaces
                    continue;
                }

                int newCharIndex = (upperAlphabetic.IndexOf(plainChar) + upperAlphabetic.IndexOf(keyChar)) % 26;
                cipherText += upperAlphabetic[newCharIndex];
            }

            return cipherText;
        }


        public static string AutoDecrypt(string key, string cipherText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            key = key.ToUpper();
            cipherText = cipherText.ToUpper();

            string plainText = string.Empty;
            int keyIndex = 0;

            foreach (char cipherChar in cipherText)
            {
                if (char.IsWhiteSpace(cipherChar))
                {
                    plainText += ' '; // Preserve spaces
                    continue;
                }

                char keyChar = key[keyIndex % key.Length];

                int originalCharIndex = (upperAlphabetic.IndexOf(cipherChar) - upperAlphabetic.IndexOf(keyChar) + 26) % 26;
                plainText += upperAlphabetic[originalCharIndex];

                if (!char.IsWhiteSpace(plainText[plainText.Length - 1])) // If the decrypted character is not a space
                    key += plainText[plainText.Length - 1]; // Append the decrypted character to the key

                keyIndex++;
            }

            return plainText;
        }

        public static string AutoEncrypt(string key, string plainText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            key = key.ToUpper();
            plainText = plainText.ToUpper();

            string cipherText = string.Empty;
            int keyIndex = 0;

            foreach (char plainChar in plainText)
            {
                if (char.IsWhiteSpace(plainChar))
                {
                    cipherText += ' '; // Preserve spaces
                    continue;
                }

                char keyChar = key[keyIndex % key.Length];

                int newCharIndex = (upperAlphabetic.IndexOf(plainChar) + upperAlphabetic.IndexOf(keyChar)) % 26;
                cipherText += upperAlphabetic[newCharIndex];

                if (!char.IsWhiteSpace(plainChar)) // If the character is not a space
                    key += plainChar; // Append the original character to the key

                keyIndex++;
            }

            return cipherText;
        }
    }
}
