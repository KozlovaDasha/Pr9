using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr9
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Random rand = new Random();
        //    int[,] matrix = new int[5, 6];

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            matrix[i, j] = rand.Next(1, 50);
        //        }
        //    }

        //    ChangeMatrix(ref matrix, ShowMatrix);
        //    ChangeMatrix(ref matrix, ShowPositiveElements);
        //    ChangeMatrix(ref matrix, Multiply);
        //    ChangeMatrix(ref matrix, ShowMatrix);

        //    Console.ReadLine();
        //}

        private static void ChangeMatrix(ref int[,] matrix, Action<int[,]> someAct)
        {
            someAct(matrix);
        }

        // Method for printing matrix.
        private static void ShowMatrix(int[,] someMatrix)
        {
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    Console.Write(someMatrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Method for printing positive elements of the matrix.
        private static void ShowPositiveElements(int[,] someMatrix)
        {
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    if(someMatrix[i, j] >= 0)
                        Console.Write(someMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Method for multiplying positive elements.
        private static void Multiply(int[,] someMatrix)
        {
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    if (someMatrix[i, j] >= 0)
                        someMatrix[i, j] *= 3;
                }
            }
        }


    }
}
