using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        // TODO: Prekopirati definiciju klase s destruktorom iz prethodnog primjera
        public class KlasaSDestruktorom
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");

            for (int i = 0; i < 1000; i++)
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            Console.WriteLine("*** Pozivamo GC.Collect() ***");
            Debug.WriteLine("*** Pozivamo GC.Collect() ***");
            // explicitno pozivamo sustav za skupljanje smeća
            // redoslijed uništavanja objekata nije unaprijed definiran!
            GC.Collect();

            Debug.WriteLine("*** GOTOVO!!! ***");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Debug.WriteLine("*** SADA JE KONAČNO!!! ***");
        }
    }
}
