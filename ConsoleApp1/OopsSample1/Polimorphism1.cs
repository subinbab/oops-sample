using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    //overloading
    internal class Polimorphism1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(string a , string b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(long a , long b)
        {
            Console.WriteLine(a + b);
        }
    }
}
