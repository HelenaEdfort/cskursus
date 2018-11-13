using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskabGetterOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(7,3);

            Console.WriteLine($"Arealet af trekanten er: {t.Areal}");
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Trekant
    {
        public int Grundlinje { get; private set; }

        public int Højde { get; private set; }

        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
         }

        
        public double Areal
        {
            get
            {
                return this.Grundlinje * this.Højde * 0.5;
            }
        }

    }

}
