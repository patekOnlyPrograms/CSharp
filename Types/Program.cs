using System;

namespace Types
{
    enum Status{
        Alive,
        Injured,
        Dead
    }

    struct Vector
    {
        public int x;
        public int y;
    }

    struct Vector2
    {   
        public Vector2(int a, int b)
        {
            x = a;
            y = b;    
        }
        public int x;
        public int y;
    }
    class Program{
        static void Main(string[] args){
            //Three types
            //Enum, struct, class
            Status player = Status.Alive;
            switch (player)
            {
                case Status.Alive:
                    break;
                case Status.Injured:
                    break;
                case Status.Dead:
                    break;
            }
            //default values start from 0
            int valueOfAlive = (int)Status.Alive;
            Console.WriteLine(valueOfAlive);
            //Can override numbers in the enums

            //Struc
            Vector vector = new Vector();
            vector.x = 5;
            vector.y = 10;

            Console.WriteLine($"x = {vector.x}");
            Console.WriteLine("y = {0}", vector.y);

            //Constructors in strucs
            Vector2 vector2 = new Vector2(5,10);

            Console.WriteLine("x = {0}", vector2.x);
            Console.WriteLine("y = {0}", vector2.y);

        }
    }
}
