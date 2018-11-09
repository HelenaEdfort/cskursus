using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeStatisk
{
    class Program
    {
        static void Main(string[] args)
        {   // For at lege lidt med instans- og statiske metoder så prøv at kigge på System.IO.File og System.IO.FileInfo
            // Opret en fil på c:\temp kaldet test.txt og put lidt tekst i

            // String navn = "Her er en tekst";

            //  Gemme en streng til en fil(System.IO.File.WriteAllText())

            // System.IO.File.WriteAllText("C:\\temp\\test.txt", navn);

            // Skriv kode der benytter (hjælpe)metoder fra System.File. Prøv Exists (findes filen)


            bool findes = System.IO.File.Exists(@"c:\temp\test.txt");

            Console.WriteLine($"Eksisterer filen: {findes}");

            // Prøv ReadAllText (henter tekst fra filen)

            string henttekst = System.IO.File.ReadAllText("c:\\temp\\test.txt");

            Console.WriteLine($"Teksten i filen er: {henttekst}");

            // Skriv kode der opretter et objekt der repræsenterer filen (System.FileInfo) 

            var fil = new System.IO.FileInfo(@"c:\temp.test.txt");

            // Udskriv LastAccessTime

            DateTime lat = fil.LastAccessTime;
            
            Console.WriteLine($"Tidspunkt = {lat}");

            // Udskriv Extension/Filtypen

            String filtype = fil.Extension;

            Console.WriteLine($"Filtypen er = {filtype}");

            //Console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }

        }
    }
}
