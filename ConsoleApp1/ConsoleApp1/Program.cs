using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            FeaturePhone Nokia1000 = new Nokia(78689009849, "Nokia1000");
            Nokia1000.Information();
            Nokia1000.MakeACall(7655678899);
        }
    }
}
