using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DyV<MargeSort> dyv = new DyV<MargeSort>();
            List<int> vector = new List<int> {4, 3, 27, 48, 2, 1, 56};
            foreach (int i in vector)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");
            List<int> solution = dyv.Solve(vector, vector.Count);
            foreach (int i in solution)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
