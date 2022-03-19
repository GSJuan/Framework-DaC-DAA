using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    public interface IAlgorithm
    {
        public bool Small(List<int> vector);

        public List<int> SolveSmall(List<int> vector);

        public List<List<int>> Divide(List<int> vector, int d = 2);

        public List<int> Combine(List<int> vector, List<int> vector2);

    }
}
