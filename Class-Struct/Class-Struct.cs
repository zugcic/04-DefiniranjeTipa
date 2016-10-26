using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    // TODO: Prekopirati kod klase iz prethodnog primjera i promijeniti pravo pristupa članu "broj" u public
    class MojaKlasa
    {

    }

    // TODO: Prekopirati kod strukture iz prethodnog primjera i promijeniti pravo pristupa članu "tekst" u public
    struct MojaStruktura
    {


    }

    public class ClassStruct
    {
        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            // TODO: Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.


            Console.WriteLine();
            // TODO: Otkomentirati donju naredbu.
            //mk2.broj = 2;
            // TODO: Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.


        }

        public static void IspišiStrukture()
        {
            // TODO: Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura"
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            // TODO: Pozvati metodu IspišiČlan za obje instance


            Console.WriteLine();
            // TODO: Otkomentirati donju naredbu.
            //ms2.tekst = "MyStruct";
            // TODO: Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.


        }

        static void Main(string[] args)
        {
            IspišiKlase();

            Console.WriteLine();

            IspišiStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
