using System;
namespace Sample_Code_15
    {
    class Program
        {
        static int member = 0;
        static void Othermethod()
            {
            member = 99;
            }
        static void Main()
            {
            Console.WriteLine("member is : " + member);
            Othermethod();
            Console.WriteLine("member is now : " + member);
            Console.ReadKey();
            }
        }
    }
