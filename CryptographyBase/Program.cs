using System;


namespace CryptographyBase
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the plaintext: ");
            //string plaintext = Console.ReadLine();

            //Console.Write("Enter the key: ");
            //int key = int.Parse(Console.ReadLine());

            //string ciphertext = RailFenceBase.Encrypt(plaintext, key);
            //Console.WriteLine("Encrypted text: " + ciphertext);

            //string decryptedText = RailFenceBase.Decrypt(ciphertext, key);
            //Console.WriteLine("Decrypted text: " + decryptedText);



            //  Console.WriteLine(VIGENÈRE.Encrypt("deceptive", "wearediscoveredsaveyourself"));
            //  Console.WriteLine(VIGENÈRE.EncryptAutokey("deceptive", "wearediscoveredsaveyourself"));
            //  Console.WriteLine(VIGENÈRE.Decrypt("deceptive", "ZICVTWQNGRZGVTWAVZHCQYGLMGJ"));

            //double[,] key = {
            //    { 17, 17, 5 },
            //    { 21, 18,21 },
            //    { 2,  2, 19 } };

            //double[,] Inverskey = {
            //    {4,9,15   },
            //    {15,17,6  },
            //    {24,0,17  }
            //};

            // PrintArray(Hill.InvertMatrix(key));

            //Console.WriteLine(Hill.Encrypt(key, "paymoremoney"));

            //Console.WriteLine(Hill.Decrypt(key, "RRLMWBKASPDH"));


            //string plainText = "RAMSWARUPK";
            //string key = "RANCHOBABA";

            //// Encrypt plaintext
            //string encryptedText = VERNAM.Encrypt(plainText, key);
            //Console.WriteLine("Encrypted Text: " + encryptedText);

            //// Decrypt ciphertext
            //string decryptedText = VERNAM.Encrypt(encryptedText, key);
            //Console.WriteLine("Decrypted Text: " + decryptedText);



            //string plainText = "meetmeafterthetogaparty";
            //int rails = 2;

            //// Encrypt plaintext
            //string encryptedText = RailFence.Encrypt(plainText, rails);
            //Console.WriteLine("Encrypted Text: " + encryptedText);

            //// Decrypt ciphertext
            //string decryptedText = RailFence.Decrypt(encryptedText, rails);
            //Console.WriteLine("Decrypted Text: " + decryptedText);



            //string plainText = "attackpostponeuntiltwoamxyz";
            //int[] key = { 4, 3, 1, 2, 5, 6, 7 };

            //// Encrypt plaintext
            //string encryptedText = ColumnarTransposition.Encrypt(plainText, key);
            //Console.WriteLine("Encrypted Text: " + encryptedText);

            //// Decrypt ciphertext
            //string decryptedText = ColumnarTransposition.Decrypt(encryptedText, key);
            //Console.WriteLine("Decrypted Text: " + decryptedText);



            Console.ReadKey();
        }
        public static void PrintArray(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
