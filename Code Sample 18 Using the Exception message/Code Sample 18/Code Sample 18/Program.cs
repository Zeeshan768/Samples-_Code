using System;
namespace Code_Sample_17
    {
    class Program
        {
         public static void Main()
            {
            int age;
            Console.Write("Enater your age: ");
            string ageString = Console.ReadLine();
            try
            {
                age = int.Parse(ageString);
                Console.WriteLine("Thank you ");
             }
            catch(Exception e)
                {
                Console.WriteLine(e.Message);
                }Console.Read();
            }
        }
    }