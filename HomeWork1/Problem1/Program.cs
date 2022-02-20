using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input Num1:");
            double Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("input Num2:");
            double Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("input Operator:");
            string Op = Console.ReadLine();
            Calculator c = new Calculator();
            c.Calculate(Num1, Num2, Op);
        }
    }
    
    class Calculator
    {
        public void Calculate(double Num1,double Num2,string Op)
        {
            while(Op!="+"&&Op!="-"&&Op!="*"&&Op!="/"&&Op!="%")
            {
                Console.WriteLine("Illegal operator. Input operator again:");
                Op = Console.ReadLine();
            }
            switch(Op)
            {
                case "+":
                    Console.WriteLine($"Result:{Num1 + Num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result:{Num1 - Num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result:{Num1 * Num2}");
                    break;
                case "/":
                    while(Num2==0)
                    {
                        Console.WriteLine("Illegal Num2. Input Num2 again:");
                        Num2 = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Result:{Num1 / Num2}");
                    break;
                case "%":
                    while (Num2 == 0)
                    {
                        Console.WriteLine("Illegal Num2. Input Num2 again:");
                        Num2 = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Result:{Num1 % Num2}");
                    break;
                default:
                    Console.WriteLine("Illegal operator!");
                    break;
            }
        }
    }
}
