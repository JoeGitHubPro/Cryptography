namespace CryptographyBase.Classes
{
    //public static class Caesar
    //{

    //    public static string Decrypt(int key, string cipherText)
    //    {
    //        return Encrypt(-key, cipherText);
    //    }

    //    public static string Encrypt(int key, string plainText)
    //    {
    //        string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    //        plainText = plainText.ToUpper();


    //        string cipherText = string.Empty;


    //        foreach (char item in plainText)
    //        {
    //            int newCharIndex = (upperAlphabetic.IndexOf(item) + key) % 26;

    //            if (newCharIndex < 0)
    //                newCharIndex += 26;

    //            cipherText += upperAlphabetic[newCharIndex];
    //        }

    //        return cipherText;
    //    }
    //}


    public static class Caesar
    {
        public static string Decrypt(int key, string cipherText)
        {
            return Encrypt(-key, cipherText);
        }

        public static string Encrypt(int key, string plainText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            plainText = plainText.ToUpper();

            string cipherText = string.Empty;

            foreach (char item in plainText)
            {
                if (char.IsWhiteSpace(item))
                {
                    cipherText += ' '; // Preserve spaces
                    continue;
                }

                int newCharIndex = (upperAlphabetic.IndexOf(item) + key) % 26;

                if (newCharIndex < 0)
                    newCharIndex += 26;

                cipherText += upperAlphabetic[newCharIndex];
            }

            return cipherText;
        }
    }

}