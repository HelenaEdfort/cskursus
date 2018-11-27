using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPersonOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start med at skabe en tom konsol applikation, og tilføj via NuGet pakken MCronbergPersonRepository (søg efter ”cronberg”). 
            //Det vil tilføje mappen /Models/PersonNuGetPackage og nogle klasser der kan bruges til at levere data som vi kan lege med ved hjælp af LINQ.
            // Prøv det først – hent et antal (10 eksempelvis) personer og udskriv navnet.

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);
          //  foreach (var person in people)
            //    Console.WriteLine(person.Name);

            // Sorter og udskriv efter navn og udskriv igen

            var sorteredeNavne = from person in people orderby person.Name select person;
            //foreach (var person in sorteredeNavne)
            //  Console.WriteLine(person.Name);

            // Sorter og udskriv efter gender og så navn

            var sorteretEfterKønOgNavn = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            var temp = from person in people orderby person.Gender, person.Name select person;
            // foreach (var person in sorteretEfterKønOgNavn)
               // Console.WriteLine(person.Name + " " + person.Gender);

            // Filtre og udskriv således, at der kun vises personer hvor height < 170

            var HøjdeUnder170 = from person in people where person.Height < 170 select person;
            foreach (var person in HøjdeUnder170)
                Console.WriteLine(person.Name + " " + person.Height);

            // Filtre og udskriv således, at der kun vises personer hvor height = < 170, isHealthy = true

            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
