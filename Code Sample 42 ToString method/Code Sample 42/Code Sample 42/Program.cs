using System;
namespace Code_Sample_42
    {
    class Account
        {
        private string name;
        private decimal balance;
        public override string ToString()
            {
            return "Name: " + name + "balance: " + balance;
            }
        public Account(string inName,decimal inBalance)
            {
            name = inName;
            balance = inBalance;
            }
        }
    class bhance 
        {
        private string name;
        private decimal balance;
        public override string ToString()
            {
          return  "balance: " + balance + "Name: " + name ;
            }
         public bhance(string inName,decimal inBalance)
            {
            name = inName;
            balance = inBalance;
            }
        }
    class Bank
        {
        static void Main()
            {
            Account a = new Account("Rob",25);
            Console.WriteLine(a);
            bhance b = new bhance("jim",22);
            Console.WriteLine(a);
            Console.ReadKey();
            }
        }
    }
