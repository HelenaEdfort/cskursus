using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingerSimpelOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst1 = new List<Person>();

            lst1.Add(new Person() { Id = 1, Navn = "Augusta" });
            lst1.Add(new Person() { Id = 2, Navn = "Victoria" });
            lst1.Add(new Person() { Id = 3, Navn = "Jacob" });

            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }

                        
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
