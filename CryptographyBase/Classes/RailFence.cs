using System.Text;

namespace CryptographyBase.Classes
{
    public static class RailFence
    {

        public static string Encrypt(string plainText, int rails)
        {
            plainText = plainText.ToUpper();
            // Create an array of StringBuilder objects to represent the rails
            StringBuilder[] railArray = new StringBuilder[rails];
            for (int i = 0; i < rails; i++)
            {
                railArray[i] = new StringBuilder();
            }

            // Fill the rail array with the plaintext characters
            int railIndex = 0;
            int direction = 1; // 1 for downward movement, -1 for upward movement
            for (int i = 0; i < plainText.Length; i++)
            {
                railArray[railIndex].Append(plainText[i]);


                //if (rails == 3 && railIndex == rails - 1)
                //{
                //    railIndex = 1;
                //} 
                if (rails > 2 && railIndex == rails - 1)
                {
                    railIndex = 1;
                }


                railIndex += direction;



                // Change direction when reaching the top or bottom rail
                if (railIndex == 0 /*|| railIndex == rails - 1*/)
                {
                    direction *= -1;


                }

                if (railIndex == rails - 1)
                {


                    direction *= -1;
                }


            }

            // Concatenate the rails to get the encrypted text
            StringBuilder encryptedText = new StringBuilder();
            foreach (StringBuilder rail in railArray)
            {
                encryptedText.Append(rail);
            }

            return encryptedText.ToString();
        }

        public static string Decrypt(string cipherText, int rails)
        {
            cipherText = cipherText.ToUpper();
            // Determine the length of each segment of the rail fence
            int segmentLength = (rails - 1) * 2;

            // Create an array to store the rail segments
            string[] segments = new string[rails];
            for (int i = 0; i < rails; i++)
            {
                segments[i] = "";
            }

            // Distribute the characters of the ciphertext into the rail segments
            int index = 0;
            while (index < cipherText.Length)
            {
                for (int i = 0; i < rails && index < cipherText.Length; i++)
                {
                    segments[i] += cipherText[index++];
                }
                for (int i = rails - 2; i > 0 && index < cipherText.Length; i--)
                {
                    segments[i] += cipherText[index++];
                }
            }

            // Concatenate the rail segments to get the decrypted text
            StringBuilder decryptedText = new StringBuilder();
            foreach (string segment in segments)
            {
                decryptedText.Append(segment);
            }

            return decryptedText.ToString();
        }
    }
}
