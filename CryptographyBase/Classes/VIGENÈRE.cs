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

        public static string EncryptAutokey(string key, string plainText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            key = key.ToUpper();
            plainText = plainText.ToUpper();

            string cipherText = string.Empty;

            for (int i = 0; i < plainText.Length; i++)
            {
                char plainChar = plainText[i];
                char keyChar = 'a';
                if (i < key.Length)
                {
                    keyChar = key[i];
                }
                else if (i >= key.Length)
                {
                    if (i == key.Length)
                    {
                        i = 0;
                    }

                    keyChar = upperAlphabetic[i];
                }



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
    }
}
