using CryptographyBase.Classes;
using System;


namespace CryptographyBase
{
    public static class Program
    {
        static void Main(string[] args)
        {



            double[,] key = {
                { 17, 17, 5 },
                { 21, 18,21 },
                { 2,  2, 19 } };

            //double[,] Inverskey = {
            //    {4,9,15   },
            //    {15,17,6  },
            //    {24,0,17  }
            //};

            // PrintArray(Hill.InvertMatrix(key));

            Console.WriteLine(Hill.Encrypt(key, "paymoremoney"));

            Console.WriteLine(Hill.Decrypt(key, "RRLMWBKASPDH"));


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
