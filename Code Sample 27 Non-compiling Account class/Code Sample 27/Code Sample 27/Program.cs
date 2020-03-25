using System;
namespace Code_Sample_27
    {
    class Account
        {
        public string Name;
        }
    class StructAndObjectDemo
        {
        public static void Main(string[] args)
            {
            Account RobsAccount = new Account();
            RobsAccount.Name = "Rob";
            Console.WriteLine(RobsAccount.Name);
            Console.ReadKey();
            }
        }
    }
