using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businessdays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DateTime Factuurdatum= new DateTime(2015,01,25);
            Console.WriteLine("De factuurdatum is {0: dd-MM-yyyy}", Factuurdatum);
            DateTime Betaaldatum = Factuurdatum.AddDays(40);
            if ((int) Betaaldatum.DayOfWeek == 0)
                Betaaldatum = Betaaldatum.AddDays(1);
            else if ((int) Betaaldatum.DayOfWeek == 6)
                Betaaldatum = Betaaldatum.AddDays(2);
     

            Console.WriteLine("De uiterlijke betaaldatum is {0: dd-MM-yyyy}", Betaaldatum);
            Console.WriteLine("Deze dag is een {0}", Betaaldatum.DayOfWeek);

        }
    }
}
