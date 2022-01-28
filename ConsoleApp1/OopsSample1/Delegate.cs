using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    public delegate void DisplayDelegate(string name);
    internal class Delegate
    {
        public static  void Display(string name)
        {
            Console.WriteLine(name);
        }
    }
}
