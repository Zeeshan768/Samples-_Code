using System;
namespace Code_Sample_30
    {
    class Account
        {
        public string Name;
        }
    class StructAndObjectDemo
        {
        public static void Main(string[] args)
            {
            Account RobsAccount;
            RobsAccount = new Account();
            RobsAccount.Name = "Rob";
            Console.WriteLine(RobsAccount.Name);
            RobsAccount = new Account();
            RobsAccount.Name = "Jim";
            Console.WriteLine(RobsAccount.Name);
            Console.ReadKey();
            }
        }
    }