using System;

namespace CryptographyBase.Classes
{
    public static class RailFence
    {


        public static string Encrypt(string plaintext, int key)
        {
            int length = plaintext.Length;
            int rows = CalculateRows(length, key);
            int cols = Convert.ToInt32(Math.Ceiling((double)length / rows));

            char[,] matrix = new char[rows, cols];

            int index = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (index < length)
                        matrix[row, col] = plaintext[index++];
                    else
                        matrix[row, col] = ' ';
                }
            }

            string ciphertext = "";
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    ciphertext += matrix[row, col];
                }
            }
            return ciphertext;
        }

        public static string Decrypt(string ciphertext, int key)
        {
            int length = ciphertext.Length;
            int rows = CalculateRows(length, key);
            int cols = Convert.ToInt32(Math.Ceiling((double)length / rows));

            char[,] matrix = new char[rows, cols];

            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((index < length))
                    {
                        matrix[row, col] = ciphertext[index++];
                    }
                    else
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            string plaintext = "";
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] != ' ')
                    {
                        plaintext += matrix[row, col];
                    }
                }
            }
            return plaintext;
        }

        private static int CalculateRows(int length, int key)
        {
            // Calculate rows based on the length of the plaintext and the key
            return Math.Min(length, key);
        }



    }
}
