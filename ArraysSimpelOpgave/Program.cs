using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSimpelOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            // I en tom konsol-app skal du oprette et (int) array med et antal tilfældige månedslønninger, udskrive disse samt et beregne et gennemsnit.

            int[] ml = { 3000, 7000, 5000, 6000 };
            int sum = 0;
            for (int i = 0; i < ml.Length; i++)
            {
                sum += ml[i];
                Console.WriteLine(ml[i]);
            }
//            Console.WriteLine($"summen er {sum:N2}");
            double gns = sum / ml.Length;
            Console.WriteLine($"Gennemsnittet er {gns:N2}");

            int Sortering(int[] array)
            {
                System.Array.Sort(array);
                return array[0];
            }

            Console.WriteLine($"Mindsteværdi er : {Sortering(ml)}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
