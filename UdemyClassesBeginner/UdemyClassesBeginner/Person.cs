using System;

namespace UdemyClassesBeginner
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", this.FirstName, this.LastName);
        }
    }

}
