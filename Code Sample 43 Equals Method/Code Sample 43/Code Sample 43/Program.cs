using System;
namespace Code_Sample_43
    {
    class Point
        {
        public int x;
        public int y;
        public override bool Equals(object obj)
            {
            Point p = (Point)obj;
            if((p.x == x) && (p.y == y))
                {
                return true;
                }
            else
                {
                return false;
                }
            }
        public Point(int inX,int inY)
            {
            x = inX;
            y = inY;
            }
        }
    class VideoGame
        {
        public static void Main(string[] args)
            {
            Point spaceshipPosition = new Point(10,10);
            Point missilePosition = new Point(10,10);
            if(missilePosition.Equals(spaceshipPosition))
                {
                Console.WriteLine("Bang");
                }

            Console.ReadKey();
            }
        }
    }
