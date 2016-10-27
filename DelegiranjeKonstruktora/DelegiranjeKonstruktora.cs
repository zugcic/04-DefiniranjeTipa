using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna()
        {
            A = 5;
        }

        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
            Console.WriteLine(string.Format("Bazna.Bazna({0})", a));
        }

        public readonly int A;//član koji je read only samo se može čitati, zadati se može samo u konstruktoru
    }

    class Izvedena  : Bazna
    {
        public Izvedena():this(3,5)  //: base(5)//pozovi konstruktor Bazne klase Bazna i proslijedi 5
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena()"));
        }
        public Izvedena(int a, int b) : base(a) {

            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})",a,b));
        }

        public readonly int B;
    }

    public class DelegiranjeKonstruktora
    {
        public static void StvoriInstancuBazneKlase()
        {
            // TODO: Stvoriti instancu klase Bazna i ispisati vrijednost člana A.
            Bazna b = new Bazna();
            Console.WriteLine(b.A);
        }

        public static void StvoriInstancuIzvedeneKlasePraznimKonstruktorom()
        {
            // TODO: Promijeniti klasu Izvedena tako da je izvedena iz klase Bazna. Provjeriti da li se kod prevodi te napraviti potrebne promjene u klasi Izvedena.
            // TODO: Stvoriti instancu klase Izvedena pozivom podrazumijevanog konstruktora.
            Izvedena i = new Izvedena();
            // TODO: Ispisati vrijednosti članova A i B stvorenog objekta.
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // TODO: U klasu Izvedena dodati konstruktor s dva argumenta ("a" i "b") tipa int, kojima će se inicijalizirati članovi A i B. 
            // U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
            Izvedena i = new Izvedena();
            // TODO: Stvoriti objekt pozivom tog konstruktora i ispisati vrijednosti članova A i B stvorenog objekta.
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);

            // TODO: Promijeniti prazni konstruktor klase Izvedena tako da delegira poziv konstruktora s dva argumenta.

        }

        static void Main(string[] args)
        {
            StvoriInstancuBazneKlase();

            StvoriInstancuIzvedeneKlasePraznimKonstruktorom();

            StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }

}
