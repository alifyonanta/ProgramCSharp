using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Some text test";
            File.WriteAllText("test.txt", str);
            
            string txt = File.ReadAllText("test.txt");
            Console.WriteLine(txt); 
        }
    }
}
