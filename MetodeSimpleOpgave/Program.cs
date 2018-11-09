using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeSimpleOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat1 = Lægsammen(2, 7);
            Console.WriteLine(resultat1);

            double resultat2 = BeregnAreal(4.5);
            Console.WriteLine(resultat2);

            udskriv("Helena test");

            //Console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }

        }


        static int Lægsammen(int a, int b)
        {

            return a + b;        

        }

        static double BeregnAreal(double radius)
        {

            return radius * radius * Math.PI;

        }

        static void udskriv(string txt)
        {

            Console.WriteLine(txt);

        }
    }
}
