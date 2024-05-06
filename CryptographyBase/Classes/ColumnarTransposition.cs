using System;
using System.Text;

namespace CryptographyBase.Classes
{
    public static class ColumnarTransposition
    {
        // Helper method to get shift indexes based on the key
        private static int[] GetShiftIndexes(int[] key)
        {
            int keyLength = key.Length;
            int[] indexes = new int[keyLength];
            // Assign index positions based on the key values
            for (int i = 0; i < keyLength; ++i)
            {
                indexes[key[i] - 1] = i;
            }
            return indexes;
        }

        // Encrypts the input text using the Columnar Transposition cipher
        public static string Encrypt(string input, int[] key)
        {
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = key.Length;
            // Calculate the total number of rows needed
            int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);

            // Create a grid to store characters in rows and columns
            char[,] grid = new char[totalRows, totalColumns];

            // Fill the grid with characters from the input
            for (int i = 0; i < totalChars; ++i)
            {
                int currentRow = i / totalColumns;
                int currentColumn = i % totalColumns;
                grid[currentRow, currentColumn] = input[i];
            }

            // Get the shift indexes based on the key
            int[] shiftIndexes = GetShiftIndexes(key);

            // Read characters from the grid column-wise according to shift indexes
            for (int i = 0; i < totalColumns; ++i)
            {
                int columnIndex = shiftIndexes[i];
                for (int j = 0; j < totalRows; ++j)
                {
                    if (grid[j, columnIndex] != '\0') // Skip empty cells
                    {
                        output.Append(grid[j, columnIndex]);
                    }
                }
            }

            return output.ToString();
        }

        // Decrypts the ciphertext using the Columnar Transposition cipher
        public static string Decrypt(string ciphertext, int[] key)
        {
            int totalChars = ciphertext.Length;
            int totalColumns = key.Length;
            int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);

            // Create a grid to store characters in rows and columns
            char[,] grid = new char[totalRows, totalColumns];
            int charIndex = 0;

            // Get the shift indexes based on the key
            int[] shiftIndexes = GetShiftIndexes(key);

            // Fill the grid column-wise with characters from the ciphertext
            for (int i = 0; i < totalColumns; ++i)
            {
                int columnIndex = shiftIndexes[i];
                for (int j = 0; j < totalRows; ++j)
                {
                    if (charIndex < totalChars) // Ensure not to go beyond the ciphertext length
                    {
                        grid[j, columnIndex] = ciphertext[charIndex];
                        charIndex++;
                    }
                }
            }

            StringBuilder plaintext = new StringBuilder();

            // Read characters from the grid row-wise to construct the plaintext
            for (int i = 0; i < totalRows; ++i)
            {
                for (int j = 0; j < totalColumns; ++j)
                {
                    if (grid[i, j] != '\0') // Skip empty cells
                    {
                        plaintext.Append(grid[i, j]);
                    }
                }
            }

            return plaintext.ToString();
        }
    }
}
