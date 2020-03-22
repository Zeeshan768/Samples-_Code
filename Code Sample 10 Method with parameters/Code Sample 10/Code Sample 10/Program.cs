using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sample_10
{
    class MethodDDemo
    {
        static void silly(int i)
        {
            Console.WriteLine(" i is :" + i);
        }
        static void Main(string[] args)
        {
            silly(101);
            silly(101);
            Console.ReadKey();
        }
    }
}
