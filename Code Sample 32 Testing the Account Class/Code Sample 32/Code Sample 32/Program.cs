using System;
namespace Code_Sample_32
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

        public void PayIntFunds(decimal amount)
            {
            balance = balance + amount;
            }
        public decimal GetBalance()
            {
            return balance;
            }
        }
    class Bank
        {
        public static void Main(string[] args)
            {
            Account test = new Account();
            test.PayIntFunds(50);
            if(test.GetBalance() != 50)
                {
                Console.WriteLine("Pay in test failed");
                }
            else
                {
                Console.WriteLine("Pay In test succeeded");
                }
            Console.ReadKey();
            }
        }
    }
