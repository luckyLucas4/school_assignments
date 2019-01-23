using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labb_1b___Snake_eyes_och_Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("\nVälj program\n 1: Slå en sexa\n 2: Snake eyes\n 3: Yatzy");
                ConsoleKeyInfo knappTryck = Console.ReadKey();
                switch (knappTryck.KeyChar)
                {
                    case '1':
                        Alternativ1();
                        break;

                    case '2':
                        SnakeEyes();
                        break;

                    case '3':
                        Yatzy();
                        break;

                    default:
                        Console.WriteLine("\nFelaktig inmatning\n");
                        break;
                }

                void Alternativ1()
                {
                    Console.WriteLine("\n\n");
                    int tärning1 = 0;
                    int antalFörsök = 0;
                    Random randomObjekt = new Random();
                    while (tärning1 != 6)
                    {
                        // Simulerar ett tärningskast genom att slumpa mellan 1 och 6:
                        tärning1 = randomObjekt.Next(1, 7);
                        antalFörsök = antalFörsök + 1;
                        Console.WriteLine("Försök " + antalFörsök + ": " + tärning1);
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Det behövdes " + antalFörsök + " försök för att få en sexa!");

                    Console.ReadLine();
                }

                void SnakeEyes()
                {
                    Console.WriteLine("\n");
                    Random randomObjekt = new Random();
                    int throws = 0;

                    while (true)
                    {
                        throws++;

                        int tal1 = randomObjekt.Next(1, 7);
                        int tal2 = randomObjekt.Next(1, 7);

                        Console.WriteLine("  {0}, {1}", tal1, tal2);

                        if (tal1 == tal2 && tal1 == 1)
                        {
                            break;
                        }
                        Thread.Sleep(100);
                    }

                    Console.WriteLine("\nSnake eyes!! Det krävdes {0} försök", throws);
                    Console.ReadLine();
                }

                void Yatzy()
                {
                    Console.Write("\n\nAntal tärningar: ");
                    if (int.TryParse(Console.ReadLine(), out int dices) == false)
                    {
                        dices = 5;
                    }

                    Console.Write("\nAntal sidor: ");
                    if (int.TryParse(Console.ReadLine(), out int sides) == false)
                    {
                        sides = 6;
                    }


                    Random randomobjekt = new Random();
                    int throws = 0;

                    bool loop = true;
                    while (loop)
                    {
                        throws++;
                        Console.WriteLine("\n");
                        int[] values = new int[dices];
                        for(int i = 0; i < dices; i++)
                        {
                            values[i] = randomobjekt.Next(1, (sides + 1));
                            Console.Write("  {0}", values[i]);
                        }
                        bool yatzy = true;
                        foreach(int value in values)
                        {
                            if(value != values[0])
                            {
                                yatzy = false;
                                break;
                            }
                        }
                        if (yatzy)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("\n\nDet krävdes {0} kast.", throws);
                    Console.ReadLine();
                }
            }
        }
    }
}
