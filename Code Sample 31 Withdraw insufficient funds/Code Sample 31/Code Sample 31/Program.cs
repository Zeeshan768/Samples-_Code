using System;
namespace Code_Sample_31
    {
    class Account
        {
        private decimal balance = 0;
        public bool WithdrawFunds(decimal amount)
            {
            if(balance < amount)
                {
                return false;
                }
            balance = balance - amount;
            return true;
            }
        };
    class Bank
        {
        static void Main(string[] args)
            {
            Account RobsAccount;
            RobsAccount = new Account();
            if(RobsAccount.WithdrawFunds(5))
                {
                Console.WriteLine("Cash Withdraw");
                }
            else
                {
                Console.WriteLine("Insufficient Funds");
                }
            }
        }
    }
