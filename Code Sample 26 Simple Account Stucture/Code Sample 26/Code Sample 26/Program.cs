using System;
namespace Code_Sample_26
    {
    struct AccountStruct
        {
        public string Name;
        };
    class Program
        {
        static void Main(string[] args)
            {
            AccountStruct RobsAccountStruct;
            RobsAccountStruct.Name = "Rob";
            Console.WriteLine(RobsAccountStruct.Name);
            Console.ReadKey();
            }
        }
    }
