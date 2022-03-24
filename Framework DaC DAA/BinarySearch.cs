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
            throw new NotImplementedException();
        }

        public List<IProblem> Divide(IProblem vector, int d = 2)
        {
            throw new NotImplementedException();
        }

        public bool Small(IProblem vector)
        {
            throw new NotImplementedException();
        }

        public ISolution SolveSmall(IProblem vector)
        {
            throw new NotImplementedException();
        }
    }
}
