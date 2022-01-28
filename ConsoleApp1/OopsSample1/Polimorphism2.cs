using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    //overriding
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("Animal can make sound");
        }
    }
    public class Pig : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("My sound is like grrr grrr");
        }
    }
    public class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("My sound is like mew mew");
        }
    }
    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("my sound is like bow bow");
        }
    }
}
