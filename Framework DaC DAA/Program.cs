using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Framework_DaC_DAA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mode, alg, size = 10;
            DyV<MergeSort> mergeSort = new DyV<MergeSort>();
            DyV<QuickSort> quickSort = new DyV<QuickSort>();
            DyV<BinarySearch> binarySearch = new DyV<BinarySearch>();
            TableDrawing table = new TableDrawing(100);
            Stopwatch chrono = new Stopwatch();

            do
            {
                Console.WriteLine("Hi! Please, choose between debug mode(0) or normal mode (1): ");
                string line = Console.ReadLine();
                mode = int.Parse(line);
            } while (mode < 0 || mode > 1);

            do
            {
                Console.WriteLine("Select your algorithm: Mergesort (0), QuickSort(1), Binary Search(2): ");
                string line = Console.ReadLine();
                alg = int.Parse(line);
            } while (alg < 0 || alg > 2);

            if(mode == 0)
            {
                string kind = alg switch
                {
                    0 => "Mergesort",
                    1 => "QuickSort",
                    2 => "Binary Search",
                    _ => "",
                };
                table.PrintLine();
                table.PrintRow("Size", kind);
                table.PrintLine();

                while (size <= 10000)
                {
                    InstanceGenerator instanceGenerator = new InstanceGenerator(size);
                    IntListProblem vector = new IntListProblem(instanceGenerator.Generate());

                    if(alg == 0)
                    {
                        chrono.Restart();
                        ISolution solution1 = mergeSort.Solve(vector, 2);
                        chrono.Stop();
                        var elapsedMsMerge = chrono.Elapsed;
                        table.PrintRow(size.ToString(), elapsedMsMerge.ToString());
                        table.PrintLine();

                    } else if(alg == 1)
                    {
                        chrono.Restart();
                        ISolution solution2 = quickSort.Solve(vector);
                        chrono.Stop();
                        var elapsedMsQuick = chrono.Elapsed;
                        table.PrintRow(size.ToString(), elapsedMsQuick.ToString());
                        table.PrintLine();

                    } else if(alg == 2)
                    {
                        ISolution s = quickSort.Solve(vector);
                        IntListSolution s1 = (IntListSolution)s;
                        BooleanProblem sortedVec = new BooleanProblem(s1.list, vector.list[0]);
                       
                        chrono.Restart();
                        ISolution solution3 = binarySearch.Solve(sortedVec);
                        chrono.Stop();
                        var elapsedMsQuick = chrono.Elapsed;
                        table.PrintRow(size.ToString(), elapsedMsQuick.ToString());
                        table.PrintLine();
                    }

                    size += 10;
                }
            }
            else if(mode == 1)
            {
                Console.WriteLine("Select your instance Size: ");
                string line = Console.ReadLine();
                size = int.Parse(line);

                InstanceGenerator instanceGenerator = new InstanceGenerator(size);
                IntListProblem vector = new IntListProblem(instanceGenerator.Generate());

                Console.Write("Generated Instance of size {0}:  ", size);
                foreach (int i in vector.list)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.Write("\n");

                if (alg == 0)
                {
                    
                    ISolution solution = mergeSort.Solve(vector, 2);
                    IntListSolution sorted = (IntListSolution)solution;

                    Console.Write("MergeSort Solution: ");
                    foreach (int i in sorted.list)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.Write("\n");

                }
                else if (alg == 1)
                {
                    ISolution solution = quickSort.Solve(vector);
                    IntListSolution sorted = (IntListSolution)solution;

                    Console.Write("QuickSort Solution: ");
                    foreach (int i in sorted.list)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
                else if (alg == 2)
                {

                    ISolution solution = mergeSort.Solve(vector);
                    IntListSolution s1 = (IntListSolution)solution;

                    Console.WriteLine("Sorted Vector: ");

                    foreach (int i in s1.list)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.Write("\n");

                    Console.WriteLine("Enter the Number you want to search inside the vector: ");
                    string input = Console.ReadLine();
                    int toSearch = int.Parse(input);

                    BooleanProblem sortedVec = new BooleanProblem(s1.list, toSearch);

                    ISolution search = binarySearch.Solve(sortedVec);
                    BooleanSolution solved = (BooleanSolution)search;

                    if (solved.found)
                    {
                        Console.Write("Number {0} found inside the vector!", toSearch);
                    }
                    else
                    {
                        Console.Write("Number {0} not found inside the vector!", toSearch);
                    }
                    Console.Write("\n");
                    
                }
            }            
        }
    }
}
