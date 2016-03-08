using System;
using Task1;

namespace ConsoleUI
{
    internal class Program{
        private static void Main(string[] args){
            double number, eps, result, result1;
            int n;
            Console.Write("Enter x: ");
            if (double.TryParse(Console.ReadLine(), out number)){
                Console.Write("Enter n: ");
                if (int.TryParse(Console.ReadLine(), out n)){
                    Console.Write("Enter eps:");
                    if (double.TryParse(Console.ReadLine(), out eps)){
                        result = Calculator.RootNewtonMethod(number, n, eps);
                        result1 = Math.Pow(number, (double)1 / n);
                        Console.WriteLine("{0}^(1/{1}) = " + result, number, n);
                        Console.WriteLine("Math.Pow({0},1/{1}): " + result1, number, n);
                        Console.ReadKey();
                    }
                }

            }
        }
    }
}

