using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIfOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ved hjælp af 2 løkker (loop) skal du skabe en 10-tabel på console der ser således ud: (Se opgavebeskrivelsen)

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    string tal = (i * j).ToString();
                    if ((i * j) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
