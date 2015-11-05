using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        public MojaKlasa(int broj)
        {
            _broj = broj;
        }

        public int _broj;
    }

    struct MojaStruktura
    {
        public MojaStruktura(int broj)
        {
            _broj = broj;
        }

        public int _broj;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa(1);
            MojaKlasa mk2 = mk1;
            mk2._broj = 2;
            // TODO: Ispisati član _broj za obje instance te obrazložiti rezultat


            MojaStruktura ms1 = new MojaStruktura(10);
            MojaStruktura ms2 = ms1;
            ms2._broj = 15;
            // TODO: Ispisati član _broj za obje instance te obrazložiti rezultat


            Console.ReadKey();

        }
    }
}
