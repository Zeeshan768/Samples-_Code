using System;
namespace Code_Sample_22
    {
    enum TrafficLight
        {
        Red,
        RedAmber,
        Green,
        Amber
        };
    class Program
        {
        static void Main(string[] args)
            {
            TrafficLight light;
            light = TrafficLight.Red;
            Console.WriteLine(light);
            Console.ReadKey();
            }
        }
    }
