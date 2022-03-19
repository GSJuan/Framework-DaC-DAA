using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DyV<MergeSort> mergeSort = new DyV<MergeSort>();
            DyV<QuickSort> quickSort = new DyV<QuickSort>();

            List<int> vector = new List<int> {8, 7, 6, 1, 56, 0, 9, 2};
            foreach (int i in vector)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");

            List<int> solution = mergeSort.Solve(vector, vector.Count);
            foreach (int i in solution)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");

            List<int> solution2 = quickSort.Solve(vector, vector.Count);
            foreach (int i in solution2)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
