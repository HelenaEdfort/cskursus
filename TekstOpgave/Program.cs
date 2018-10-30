using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Oprette to strenge – fornavn(Mikkel) og efternavn(Cronberg)

            String fornavn = "Mikkel";
            String efternavn = "Cronberg";

            //  Oprette en samlet streng samletNavn og sørge for at den får værdien ”Mikkel Cronberg”

            String samletNavn = fornavn + " " + efternavn;

            Console.WriteLine(samletNavn);

            //  Oprette en samlet streng navnStort som ud fra samletNavn får værdien ”MIKKEL CRONBERG”

            String navnStort = samletNavn.ToUpper();

            Console.WriteLine(navnStort);

            //  Oprette en samlet streng navnLille som ud fra samletNavn får værdien ”mikkel cronberg”

            String navnLille = samletNavn.ToLower();

            Console.WriteLine(navnLille);

            //  Oprette en samlet streng del som ud fra samletNavn får værdien ”Cron” (brug eksempelvis SubString-metoden)

            String del = samletNavn.Substring(7, 4);

            Console.WriteLine(del);

            //  Lege escape karakterer (tab = \t, newline = \r\n) (skriv ud til console)

            String navn = "Helena Edf\tort Kr\r\nistensen";

            Console.WriteLine(navn);

            //  Gemme en streng til en fil(System.IO.File.WriteAllText())

            System.IO.File.WriteAllText("C:\\temp\\navn.txt",navn);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

           




        }
    }
}
