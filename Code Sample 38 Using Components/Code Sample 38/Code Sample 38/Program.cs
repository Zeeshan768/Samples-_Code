using System;
namespace Code_Sample_37
    {
    public interface IAccount
        {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
        }
    public class CustomerAccount : IAccount
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

        public decimal GetBalance()
            {
            return balance;
            }
        }
    class Bankl
        {
        static void Main(string[] args)
            {
            IAccount account = new CustomerAccount();
            account.PayInFunds(50);
            Console.WriteLine("Balance: " + account.GetBalance());
            }
        }
    }