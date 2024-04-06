using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptographyBase.Classes
{
    public static class Hill
    {
        public static string Decrypt(double[,] key, string cipherText)
        {
            key = InvertMatrix(key);
            return Encrypt(key, cipherText);
        }

        public static string Encrypt(double[,] key, string plainText)
        {
            string upperAlphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int plaintextLength = plainText.Length;
            int rows = key.GetLength(0);
            plainText = plainText.ToUpper();


            List<int> plainTextIndexArray = new List<int>();

            foreach (char item in plainText)
            {
                int newCharIndex = (upperAlphabetic.IndexOf(item)) % 26;

                if (newCharIndex < 0)
                    newCharIndex += 26;

                plainTextIndexArray.Add(newCharIndex);
            }

            string cipherText = string.Empty;
            List<int> newCharIndexs = new List<int>();
            for (int i = 0; i < plaintextLength; i += 3)
            {
                double[] matrixA = plainTextIndexArray.Skip(i).Take(3).Select(x => (double)x).ToArray();
                if (matrixA.Length != 0)
                {
                    newCharIndexs.AddRange(MultiplyMatrices(matrixA, key));
                }
                else
                {
                    continue;
                }

            }

            foreach (int newCharIndex in newCharIndexs)
            {
                cipherText += upperAlphabetic[newCharIndex % 26];
            }

            return cipherText;
        }

        static int[] MultiplyMatrices(double[] matrixA, double[,] matrixB)
        {
            int colsA = matrixA.Length;
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            if (colsA != rowsB)
            {
                throw new ArgumentException("Number of columns in Matrix A must be equal to the number of rows in Matrix B for matrix multiplication.");
            }

            int[] resultMatrix = new int[colsB];

            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += (int)(matrixA[k] * matrixB[k, j]);
                }
                resultMatrix[j] = sum;
            }

            return resultMatrix;
        }

        public static double[,] InvertMatrix(double[,] matrix)
        {
            double det = Determinant(matrix) % 26;//-3

            if (det < 0)
                det += 26;//23

            det = (1 / det);

            det = 17;/*to 17*/
            if (det == 0)
                throw new InvalidOperationException("Matrix is singular and cannot be inverted.");

            double[,] invertedMatrix = new double[3, 3];

            invertedMatrix[0, 0] = ((((matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])) * det) % 26);
            invertedMatrix[0, 1] = ((((matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2])) * det) % 26);
            invertedMatrix[0, 2] = ((((matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1])) * det) % 26);
            invertedMatrix[1, 0] = ((((matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2])) * det) % 26);
            invertedMatrix[1, 1] = ((((matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0])) * det) % 26);
            invertedMatrix[1, 2] = ((((matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2])) * det) % 26);
            invertedMatrix[2, 0] = ((((matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0])) * det) % 26);
            invertedMatrix[2, 1] = ((((matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1])) * det) % 26);
            invertedMatrix[2, 2] = ((((matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0])) * det) % 26);

            invertedMatrix = checkNegativity(invertedMatrix);

            return invertedMatrix;
        }

        static double Determinant(double[,] matrix)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                   matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                   matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }

        private static double[,] checkNegativity(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] += 26;
                    }

                }
            }
            return matrix;
        }
    }

}