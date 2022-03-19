using System;
using System.Collections.Generic;

namespace Framework_DaC_DAA
{
    public class InstanceGenerator
    {
        private int size;

        public InstanceGenerator(int size)
        {
            this.size = size;
        }

        public List<int> Generate()
        {
            if (size == 0)
            {
                return null;
            }
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(9000));
            }
            return list;
        }
    }
}
