using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4a___Slumpad_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] berries = { "blueberries", "cranberries", "bananas",
                "tomatoes", "watermelons", "eggplants", "elderberries" };

            Random randObj = new Random();
            int pos = 0;

            Console.WriteLine("Here's a list of common berries: \n");

            while (true)
            {
                for (int i = berries.Length - 1; i >= 0; i--)
                {
                    pos = randObj.Next(0, berries.Length);

                    string temp = berries[pos];
                    berries[pos] = berries[i];
                    berries[i] = temp;
                }

                foreach (string berry in berries)
                {
                    Console.WriteLine(berry);
                }
                Console.ReadLine();
            }
        }
    }
}
