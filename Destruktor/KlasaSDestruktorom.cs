using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class KlasaSDestruktorom
    {
        public KlasaSDestruktorom()
        {
            // ispis u konzolu
            Console.WriteLine("Konstruktor klase 'KlasaSDestruktorom'.");
            // ispis u Output prozor Visual Studija
            Debug.WriteLine("Konstruktor klase 'KlasaSDestruktorom'.");
        }

        ~KlasaSDestruktorom()
        {
            // ispis u konzolu
            Console.WriteLine("Pozvan destruktor klase 'KlasaSDestruktorom'.");
            // ispis u Output prozor Visual Studija
            Debug.WriteLine("Pozvan destruktor klase 'KlasaSDestruktorom'.");
        }
    }
}
