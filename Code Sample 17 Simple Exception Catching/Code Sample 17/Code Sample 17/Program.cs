using System;
namespace Code_Sample_17
    {
    class Program
        {
        static void Main(string[] args)
            {
            int age;
            Console.Write("Enater your age: ");
            string ageString = Console.ReadLine();
            try
            {
                age = int.Parse(ageString);
                Console.WriteLine("Thank you ");
             }
            catch
                {
                Console.WriteLine("Invalid age value");
                }Console.Read();
            }
        }
    }
