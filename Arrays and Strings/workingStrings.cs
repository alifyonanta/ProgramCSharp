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
            string text = "Saya sedang pergi ke pasar bersama sama. Saya beli sesuatu";
            text = text.Replace("pasar", "mall");
            text = text.Substring(0, text.IndexOf(".")+1);
            
            Console.WriteLine(text);
        }
    }
}
