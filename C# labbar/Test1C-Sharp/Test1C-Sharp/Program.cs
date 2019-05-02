using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String m1 = "Press 'Enter' to continue, 'Tab' for 10 steps and 'Esc' to exit";
            while (true)
            {
                Console.WriteLine("Enter 'l' for Lucas Sequence or 'f' for Fibonacci sequence");
                switch ( Convert.ToChar( Console.ReadKey().Key ) )
                {
                    case 'l':
                        Console.WriteLine("\n{0}\nLucas sequence:", m1);
                        double num1 = 1;
                        double num2 = 2;
                        Console.WriteLine("{0}, {1}", num1, num2);
                        while (Console.ReadKey().Key != ConsoleKey.Escape)
                        {
                            int steps = 0;
                            ConsoleKey key = Console.ReadKey().Key;
                            if (key == ConsoleKey.Enter)
                                steps = 1;
                            else
                                steps = 10;


                        }
                        break;

                    case 'f':
                        Console.WriteLine("\nFibonnaci sequence:" + m1);
                        break;
                    
                    default:
                        Console.WriteLine("\nIncorrect input");
                        break;
                }
                //double tal1 = 2;
                //double tal2 = 1;
                //double summa;

                //while (true)
                //{
                //    Console.WriteLine(tal1 + " + " + tal2 + " = " + (tal1 + tal2));
                //    summa = tal1 + tal2;
                //    tal1 = tal2;
                //    tal2 = summa;

                //    Console.Read();

                //}
            }
        }

        double ContinueSequence (double num1, double num2, int steps)
        {
            double sum = 0;
            return sum;
        }
    }
}
