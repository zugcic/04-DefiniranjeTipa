using System;

namespace Vsite.CSharp
{
    public enum JedinicaDuljine
    {
        Milimetar,
        Centimetar,
        Decimetar,
        Metar,
        Kilometar ,
      
    }

    public struct Udaljenost
    {
        public double Broj;
        public JedinicaDuljine Jedinica;

        public Udaljenost(double broj,JedinicaDuljine jedinica)
        {
            this.Broj = broj;
            this.Jedinica = jedinica;
        }

        public Udaljenost(double broj)
        {
            this.Broj = broj;
            this.Jedinica = JedinicaDuljine.Kilometar;
        }

    }


    public class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.
            Udaljenost u=new Udaljenost();
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);


            //  U definiciji strukture Udaljenost dodati prazan konstruktor koji će inicijalizirati članove na neku vrijednost.
            //  Stvoriti objekt pozivom tog konstruktora te ispisati vrijednosti članova.
            
            //Nije dozoljeno dodavati konstruktore bez argumenata

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            //  U strukturi Udaljenost promijeniti prazan konstruktor tako da prima dva argumenta ("broj" i "jedinica") kojima se inicijaliziraju članovi. 


            //  Stvoriti objekt pozivom tog konstruktora te ispisati vrijednosti članova.
            Udaljenost u = new Udaljenost(broj,jedinica);
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // U definiciji strukture Udaljenost dodati konstruktor koji prima samo argument "broj", a član "Jedinica" će konstruktor postaviti na JedinicaDuljine.Metar.
            // Stvoriti objekt pozivom tog konstruktora te ispisati vrijednosti članova.
            Udaljenost u = new Udaljenost(broj);
            Console.WriteLine(u.Broj);
            Console.WriteLine(u.Jedinica);



        }

        static void Main(string[] args)
        {

            PozivPodrazumijevanogKonstruktora();

            PozivKonstruktoraSDvaArgumenta(5, JedinicaDuljine.Kilometar);

            PozivKonstruktoraSJednimArgumentom(17);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
