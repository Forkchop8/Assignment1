using System;

namespace Assignment1
{
    class Programs
    {
        static void Mains(string[] args)
        {
            String names;
            String names1;

            Console.WriteLine("Hello! please enter the first member's name:");
            names = Console.ReadLine();

            Console.WriteLine("please enter the second member's name:");
            names += " and " + Console.ReadLine();
            Console.WriteLine("Where do you study?");
            names1 = Console.ReadLine();

            

            Console.WriteLine("Hello " + names);
            Console.WriteLine("Enjoy your studies at" + names1);
        }
    }
}
