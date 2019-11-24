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
            int[ ] arr = {11, 35, 62, 555, 989};
            int sum = 0; 
            
            foreach (int x in arr) {
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
