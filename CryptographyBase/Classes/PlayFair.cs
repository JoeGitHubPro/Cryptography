using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CryptographyBase.Classes
{
    public static class PlayFair
    {
        public static string Decrypt(string key, string ciphertext)
        {
            char[,] keySquare = Mapinng(key);
            ciphertext = ciphertext.ToUpper();
            string plaintext = "";
            for (int i = 0; i < ciphertext.Length; i += 2)
            {

                char firstChar = ciphertext[i];
                char secondChar = ciphertext[i + 1];



                int row1, col1, row2, col2;
                FindPosition(keySquare, firstChar, out row1, out col1);
                FindPosition(keySquare, secondChar, out row2, out col2);

                if (row1 == row2)
                {
                    plaintext += keySquare[row1, (col1 - 1 + 5) % 5];
                    plaintext += keySquare[row2, (col2 - 1 + 5) % 5];
                }
                else if (col1 == col2)
                {
                    plaintext += keySquare[(row1 - 1 + 5) % 5, col1];
                    plaintext += keySquare[(row2 - 1 + 5) % 5, col2];
                }
                else
                {
                    plaintext += keySquare[row1, col2];
                    plaintext += keySquare[row2, col1];
                }
            }
            return plaintext.Replace("X", string.Empty);
        }

        public static string Encrypt(string key, string plaintext)
        {
            char[,] keySquare = Mapinng(key);
            plaintext = plaintext.ToUpper();
            string ciphertext = "";
            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char firstChar = plaintext[i];

                char secondChar;
                if (i + 1 < plaintext.Length)
                {

                    secondChar = plaintext[i + 1];

                    if (secondChar == firstChar)
                    {
                        secondChar = 'X';
                        i--;
                    }
                }
                else
                {
                    secondChar = 'X';
                }

                int row1, col1, row2, col2;


                //FindPosition Func by equ. (/ - %)
                FindPosition(key, firstChar, out row1, out col1);
                FindPosition(key, secondChar, out row2, out col2);


                // OverLoad FindPosition Func by basic iterations
                FindPosition(keySquare, firstChar, out row1, out col1);
                FindPosition(keySquare, secondChar, out row2, out col2);


                if (row1 == row2)
                {
                    ciphertext += keySquare[row1, (col1 + 1) % 5];
                    ciphertext += keySquare[row2, (col2 + 1) % 5];
                }
                else if (col1 == col2)
                {
                    ciphertext += keySquare[(row1 + 1) % 5, col1];
                    ciphertext += keySquare[(row2 + 1) % 5, col2];
                }
                else
                {
                    ciphertext += keySquare[row1, col2];
                    ciphertext += keySquare[row2, col1];
                }
            }
            return ciphertext;
        }

        private static void FindPosition(char[,] keySquare, char ch, out int row, out int col)
        {
            row = col = 0;

            if (ch == 'J')
                ch = 'I';

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keySquare[i, j] == ch)
                    {
                        row = i;
                        col = j;

                        return;
                    }
                }
            }

        }

        //overload FindPosition
        private static void FindPosition(string key, char ch, out int row, out int col)
        {
            row = col = 0;

            if (ch == 'J')
                ch = 'I';

            string DistinctKey = KeyGenerate(key);

            row = DistinctKey.IndexOf(ch) / 5;
            col = DistinctKey.IndexOf(ch) % 5;
        }

        private static char[,] Mapinng(string key)
        {

            char[,] map = new char[5, 5];

            string newDistincitUpperAlphabetic = KeyGenerate(key);

            int n = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    map[i, j] = newDistincitUpperAlphabetic[n++];
                }

            }

            return map;
        }

        private static string KeyGenerate(string key)
        {
            //select I/J => I
            string defaultAlphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";

            key = key.ToUpper();

            List<char> uniqueKey = key.Distinct().ToList<char>();

            int c = 0;
            foreach (char item in uniqueKey)
            {
                defaultAlphabet = defaultAlphabet.Insert(c++, item.ToString());
            }

            List<char> newDistincitUpperAlphabetic = defaultAlphabet.Distinct().ToList();

            string GeneratedDistictkey = "";
            foreach (var item in newDistincitUpperAlphabetic)
            {
                GeneratedDistictkey += item;
            }


            return GeneratedDistictkey.ToString();
        }

        private static TimeSpan TimeAction(Action blockingAction)
        {
            Stopwatch stopWatch = System.Diagnostics.Stopwatch.StartNew();
            blockingAction();
            stopWatch.Stop();
            return stopWatch.Elapsed;
        }
    }
}