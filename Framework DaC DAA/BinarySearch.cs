using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    internal class BinarySearch : IAlgorithm
    {
        private readonly int subproblems = 1;
        private readonly int reductionFactor = 2;
        private readonly int combineComplexity = 0;
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
            return solutions[0];
        }

        public List<IProblem> Divide(IProblem vector, int d = 2)
        {   
            BooleanProblem problem = (BooleanProblem)vector;
            int medium = problem.list.Count / 2;

            List<IProblem> result = new List<IProblem>();

            if(problem.list[medium] > problem.value)
            {
                List<int> temp = problem.list.GetRange(0, medium);
                result.Add(new BooleanProblem(temp, problem.value));
            }
            else
            {
                List<int> temp = problem.list.GetRange(medium, problem.list.Count - medium);
                result.Add(new BooleanProblem(temp, problem.value));
            }
            return result;
        }

        public bool Small(IProblem vector)
        {
            return vector.GetSize() <= 1;
        }

        public ISolution SolveSmall(IProblem vector)
        {   
            BooleanSolution solution = new BooleanSolution();
            BooleanProblem value = (BooleanProblem)vector;

            if(value.list[0] == value.value)
            {
                solution.found = true;
            }
            return solution;
        }
    }
}
