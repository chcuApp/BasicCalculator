using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka pertama: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("masukan angka kedua: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("masukan operator (+, -, *, /, %): ");
            char op = Console.ReadKey().KeyChar;
            Console.ReadLine(); //perlu klik enter sebelum program di eksekusi

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("\nzero is invalid division!");
                        return;
                    }
                    break;
                case '%':
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                    }
                    else
                    {
                        Console.WriteLine("\nzero is invalid mod!");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("\nunvalid operator");
                    return;
            }

            Console.WriteLine($"\nResult = {num1} {op} {num2} = {result}");
        }
    }
}

