using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public interface IAlgorithm
    {
        public int GetSubproblems();

        public int GetReductionFactor();

        public int GetCombineComplexity();
        public bool Small(IProblem vector);

        public ISolution SolveSmall(IProblem vector);

        public List<IProblem> Divide(IProblem vector, int d = 2);

        public ISolution Combine(List<ISolution> solutions);

    }
}
