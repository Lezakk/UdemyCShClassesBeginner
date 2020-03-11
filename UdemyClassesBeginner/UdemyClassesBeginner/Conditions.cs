using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesBeginner
{
    public class Conditions
    {
        public string ValidTest(int number)
        {
            var result = number > 0 && number < 11 ? "Valid" : "Invalid";
            return result;
        }
    }
}
