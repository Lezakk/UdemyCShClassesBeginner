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
        public void SumOfEnteredNumbers()
        {
            int result = 0;
            while (true)
            {
                Console.WriteLine("Enter number:");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                else result += int.Parse(input);
            }
            Console.WriteLine(result);
        }

        public int Fractional(int i)
        {
            int result = 1;
            if (i>0)
            {
                result = i * Fractional(i - 1);
            }
            return result;
        }
    }
}
