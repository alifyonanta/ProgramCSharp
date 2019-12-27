using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person {
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            Student a = new Student("Joko");
            a.Speak();
            s.Speak();
        }
    }
}
