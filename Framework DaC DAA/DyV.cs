using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    public class DyV <T> where T : IAlgorithm, new()
    {
        public T algorithm = new T();

        public List<int> Solve(List<int> vector, int size) {
            if (algorithm.Small(vector))
            {
                return algorithm.SolveSmall(vector);
            }
            else
            {
                List<List<int>> dividedProblem = algorithm.Divide(vector);
                List<int> s1 = Solve(dividedProblem[0], dividedProblem[0].Count);
                List<int> s2 = Solve(dividedProblem[1], dividedProblem[1].Count);
                return algorithm.Combine(s1, s2);
            }
        }

        public String Recurrence() {
            String result = "T(n) = ";
            return result;
        }
    }
}
