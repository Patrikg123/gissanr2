using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissanr2
{
    class Program
    {
        static void Main(string[] args)

        {
            Random r = new Random();
            int rattsvar = r.Next(10) + 1;
            int loop = 1;
            while (loop == 1)
            {
                Console.WriteLine("Gissa Numret");
                string textinstring = Console.ReadLine();
                int textin = Int32.Parse(textinstring);
                if (textin == rattsvar)
                {
                    Console.WriteLine("Rätt!");
                    Console.WriteLine("Tryck på en tangent för att avsluta");
                    Console.ReadLine();
                    loop = 0;
                }
                if (textin < rattsvar)
                    Console.WriteLine("Rätt svar är högre!");
                if (textin > rattsvar)
                    Console.WriteLine("Rätt svar är lägre!");

            }
        }
    }
}

