﻿using System;

namespace OOPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Oskar";
            Console.WriteLine($"Hello {person.Name}");

            Person person1 = new Person("Oskar1");
            Console.WriteLine($"Hello {person1.Name}");

            person.SayHi();
            person1.SayHi();

            Console.ReadLine();
        }
    }
}
