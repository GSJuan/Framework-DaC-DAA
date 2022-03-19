using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public class MergeSort : IAlgorithm
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

        public List<int> Combine(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.Remove(left[0]);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.Remove(right[0]);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }
            return result;
        }

        public List<List<int>> Divide(List<int> vector, int d = 2)
        {
            List<List<int>> solution = new List<List<int>>();
            int size = (int)Math.Ceiling(vector.Count / (decimal)d);

            for(int i = 0; i < vector.Count; i+= size)
            {
                solution.Add(vector.GetRange(i, Math.Min(size, vector.Count - i)));
            }
            return solution;
        }

        public bool Small(List<int> vector)
        {
            if (vector.Count <= 2)
            {
                return true;
            }
            else return false;
        }

        public List<int> SolveSmall(List<int> vector)
        {
            List<int> result = new List<int>();
            if(vector.Count <=1)
            {
                return vector;
            }
            else if(vector[0] <= vector[1])
            {
                result = vector;
            }
            else
            {
                result.Add(vector[1]);
                result.Add(vector[0]);
            }
            return result;
        }
    }
}
