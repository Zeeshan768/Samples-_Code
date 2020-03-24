using System;
namespace Code_Sample_23
    {
    enum AccountState
        {
        New,
        Active,
        UnderAudit,
        Frozen,
        Closed
        };
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
            const int MAX_CUST = 100;
            Account[] Bank = new Account [MAX_CUST];
            Bank[0].Name = "Rob";
            Bank[0].State = AccountState.Active;
            Bank[0].Balance = 1000000;
            Bank[1].Name = "jim";
            Bank[1].State = AccountState.Frozen;
            Bank[1].Balance = 0;
            Console.WriteLine(Bank[0].Name+" "+Bank[1].State);
           Console.ReadKey();
            }
        }
    }