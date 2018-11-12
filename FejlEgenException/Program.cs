using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlEgenException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Først checke om filen c:\temp\tal.txt eksisterer (System.IO.File.Exists).

            bool findes;
            findes = System.IO.File.Exists("c:\\temp\\tal.txt");

            Console.WriteLine($"Findes filen = {findes}");

            // Hvis den ikke findes skal der smides en ApplikationException med teksten "Filen c:\temp\tal.txt findes ikke!"

            // if (!System.IO.File.Exists("c:\\temp\\tal.txt"))
            //    throw new ApplicationException("Filen c:\\temp\\tal.txt findes ikke");

            // I en try/catch-struktur skal du nu: Åbne filen og hent indhold til en streng(System.IO.File.ReadAllText).Hvis det går galt skal fejlen blot smides videre.

            String filIndhold = "";

            try
            {
                filIndhold = System.IO.File.ReadAllText("c:\\temp\\tal.txt");
            }

            catch (Exception)
            {
                throw;
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }




        }
    }
}
