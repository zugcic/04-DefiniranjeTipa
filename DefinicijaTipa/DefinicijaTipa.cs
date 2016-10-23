using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        // TODO: Dodati privatno polje (podatkovni član) "broj" tipa int i dodijeliti mu vrijednost 5


        // TODO: U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "broj".
        public void IspišiČlan()
        {

        }
    }


    struct MojaStruktura
    {
        // TODO: Dodati privatno polje (podatkovni član) "tekst" tipa string i dodijeliti mu vrijednost "MojaStruktura"


        // TODO: U metodu IspišiČlan dodati naredbu koja će ispisati podatkovni član "tekst".
        public void IspišiČlan()
        {

        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            // TODO: Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu IspišiČlan

        }

        public static void IspišiČlanStrukture()
        {
            // TODO: Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu IspišiČlan

        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
