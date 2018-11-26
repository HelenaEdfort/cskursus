using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvSimpelOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Helena";
            p.Efternavn = "Kristensen";

            Elev e = new Elev();
            e.Fornavn = "Emil";
            e.Efternavn = "Hansen";
            e.KlasseLokale = "32A";


            Instruktør i = new Instruktør();
            i.Fornavn = "Anders";
            i.Efternavn = "Jensen";
            i.NøgleId = 123;
            
    
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(e.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return $"{Fornavn} { Efternavn}";           
        }
        
   
    }

    class Elev : Person
    {
        public string KlasseLokale { get; set; }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }

}
