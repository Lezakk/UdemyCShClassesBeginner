using System;

namespace UdemyClassesBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Age = 20;

            john.Introduce();

        }
    }

}
