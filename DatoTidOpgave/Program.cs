using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatoTidOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //   Opret en DateTime d1, tildel den maskintid og udskriv den

            DateTime d1 = DateTime.Now;

            //   Læg nu 10 dage til(d1 = d1.AddDays(10)) og udskriv

            d1 = d1.AddDays(10);

            // Læg nu 20 minutter til og udskriv

            d1 = d1.AddMinutes(20);

            // Træk en måned fra (brug AddMonths(-1)) og udskriv

            d1 = d1.AddMonths(-1);

            Console.WriteLine($"d1 = {d1}");

            // Prøv at oprette to DateTime-variabler (d2 og d3), træk dem fra hinanden og udskriv antal dage
            DateTime d2;
            d2 = new DateTime(2010, 5, 1, 3, 5, 0);
            DateTime d3;
            d3 = new DateTime(2018, 6, 2, 1, 2, 3);
            TimeSpan dif = d3.Subtract(d2);

            Console.WriteLine($"Antal dage mellem d2 og d3 = {dif.TotalDays}");

            // Opret et TimeSpan t2, initialiser til 16:00:00 timer og skriv ud

            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine($"t2 = {t2.ToString()}");

            // Opret et TimeSpan t3, initialiser til kl. 00:30:00 minutter og skriv ud

            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine($"t3 = {t3.ToString()}");

            // Opret et TimeSpan t4, tildel den værdien af t2-t3 og skriv ud

            TimeSpan t4 = new TimeSpan(0,0,0);
            t4 = t2.Subtract(t3);

            Console.WriteLine($"t4 = {t4.ToString()}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            

        }
    }
}
