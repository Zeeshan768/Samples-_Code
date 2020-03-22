using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sample_07_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 1;i < 11; i=i+1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
