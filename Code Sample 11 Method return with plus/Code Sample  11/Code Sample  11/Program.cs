﻿using System;
namespace Code_Sample__11
    {
    class Program
        {
        static double readValue(
            string promp,
            double low,
            double high)
            {
            double result = 0;
            do
                {
                Console.WriteLine(promp + " between " + low +
                    " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
                } while((result < low) || (result > high));
            
            return result;
            }
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;

        public static void Main()
            {
            double windowWidth = readValue(
                "Enter width of window: ",MIN_WIDTH,MAX_WIDTH);
            Console.WriteLine("Width: " + windowWidth);
            double age = readValue("Enter your age: ",0,70);
            Console.WriteLine("Age " + age);
            Console.ReadKey();
            }
        }
    }
