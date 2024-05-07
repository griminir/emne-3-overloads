using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_overloads
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; } 

        public Person(string name, int age) // Eksemple om jeg vet navnet og alderne 
        {
            Name = name;
            Age = age;
        }

        public Person(string name) // om jeg vet navnet men ikke alderen
        {
            Name = name;
        }

        public void PrintWelcomeMsg(string name = "Terje")
        {
            Console.WriteLine($"hei {name}");
        } 

        public void PrintInfo()
        {
            Console.WriteLine($"navn: {Name} alder: {Age}");
        }
    }

}
