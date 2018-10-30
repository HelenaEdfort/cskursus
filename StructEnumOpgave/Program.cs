using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Opret en enum kaldet FilTyper med værdierne csv, pdf, og txt.Opret en variabel ft af denne type, og tildel den værdien ”csv”. 

            FilTyper ft = FilTyper.csv;

            //  Udskriv ft-variablen. Overvej hvordan man kan udskrive værdien og ikke strengen.

            Console.WriteLine($"filtype = {ft}");

            StructEnumOpgave.FilTyper filtype = StructEnumOpgave.FilTyper.csv;
            int kode = (int)filtype;
            Console.WriteLine($"Kode = {kode}");
           


            //  Opret en struktur kaldet Person med en public int Id og public string Navn.

            // Opret en variabel p af denne type, og tildel Id værdien 1 og Navn værdien ”Mikkel”. Udskriv navnet.

            StructEnumOpgave.Person p = new StructEnumOpgave.Person();
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine($"p.Navn = { p.Navn }");

            //  Du kan vælge om du vil lægge struct og enum i en fil for sig selv eller i program.cs.

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
