/*The Main method is static, as it is the starting point of any program. 
Therefore any method called directly from Main had to be static. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Sapi
        {
            public static void Perah() {
                Console.WriteLine("ini sapi perah");
            }
        }
        static void Main(string[] args)
        {
            Sapi.Perah();
        }
    }
}
