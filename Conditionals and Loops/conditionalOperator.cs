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
            int age = 20;
            string msg;
            msg = (age >= 18) ? "Dewasa" : "Tidak Cukup Umur";
            Console.WriteLine(msg);
        }
    }
}
