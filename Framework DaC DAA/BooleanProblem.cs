using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    internal class BooleanProblem : IProblem
    {
        public List<int> list = new List<int>();
        public int value;


        public BooleanProblem(List<int> list, int value)
        {
            this.list = list;
            this.value = value;
        }

        public int GetSize()
        {
            return list.Count;
        }
    }
}
