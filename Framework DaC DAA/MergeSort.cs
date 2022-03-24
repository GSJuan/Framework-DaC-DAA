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

        public ISolution Combine(List<ISolution> solutions)
        {
            IntListSolution result = new IntListSolution();

            IntListSolution left = (IntListSolution)solutions[0];
            IntListSolution right = (IntListSolution)solutions[1];

            while (left.GetSize() > 0 || right.GetSize() > 0)
            {
                if (left.GetSize() > 0 && right.GetSize() > 0)
                {
                    if (left.list[0] <= right.list[0])
                    {
                        result.list.Add(left.list[0]);
                        left.list.Remove(left.list[0]);
                    }
                    else
                    {
                        result.list.Add(right.list[0]);
                        right.list.Remove(right.list[0]);
                    }
                }
                else if (left.GetSize() > 0)
                {
                    result.list.Add(left.list[0]);
                    left.list.Remove(left.list[0]);
                }
                else if (right.GetSize() > 0)
                {
                    result.list.Add(right.list[0]);
                    right.list.Remove(right.list[0]);
                }
            }
            return result;
        }

        public List<IProblem> Divide(IProblem p, int reductionFactor = 2)
        {
            IntListProblem problem = (IntListProblem)p;

            List<int> list = problem.list;

            List<IProblem> result = new List<IProblem>();

            int partitionSize = (int)Math.Ceiling(list.Count / (decimal)reductionFactor);

            for (int i = 0; i < list.Count; i += partitionSize)
            {
                List<int> temp = list.GetRange(i, Math.Min(partitionSize, list.Count - i));
                result.Add(new IntListProblem(temp));
            }
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
            {   List<int> result = new List<int>();
                result.Add(vector[1]);
                result.Add(vector[0]);
                return new IntListSolution(result);
            }
            
        }
    }
}
