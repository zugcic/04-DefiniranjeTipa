using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");

            for (int i = 0; i < 1000; i++)
            // ako stavimo veliki broj objekata, GC će u jednom trenutku 
            // početi oslobađati memoriju za nove objekte
            //for (int i = 0; i < 100000; i++)
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            Console.WriteLine("*** Izlazimo iz bloka ***");
            Debug.WriteLine("*** Izlazimo iz bloka ***");
            // explicitno pozivamo sustav za skupljanje smeća
            // redoslijed uništavanja objekata nije unaprijed definiran!
            GC.Collect();

            Debug.WriteLine("*** GOTOVO!!! ***");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();

            Debug.WriteLine("*** SADA JE KONAČNO!!! ***");
        }
    }
}
