using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinueOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Du skal skabe en simpel konsol applikation med en simpel for-løkke der tæller fra 0 til 19 - men følgende skal overholdes:
            //  Den må kun udskrive hver 3.tal(0, 3, 6, ...).Brug en if, modulus operatoren(%) og continue-kodeordet
            //  Den må kun tælle til 15.Brug en if og break-kodeordet

            for (int i = 0; i < 20; i++)
            {
                if (i % 3 != 0)
                    continue;
                if (i > 15)
                    break;

                Console.WriteLine(i);
    
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            
        }
    }
}
