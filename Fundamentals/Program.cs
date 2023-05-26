using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Type Casting
            //Implicit Conversion
            int i = 10;
            double d = i;
            object o = new Program();

            //Explicit Conversion
            double pi = 3.1417;
            i = (int)pi;
            Console.WriteLine(i);
            string s = "22";
            int age = int.Parse(s);
            Console.WriteLine(age);

            //Arrays
            string[] friends = new string[4];
            friends[0] = "John";
            friends[1] = "Chris";
            string[] friends2 = { "Ali", "Lee" };
            //string[] friends3 = new string[2] { "Ali", "Lee","hi"};
            //turns out C# is a indexed at 1 rather than 0
            
            //Multideminsion array
            //type[,] my2dArray = new int[rowSize, colSize];
            //the first number is a row count and then the column count
            int[,] numbers = new int[2, 2]
            {
                {1,2},
                {3,4}
            };
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for(int col = 0; col < numbers.GetLength(1); col++){
                    Console.Write(numbers[row,col]);
                }
                Console.WriteLine();
            }
            
            //Jagged Arrays
            // int [][] jagged = new int [4][];
            // jagged[0] = new int[2];
            // jagged[1] = new int[3];
            // jagged[2] = new int[4];
            // jagged[2] = new int[5];

            //one way of initalising jagged array values
            // jagged[0][0] = 4;
            // jagged[0][1] = 5;

            //another way of initalsing jaggered array values
            //jagged[1] = new int[] { 6, 7, 8 };

            //another way of initalsing jaggered array values
            int[][] jagged =
            {
                new int[]{4,5},
                new int[]{6,7,8},
                new int[]{9,10,11},
                new int[]{12,13,14,15}
            };

            //getting values via looping
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int column = 0; column < jagged[row].Length; column++)
                {
                    Console.Write(jagged [row] [column]);
                }
                Console.WriteLine();
            }

            //Conditional Operators
            //(Condition) ? True_Statement : Flase_Statement;
            int number2 = 3;
            string result = (number2 % 2 == 0) ? "EVEN" : "ODD";
            Console.WriteLine("{0} is {1}", number2, result);
            
            //Null Coalescing operator
            //leftOperand ?? rightOperand
            //set username = name, if name is not null.
            //set username = “user”, if name is null.
            string name = null;
            string username = name ?? "user";

              

        }

    }
}

// See https://aka.ms/new-console-template for more information

