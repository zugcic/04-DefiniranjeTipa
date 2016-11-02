using System;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;

        public Osoba() {
            this.Ime = "Ivica";
            this.Prezime = "Kičmanović";
            this.DatumRođenja = DateTime.Now;
        }

        public Osoba(string ime,string prezime,DateTime datum_rođenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRođenja =datum_rođenja ;
        }
    }

    public class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            // Stvoriti objekt klase Osoba i ispisati vrijednosti članova Ime, Prezime, DatumRođenja
            Osoba osoba=new Osoba();
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.DatumRođenja);
            //U klasu Osoba dodati prazni konstruktor koji inicijalizira članove objekta na neku vrijednost, ponovno pokrenuti program i provjeriti ispis.
           
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.DatumRođenja);

        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            // U klasi Osoba promijeniti prazan konstruktor tako da prima 3 argumenta (ime, prezime, datumRođenja) kojima se inicijaliziraju članovi objekta.
            Osoba osoba = new Osoba("Ivica","Kičmanović",DateTime.Now);
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.DatumRođenja);

            // Stvoriti objekt klase Osoba pozivom tog konstruktora i ispisati vrijednosti članova Ime, Prezime, DatumRođenja


        }


        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
