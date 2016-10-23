using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.ClassStruct
{
    // TODO: Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public
    public class MojaKlasa
    {

    }

    // TODO: Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    public struct MojaStruktura
    {


    }

    class ClassStruct
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO: Pozvati metodu IspišiČlan za obje instance

            mk2.broj = 2;
            // TODO: Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat


            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            // TODO: Pozvati metodu IspišiČlan za obje instance

            ms2.tekst = "MyStruct";
            // TODO: Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
