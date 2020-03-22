using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sample_06 
{
    class  WhileLoopInsteadOfFor
    {
        static void Main(string[] args)
        {
            int i;
            i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);

                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}
