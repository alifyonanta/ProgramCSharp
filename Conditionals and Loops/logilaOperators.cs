using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 42;
            int grade = 75;
            if(age > 16 && age < 80 && grade > 50){ 
                Console.WriteLine("Hey there");
            }
            //AND
            double money = 540;
            if(age > 18 && money > 100) {
                Console.WriteLine("Welcome");
            }
            //OR
            int score = 85;
            if (age > 20 || score > 50) {
                Console.WriteLine("Welcome");
            }
            //NOT
            if ( !(age >= 16) ) {
                Console.Write("Your age is less than 16");
            }
        }
    }
}
