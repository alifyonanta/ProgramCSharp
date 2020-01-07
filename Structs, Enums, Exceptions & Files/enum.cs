using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
        static void Main(string[] args)
        {
            int x = (int)Days.Tue;
            Console.WriteLine(x);
        }
    }
}
