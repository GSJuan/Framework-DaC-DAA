using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    public class MargeSort : IAlgorithm
    {
        public List<int> Combine(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left[0]);
                        left.Remove(left[0]);      //Rest of the list minus the first element
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
            int size = vector.Count / d;

            for(int i = 0; i < vector.Count; i+= d)
            {
                solution.Add(vector.GetRange(i, Math.Min(d, vector.Count - i)));
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
