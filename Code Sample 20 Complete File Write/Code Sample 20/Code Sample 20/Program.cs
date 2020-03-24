using System.IO;
namespace Code_Sample_20
    {
    class Program
        {
        static void Main(string[] args)
            {
            StreamWriter writer;
            writer = new StreamWriter("text.text");
            writer.WriteLine("hello world");
            writer.Close();

            }

        }
    }
