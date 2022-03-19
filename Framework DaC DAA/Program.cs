using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DyV<MargeSort> dyv = new DyV<MargeSort>();
            List<int> vector = new List<int> { 3, 2, 1};
            foreach (int i in vector)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");

            foreach (int i in dyv.Solve(vector, vector.Count))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
