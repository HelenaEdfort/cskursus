using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesHeltSimpelOpgave
{
    // public delegate void MinDelegate1(string a);
    class Program
    {
        static void Main(string[] args)
        {
          //  MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
          //  f1.Invoke("test");

            Action<string> f2 = MinSkrivTilConsole;
            f2("test");

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine; ;
            f3("test");

            //f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
