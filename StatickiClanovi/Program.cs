using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Nakon svakog poziva konstruktora pozvati metodu IspišiBrojInstanci()
            MojaKlasa mk1 = new MojaKlasa();

            MojaKlasa mk2 = new MojaKlasa();

            mk1 = new MojaKlasa();

            Console.ReadKey();
        }
    }
}
