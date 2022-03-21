using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Framework_DaC_DAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            DyV<MergeSort> mergeSort = new DyV<MergeSort>();
            DyV<QuickSort> quickSort = new DyV<QuickSort>();
            TableDrawing table = new TableDrawing(100);
            Stopwatch chrono = new Stopwatch();

            table.PrintLine();
            table.PrintRow("Size", "MergeSort Time", "QuickSort Time");
            table.PrintLine();

            while (size <= 10000)
            {
                InstanceGenerator instanceGenerator = new InstanceGenerator(size);
                List<int> vector = instanceGenerator.Generate();

                //Console.Write("Generated Instance of size {0}:  ", size);
                //foreach (int i in vector)
                //{
                //    Console.Write(i);
                //    Console.Write(" ");
                //}
                //Console.Write("\n");

                chrono.Restart();
                List<int> solution = mergeSort.Solve(vector, vector.Count);
                chrono.Stop();
                var elapsedMsMerge = chrono.Elapsed;

                //Console.Write("MergeSort Solution: ");
                //foreach (int i in solution)
                //{
                //    Console.Write(i);
                //    Console.Write(" ");
                //}
                //Console.Write("\n");

                chrono.Restart();
                List<int> solution2 = quickSort.Solve(vector, vector.Count);
                chrono.Stop();
                var elapsedMsQuick = chrono.Elapsed;

                table.PrintRow(size.ToString(), elapsedMsMerge.ToString(), elapsedMsQuick.ToString());
                table.PrintLine();

                //Console.Write("QuickSort Solution: ");
                //foreach (int i in solution2)
                //{
                //    Console.Write(i);
                //    Console.Write(" ");
                //}
                //Console.Write("\n");

                size += 5;
            }
        }
    }
}
