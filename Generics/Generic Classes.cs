using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Stack<T> {
            int index=0;
            T[] innerArray = new T[100];
            public void Push(T item) {
                innerArray[index++] = item; 
            }
            public T Pop() {
                return innerArray[--index]; 
            }
            public T Get(int k) { return innerArray[k]; }
        }
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(5);
            
            Console.WriteLine(intStack.Get(1));
        }
    }
}
