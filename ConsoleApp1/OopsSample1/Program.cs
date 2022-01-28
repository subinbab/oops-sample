using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dimension_Shape rt = new Rectangle("Red", 45, 5);
            Console.WriteLine("My Rectangle room color is :" + rt.GetColor() + " my room area is :" + rt.GetArea());
            Dimension_Shape cr = new Circle("Yellow", 5);
            Console.WriteLine("My Circle room color is :" + rt.GetColor() + " my room area is :" + rt.GetArea());*/
            /*
                        Encapsulation en = new Encapsulation();
                        en.Login("subin", "subin@123");*/
            /*Polimorphism1 polimorphism = new Polimorphism1();
            polimorphism.Add("Subin ", "Babu");
            polimorphism.Add(23, 45);
            polimorphism.Add(124565653, 8766787656789);*/



            DisplayDelegate displayDelegate = new DisplayDelegate(Delegate.Display);
            displayDelegate("Subin");

        }
    }
}
