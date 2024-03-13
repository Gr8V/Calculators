using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace calculator{
    class Program{
        static double firstNum;
        static double secondNum;
        public static void Main(string[] args)
        {
            bool shouldExit = false;
            while(!shouldExit){
                string? op = "";
                try{
                    Console.Write("First Number: ");
                    firstNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter a Operator: ");
                    op = Console.ReadLine();
                    if(op != "sqrt"){
                        Console.Write("Second Number: ");
                        secondNum = Convert.ToDouble(Console.ReadLine());
                    }
                }
                catch(FormatException ex){
                    Console.WriteLine("Format Error: "+ex.Message);
                }
                double output;
                switch(op){
                    case "+":
                        output = firstNum+secondNum;
                        break;
                    case "-":
                        output = firstNum-secondNum;
                        break;
                    case "*":
                        output = firstNum*secondNum;
                        break;
                    case "/":
                        output = firstNum/secondNum;
                        break;
                    case "**":
                        output = Math.Pow(firstNum, secondNum);
                        break;
                    case "sqrt":
                        output = Math.Sqrt(firstNum);
                        break;
                    default:
                        Console.WriteLine("Not a valid operator");
                        output = 0;
                        break;
                }
                Console.Write("Output: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(output);
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press ENTER to reset or ESCAPE to exit");
                while(true){
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if(keyInfo.Key == ConsoleKey.Enter){
                        Console.Clear();
                        break;
                    }
                    else if(keyInfo.Key == ConsoleKey.Escape){
                        shouldExit = true;
                        break;
                    }
                }
            }
        }
    }
}