using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_of_array
{
    internal class method
    {
        static void Main(string[] args)
        {
            int[,] arr;

            // initializing 2-D array
            // matrix of 4 rows and 4 columns
            arr = new int[4, 4]{ { 1, 2, 3, 4},
                             { 5, 6, 7, 8},
                             {9, 10, 11, 12},
                             {13, 14, 15, 16} };

            Console.WriteLine("Matrix Before Transpose: ");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
