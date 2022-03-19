using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public interface IAlgorithm
    {
        public int GetSubproblems();

        public int GetReductionFactor();

        public int GetCombineComplexity();
        public bool Small(List<int> vector);

        public List<int> SolveSmall(List<int> vector);

        public List<List<int>> Divide(List<int> vector, int d = 2);

        public List<int> Combine(List<int> vector, List<int> vector2);

    }
}
