using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public class DyV <T> where T : IAlgorithm, new()
    {
        public T algorithm = new T();

        public ISolution Solve(IProblem vector, int size) {
            if (algorithm.Small(vector))
            {
                return algorithm.SolveSmall(vector);
            }
            else
            {
                List<IProblem> dividedProblem = algorithm.Divide(vector);
                ISolution s1 = Solve(dividedProblem[0], dividedProblem[0].GetSize());
                ISolution s2 = Solve(dividedProblem[1], dividedProblem[1].GetSize());
                return algorithm.Combine(s1, s2);
            }
        }

        public String Recurrence() {
            String result = "T(n) = " + algorithm.GetSubproblems() + "T(n/" + algorithm.GetReductionFactor() + ") + n^" + algorithm.GetCombineComplexity();
            return result;
        }
    }
}
