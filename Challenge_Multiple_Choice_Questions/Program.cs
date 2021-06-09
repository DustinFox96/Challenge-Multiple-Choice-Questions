using System;

namespace Challenge_Multiple_Choice_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Format one

            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}");


            //Console.WriteLine("How old are you?");
            //var age = Console.ReadLine();
            //Console.WriteLine($"Your age is {age} years old");


            //Console.WriteLine("What month were you born in?");
            //var month = Console.ReadLine();
            //Console.WriteLine($"You were born in the month of {month}");

            //Console.WriteLine("What is your favoriot color?");
            //var color = Console.ReadLine();
            //Console.WriteLine($"Your favoriot color is {color}");

            // Format two

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you");
            var age = Console.ReadLine();

            Console.WriteLine("What is your birth month?");
            var month = Console.ReadLine();

            Console.WriteLine("What is your favoriot color?");
            var color = Console.ReadLine();


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your favoriot color is: {0}", color);



        }
    }
}
