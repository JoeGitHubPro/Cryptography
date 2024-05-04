using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptographyBase.Classes
{
    public static class ColumnarTransposition
    {

        public static string Encrypt(string plainText, int[] key)
        {
            // Remove spaces from the plaintext
            plainText = plainText.Replace(" ", "").ToUpper();

            // Calculate the number of rows based on the key length
            int rows = (int)Math.Ceiling((double)plainText.Length / key.Length);

            // Create a matrix to store the plaintext characters
            char[,] matrix = new char[rows, key.Length];

            // Fill the matrix with the plaintext characters row-wise
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (index < plainText.Length)
                    {
                        matrix[i, j] = plainText[index++];
                    }
                    else
                    {
                        matrix[i, j] = 'X'; // Padding with 'X' if the plaintext is not long enough
                    }
                }
            }

            // Generate the ciphertext by reading the matrix column by column using the provided key
            StringBuilder cipherText = new StringBuilder();
            foreach (int column in key)
            {
                for (int i = 0; i < rows; i++)
                {
                    cipherText.Append(matrix[i, column - 1]);
                }
            }

            return cipherText.ToString();
        }

        public static string Decrypt(string cipherText, int[] key)
        {
            // Calculate the number of rows based on the key length
            int rows = cipherText.Length / key.Length;

            // Create a matrix to store the ciphertext characters
            char[,] matrix = new char[rows, key.Length];

            // Fill the matrix with the ciphertext characters column-wise
            int index = 0;
            for (int column = 0; column < key.Length; column++)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i, column] = cipherText[index++];
                }
            }

            // Sort the key and create a mapping from sorted index to original index
            Dictionary<int, int> indexMap = Enumerable.Range(0, key.Length)
                                                      .OrderBy(i => key[i])
                                                      .Select((val, Index) => new { val, Index })
                                                      .ToDictionary(item => item.val, item => item.Index);

            // Generate the plaintext by reading the matrix column by column using the sorted key
            StringBuilder plainText = new StringBuilder();
            foreach (int INdex in indexMap.Values)
            {
                for (int i = 0; i < rows; i++)
                {
                    plainText.Append(matrix[i, INdex]);
                }
            }

            return plainText.ToString();
        }

    }
}
