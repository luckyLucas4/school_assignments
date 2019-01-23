using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fält_av_nummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomobjekt = new Random();
            int cols = 20;
            int rows = 20;
            int[,] array = new int[cols,rows];
            int tal1;
            int tal2;
            int tal3;
            int tal4;
            int summa1 = 100000;
            int summa2 = 0;
            int rattCols = 0;
            int rattRow = 0;

            for(int i = 0; i < cols; i++){
                for (int j = 0; j < rows; j++)
                {
                    array[i,j] = randomobjekt.Next(100);
                }
            }
            for (int u = 0; u < cols; u++){
                for (int y = 0; y < (rows - 3); y++){
                    tal1 = array[u, y];
                    tal2 = array[u, y + 1];
                    tal3 = array[u, y + 2];
                    tal4 = array[u, y + 3];

                    summa2 = tal1 * tal2 * tal3 * tal4;
                    if (summa1 < summa2) 
                        {
                        summa1 = summa2;
                        rattCols = u;
                        rattRow = y;
                        }
                        
                    }
                }

            for (int g = 0; g < cols; g++)
            {
                for (int h = 0; h < rows; h++)
                {
                    if( g == rattCols && h == rattRow || g == rattCols  && h == rattRow + 1 || g == rattCols  && h == rattRow + 2 || g == rattCols   && h == rattRow + 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(array[g, h].ToString("D2") + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine(summa2);
            Console.ReadLine();
        }
    }
}
