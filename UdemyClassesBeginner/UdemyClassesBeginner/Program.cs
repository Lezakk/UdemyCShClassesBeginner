using System;

namespace UdemyClassesBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Conditions();
            test.InsertValuesToHeightAndWidth();
            Console.WriteLine(test.LandscapeOrPortrait(test.Height, test.Width));
        }
    }

}
