using System;
namespace Sample_Code_16
    {
    class Program
        {
        static string readString(string promp)
            {
            string result;
            do
                {
                Console.Write(promp);
                result = Console.ReadLine();
                } while(result == "");
            return result;
            }
        static int readInt(string promp,int low,int high)
            {
            int result;
            do
                {
                string intString = readString(promp);
                result = int.Parse(intString);
                } while((result < low) || (result > high));
            
        return result;
            }
        static void Main(string[] args)
            {
            const int SCORE_SIZE = 0;
            int [] score = new int[SCORE_SIZE];
            for(int i = 0; i < SCORE_SIZE; i = i +1)
                {
                score[i] = readInt("Score : ", 0, 1000);
                }
            for (int i = 0; i < SCORE_SIZE ; i = i +1)
                {
                Console.WriteLine( "Score: " + score[i]);
                }Console.ReadKey();
            }
        }
    }
