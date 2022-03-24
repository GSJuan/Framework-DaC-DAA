using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    public class IntListSolution : ISolution
    {
        public List<int> list = new List<int>();

        public IntListSolution()
        {
        }

        public IntListSolution(List<int> vector)
        {
            this.list = vector;
        }
        public int GetSize()
        {
            return list.Count;
        }
    }
}
