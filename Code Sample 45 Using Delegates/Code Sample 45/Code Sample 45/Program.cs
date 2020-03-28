using System;
namespace Code_Sample_45
    {
    public delegate decimal CalculateFee(decimal balance);
    public class DelegateDemo
        {
        public static decimal RipoffFee(decimal balance)
            {
            Console.WriteLine("Calling the Ripoff Method");
            if(balance < 0)
                {
                return 100;
                }
            else
                {
                return 1;
                }
            }

        public static decimal FrindlyFee(decimal balance)
            {
            Console.WriteLine("Calling the Friendly Method");
            if(balance < 0)
                {
                return 10;
                }
            else
                {
                return 1;
                }
            }
        static void Main(string[] args)
            {
            CalculateFee calc;
            calc = new CalculateFee(RipoffFee);
            calc(-1);
            calc = new CalculateFee(FrindlyFee);
            calc(-1);
            Console.ReadKey();
            }
        }
    }
