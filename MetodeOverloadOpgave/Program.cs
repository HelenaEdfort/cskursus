using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeOverloadOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            /*     Du skal skabe en tom konsol app hvor der i klassen Program findes tre statiske metoder med samme navn(Beregn).Den ene metoder tager to int’s som argumenter, 
             *     den anden tre int’s som argumenter og den tredje fire int’s som argumenter.Alle metoderne returnerer summen af argumenterne */

            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1,2,3));
            Console.WriteLine(Beregn(1,2,4,5));

            //Console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }


        }

        static int Beregn(int a, int b)
        {
        return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            //            return a + b + c;
            return Beregn(a, b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            //          return a + b + c + d;
            return Beregn(a, b, c) + d;
        }
    }
}
