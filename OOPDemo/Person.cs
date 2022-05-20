using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class Person
    {
        //fields, properties
        public string Name { get; set; }

        //constructors
        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        //if we have the same names of variables we need to mark the primary field with keyword "this"
        //public Person(string Name)
        //{
        //    this.Name = Name;
        //}

        //methods

        public void SayHi()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }
}
