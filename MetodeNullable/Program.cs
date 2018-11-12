using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tilføj en metode HentFraDb der tager en int som argument og return en nullable bool. Metoden simulerer kald til en database efter et felt med en mulig null-værdi
            // Hvis int = 1 returneres true
            // Hvis int = 2 restureres false
            // Ellers returneres null

            bool? test;

            test = HentFraDb(1);
            Console.WriteLine($"null = {test}");

            test = HentFraDb(2);
            Console.WriteLine($"null = {test}");

            test = HentFraDb(5);
            Console.WriteLine($"null = {test}");
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
                
            }

        }

        static bool? HentFraDb(int a)
        {
            if (a == 1)
                return true;
            if (a == 2)
                return false;
            return null;
        }
    }
}
