using System;
using System.IO;
namespace Code_Sample_21
    {
    class Program
        {
        static void Main(string[] args)
            {
            StreamWriter writer;
            writer = new StreamWriter("text.text");
            writer.WriteLine("hello world");
            writer.Close();

            StreamReader reader = new StreamReader("text.text");
            while(reader.EndOfStream == false)
                {
                string line = reader.ReadLine();
                Console.WriteLine(line);
                }
            reader.Close();
            Console.ReadKey();
            }
        }
    }