using System;

namespace survey_challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'Learning C# Challenge 1: Simple Survey'\n\nWhat is your Name? ");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            var age = Console.ReadLine();


            Console.WriteLine("What month were you born in? ");
            var month = Console.ReadLine();

            var results = "Ypur name is " + name + ", you are " + age + " years old and you were born in " + month;
            Console.WriteLine(results);
        }
    }
}
