using System.Collections.Generic;

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

        public List<int> Combine(List<int> left, List<int> right)
        {
            left.AddRange(right);
            return left;
        }
        public List<List<int>> Divide(List<int> vector, int d = 2)
        {
            
            int i = 0, j = vector.Count-1;
            int pivot = vector[vector.Count / 2];
            List<List<int>> result = new List<List<int>>();
            while (i < j)
            {
                while (vector[i] < pivot)
                {
                    i++;
                }
                while (vector[j] > pivot)
                {
                    j--;
                }
                if (i < j)
                {
                    int temp = vector[j];
                    vector[j] = vector[i];
                    vector[i] = temp;
                }                    
            }
            result.Add(vector.GetRange(0, j));
            result.Add(vector.GetRange(j, vector.Count - j));
            return result;
        }

        public bool Small(List<int> vector)
        {
            if (vector.Count <= 1 /* 2 */)
            {
                return true;
            }
            else return false;
        }

        public List<int> SolveSmall(List<int> vector)
        {
            //List<int> result = new List<int>();
            //if (vector.Count <= 1)
            //{
            //    return vector;
            //}
            //else if (vector[0] <= vector[1])
            //{
            //    result = vector;
            //}
            //else
            //{
            //    result.Add(vector[1]);
            //    result.Add(vector[0]);
            //}
            //return result;
            
            return vector;
        }
    }
}
