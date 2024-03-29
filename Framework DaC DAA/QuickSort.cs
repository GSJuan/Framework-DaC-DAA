﻿using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public class QuickSort : IAlgorithm
    {
        private readonly int subproblems = 2;
        private readonly int reductionFactor = 2;
        private readonly int combineComplexity = 1;

        public int GetSubproblems()
        {
            return subproblems;
        }

        public int GetReductionFactor()
        {
            return reductionFactor;
        }

        public int GetCombineComplexity()
        {
            return combineComplexity;
        }

        public ISolution Combine(List<ISolution> solutions)
        {   
            IntListSolution left = (IntListSolution)solutions[0];
            IntListSolution right = (IntListSolution)solutions[1];

            List<int> vector1 = left.list;
            List<int> vector2 = right.list;

            vector1.AddRange(vector2);
            return new IntListSolution(vector1);
        }
        public List<IProblem> Divide(IProblem p, int d = 2)
        {

            IntListProblem problem = (IntListProblem)p;
            List<int> vector = problem.list;
            List<IProblem> result = new List<IProblem>();

            int i = 0, j = vector.Count - 2;
            int endPos = vector.Count - 1;
            int pivotIndex = vector.Count / 2;
            int pivot = vector[pivotIndex];         

            (vector[pivotIndex], vector[endPos]) = (vector[endPos], vector[pivotIndex]);

            while (i < j)
            {
                while (vector[i] < pivot)
                {
                    i++;
                }
                while (j >= 0 && vector[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    (vector[i], vector[j]) = (vector[j], vector[i]);
                    i++;
                    j--;
                }              

            }

            (vector[i], vector[endPos]) = (vector[endPos], vector[i]);
            pivotIndex = i;

            List<int> temp = new List<int>();
            List<int> temp2 = new List<int>();

            for (int k = 0; k < pivotIndex ; k++)
            {
                temp.Add(vector[k]);
            }

            for (int k = pivotIndex; k <= endPos; k++)
            {
                temp2.Add(vector[k]);
            }

            result.Add(new IntListProblem(temp));
            result.Add(new IntListProblem(temp2));

            return result;
        }

        public bool Small(IProblem vector)
        {
            return vector.GetSize() <= 2;
        }

        public ISolution SolveSmall(IProblem p)
        {
            IntListProblem problem = (IntListProblem)p;

            List<int> vector = problem.list;
            if (vector.Count <= 1 || vector[0] <= vector[1])
            {
                return new IntListSolution(vector);
            }
            else
            {
                List<int> result = new List<int>();
                result.Add(vector[1]);
                result.Add(vector[0]);
                return new IntListSolution(result);
            }
        }
    }
}
