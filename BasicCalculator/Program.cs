using System;
using System.Security.Authentication;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validChoices = { "+", "-", "*", "/", "%", "clear", "exit" };
            string choose;
            bool repeat = true;
            
            while (repeat)
            {
                Console.WriteLine("___________-_BASIC CALCULATOR_-___________\n");
                Console.WriteLine("1. penjumlahan       : +");
                Console.WriteLine("2. pengurangan       : -");
                Console.WriteLine("3. perkalian         : *");
                Console.WriteLine("4. pembagian         : /");
                Console.WriteLine("5. modulus           : %");
                Console.WriteLine("6. bersihkan         : clear");
                Console.WriteLine("7. keluar            : exit");

                Console.Write("\nChoose beetwen (+, -, *, /, %, clear, exit ) : ");
                choose = Console.ReadLine();

                if (Array.Exists(validChoices, s => s == choose))
                {
                    switch (choose)
                    {
                        case "clear":
                            Console.Clear();
                            break;

                        case "exit":
                            repeat = false;
                            break;

                        default:

                            if (choose != "clear" && choose != "exit")
                            {
                                Console.Write("\nMasukan angka pertama: ");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Masukan angka kedua: ");
                                double num2 = Convert.ToDouble(Console.ReadLine());

                                double result = 0;

                                bool showError = false;

                                switch (choose)
                                {
                                    case "+":
                                        result = num1 + num2;
                                        break;
                                    case "-":
                                        result = num1 - num2;
                                        break;
                                    case "*":
                                        result = num1 * num2;
                                        break;
                                    case "/":
                                        if (num2 != 0)
                                        {
                                            result = num1 / num2;
                                        }
                                        else
                                        {
                                            showError = true;
                                        }
                                        break;

                                    case "%":
                                        if (num2 != 0)
                                        {
                                            result = num1 % num2;
                                        }
                                        else
                                        {
                                            showError = true;
                                        }
                                        break;
                                }
                                if (showError)
                                {
                                    Console.WriteLine("\n untuk pembagi atau modulus angka kedua sebaiknya tidak berisikan 0!\n");
                                }
                                else
                                {
                                    Console.WriteLine($"\nHasil : {num1} {choose} {num2} = {result}\n");
                                }
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\ninvalid choice! try again\n");
                }
            }
        }
    }
}

