using System;

namespace UdemyClassesBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\wikto\Desktop\test.txt";
            Files.LongestWordInFile(path);
            Console.ReadKey();
        }
    }

}
