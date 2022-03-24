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

        public ISolution Combine(ISolution l, ISolution r)
        {   
            IntListSolution left = (IntListSolution)l;
            IntListSolution right = (IntListSolution)r;

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

            int i = 0, j = vector.Count-1;
            int pivot = vector.Count / 2;

            while (i < j)
            {
                while (vector[i] < vector[pivot])
                {
                    i++;
                }
                while (vector[j] > vector[pivot])
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

            result.Add(new IntListProblem(vector.GetRange(0, j)));

            result.Add(new IntListProblem(vector.GetRange(j, vector.Count - j)));

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
