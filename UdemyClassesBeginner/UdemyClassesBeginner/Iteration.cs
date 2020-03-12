using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesBeginner
{
    public class Iteration
    {
        public int HowManyNumbersBetween(int range)
        {
            int count = 0;
            for (int i = 1; i < range; i++)
            {
                if (i % 3 == 0) { count += 1; }
            }
            return count;
        }
    }
}
