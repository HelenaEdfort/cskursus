using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeRekursiv
{
    class Program
    {

/*        Du skal skabe en tom konsol app der på konsol skal udskrive tal fra 1 til 10 – men du må ikke bruge en løkke struktur(for, foreach, do, while mv).

          Du skal i stedet skabe en metode der kalder sig selv et givet antal gange og der opskriver og udskriver.*/

        static void Main(string[] args)
        {
            RekursivMetode(1, 10);



        if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }


        }
        static void RekursivMetode(int start, int stop)
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            RekursivMetode(start, stop);

        }

    }
}
