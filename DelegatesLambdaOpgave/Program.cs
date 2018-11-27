using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLambdaOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
           
            // Uden Lambda
            Console.WriteLine(a.FindIndex(Find));
            
            // Lambda med return
            Console.WriteLine(a.FindIndex((b) => { return b == 51; }));

            // Lambda uden return
            Console.WriteLine(a.FindIndex(b => b == 51));

            // Uden Lambda
            a.ForEach(ListVærdi);
            Console.WriteLine();

            // Med Lambda
            a.ForEach(i => { Console.WriteLine(i); });

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static bool Find(int b)
        {
            return b==51;
        }

        static void ListVærdi(int c)
        {
            Console.WriteLine(c);
        }
    }
}
