using System;

namespace Vsite.CSharp.KonstruktorKlase
{
    public enum Spol
    {
        Muški,
        Ženski
    }

    public class Osoba
    {
        //public Osoba()
        //{

        //}

        //public Osoba(string ime, string prezime, DateTime datumRođenja, Spol spol)
        //{

        //}

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly Spol Spol;
    }

    class KonstruktorKlase
    {
        static void Main(string[] args)
        {
            // TODO: Stvoriti objekt klase Osoba i ispisati vrijednosti članova
            


            // TODO: U klasu Osoba dodati prazan konstruktor koji inicijalizira članove objekta na neku vrijednost te ponoviti gornji postupak



            // TODO: U klasi Osoba promijeniti prazan konstruktor tako da prima 4 argumenta (ime, prezime, datumRođenja i spol) kojima se inicijaliziraju članovi objekta te ponoviti gornji postupak


            Console.ReadKey();
        }
    }
}
