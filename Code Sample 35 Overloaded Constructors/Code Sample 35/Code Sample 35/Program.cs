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
        public Account(string inName, string inAddress) :
            this(inName, inAddress, 0)
            {
            }
            public Account (string inName) :
            this (inName, "Not Supplied",0)
            {

            }
            
        }
    class Bank
        {
        static void Main(string[] args)
            {
            const int MAX_CUST = 100;
            Account [] Accounts = new Account[MAX_CUST];
            Accounts[0] = new Account("Rob", "Robs House", 100000);
            Accounts[1] = new Account("jim", "Jims House");
            Accounts[2] = new Account("Fred");
            }
        }
    }