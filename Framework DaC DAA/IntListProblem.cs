using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_DaC_DAA
{
    public class IntListProblem : IProblem
    {
        public List<int> list = new List<int>();
        
        public IntListProblem()
        {
        }
        public IntListProblem(List<int> temp)
        {
            this.list = temp;
        }
        public int GetSize()
        {
            return list.Count;
        }
    }
}
