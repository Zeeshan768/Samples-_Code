namespace Code_Sample_34
    {
    class Account
        {
        private string name;
        private string address;
        private decimal balance;
        public  Account(string inName,string inAddress,decimal inBalance)
            {
            name = inName;
            address = inAddress;
            balance = inBalance;
            }
        }
    class Bank
        {
        static void Main(string[] args)
            {
            Account robAccount;
            robAccount = new Account("Rob","Robs House",100000);
            }
        }
    }
