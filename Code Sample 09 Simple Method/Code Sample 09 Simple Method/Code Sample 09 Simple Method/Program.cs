using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sample_09_Simple_Method
{
    class MethDemo
    {
        static void doit()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            doit();
            doit();
            Console.ReadKey();
        }
    }
}
