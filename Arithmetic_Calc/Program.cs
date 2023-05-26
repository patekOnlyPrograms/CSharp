using System;

namespace ArithmeticCalc{
    class Program{

        public void Addition(){
            Console.Write("Enter Value 1:" );
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value 2:" );
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("{0} + {1} = {2}", a,b,result);
        }
        
        public void Subtraction(){
            Console.Write("Enter Value 1:" );
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value 2:" );
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a - b;
            Console.WriteLine("{0} - {1} = {2}", a,b,result);
        }

        public void Multipliation(){
            Console.Write("Enter Value 1:" );
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value 2:" );
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a * b;
            Console.WriteLine("{0} * {1} = {2}", a,b,result);
        }
        
        public void Division(){
            Console.Write("Enter Value 1:" );
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value 2:" );
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a / b;
            Console.WriteLine("{0} / {1} = {2}", a,b,result);
        }


        static void Main(string[] args){
            Program myProgram = new Program();
            bool keepPlaying = true;
            
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            while (keepPlaying == true)
            {
                Console.WriteLine("Select Value: ");
                int OptionSelected = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(OptionSelected);
                switch (OptionSelected)
                {
                    case 1:
                        Console.WriteLine("Pressed 1");
                        myProgram.Addition();
                        break;
                    case 2:
                        Console.WriteLine("Pressed 2");
                        myProgram.Subtraction();
                        break;
                    case 3:
                        Console.WriteLine("Pressed 3");
                        myProgram.Multipliation();
                        break;
                    case 4:
                        Console.WriteLine("Pressed 4");
                        myProgram.Division();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Do you want to continue again (Y/N)?");
                char ExitOption = Convert.ToChar(Console.ReadLine());
                if(ExitOption == 'N'){
                    keepPlaying = false;
                }
            }

        }
    }
}