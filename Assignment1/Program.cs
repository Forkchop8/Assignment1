﻿using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            String names;

            Console.WriteLine("Hello! please enter the first member's name:");
            names = Console.ReadLine();
            Console.WriteLine("please enter the second member's name:");
            names += " and " + Console.ReadLine();

            Console.WriteLine("Hello " + names);
        }
    }
}
