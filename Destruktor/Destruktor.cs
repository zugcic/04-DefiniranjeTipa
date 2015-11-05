using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
                // iako izlazimo iz bloka, destruktor se ne poziva
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
