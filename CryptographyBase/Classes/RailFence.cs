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

                railIndex += direction;



                // Change direction when reaching the top or bottom rail
                if (railIndex == 0 || railIndex == rails - 1)
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


        public static string Decrypt(string ciphertext, int rails)
        {
            // Create the rail fence pattern
            char[,] fence = new char[rails, ciphertext.Length];
            for (int i = 0; i < rails; i++)
            {
                for (int j = 0; j < ciphertext.Length; j++)
                {
                    fence[i, j] = '\n'; // Initialize with a newline character
                }
            }

            // Mark the positions of the fence where the characters will be placed
            int rail = 0;
            bool directionDown = false;
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (rail == 0 || rail == rails - 1)
                {
                    directionDown = !directionDown;
                }

                fence[rail, i] = '*'; // Mark the position with an asterisk to indicate where the characters will be placed

                rail += directionDown ? 1 : -1;
            }

            // Fill the fence with the ciphertext characters
            int index = 0;
            for (int i = 0; i < rails; i++)
            {
                for (int j = 0; j < ciphertext.Length; j++)
                {
                    if (fence[i, j] == '*' && index < ciphertext.Length)
                    {
                        fence[i, j] = ciphertext[index];
                        index++;
                    }
                }
            }

            // Read off the fence to get the plaintext
            string plaintext = "";
            rail = 0;
            directionDown = false;
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (rail == 0 || rail == rails - 1)
                {
                    directionDown = !directionDown;
                }

                if (fence[rail, i] != '\n')
                {
                    plaintext += fence[rail, i];
                }

                rail += directionDown ? 1 : -1;
            }

            return plaintext;
        }
    }
}
