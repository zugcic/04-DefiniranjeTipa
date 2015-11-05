using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        static int _brojač = 0;

        // TODO: U konstruktor dodati naredbu koja će uvećati _brojač za 1

        public MojaKlasa()
        {
        }

        // TODO: U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana _brojač

        public static void IspišiBrojInstanci()
        {
        }
    }

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
