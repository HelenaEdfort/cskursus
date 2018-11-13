using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSplitOpgave
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Du skal nu ved hjælp af Split-funktion (txt.Split) splitte strenge til et string-array (string[]). 
            // Herefter skal du løbe arrayet igennem, konvertere hvert element til et tal (int), og finde summen af samtlige tal og udskrive denne.
            string txt = "3;5;22;1;10;15;5";

            string[] numre = txt.Split(';');

            int sum = 0;

            for (int i = 0; i < numre.Length; i++)
            {
                int tal = Convert.ToInt32(numre[i]);
                sum += tal;
            }
            Console.WriteLine($"Summen er = {sum:N0}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
