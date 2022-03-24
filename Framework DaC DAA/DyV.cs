using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public class DyV <T> where T : IAlgorithm, new()
    {
        public T algorithm = new T();

        public ISolution Solve(IProblem vector, int value = 2) {
            if (algorithm.Small(vector))
            {
                return algorithm.SolveSmall(vector);
            }
            else
            {
                List<IProblem> dividedProblem = algorithm.Divide(vector, value);
                List<ISolution> solutions = new List<ISolution>();
                for(int i = 0; i < dividedProblem.Count; i++)
                {
                    solutions.Add(Solve(dividedProblem[i], value));
                }
                return algorithm.Combine(solutions);
            }
        }

        public String Recurrence() {
            String result = "T(n) = " + algorithm.GetSubproblems() + "T(n/" + algorithm.GetReductionFactor() + ") + n^" + algorithm.GetCombineComplexity();
            return result;
        }
    }
}
