using System;
namespace Code_Sample_23
    {
    enum AccountState {New, Active, UnderAudit,
        Frozen, Closed };
    struct Account
        {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
        };
    class Program
        {
        static void Main(string[] args)
            {
            Account RobsAccount;
            RobsAccount.State = AccountState.Active;
            RobsAccount.Name = "Zeeshan";
            RobsAccount.Balance = 1000000;
            Console.WriteLine(RobsAccount.State+"   "+RobsAccount.Balance + "  "+RobsAccount.Name);
            Console.ReadKey(); 
            }
        }
    }
