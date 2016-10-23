using System;

namespace Vsite.CSharp
{
    public enum JedinicaDuljine
    {
        Milimetar,
        Centimetar,
        Decimetar,
        Metar,
        Kilometar
    }

    public struct Udaljenost
    {
        public double Broj;
        public JedinicaDuljine Jedinica;
    }


    public class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            // TODO: Stvoriti objekt strukture Udaljenost i ispisati vrijednosti članova.

            
            // TODO: U definiciji strukture Udaljenost dodati prazan konstruktor koji će inicijalizirati članove na neku vrijednost.
            // TODO: Stvoriti objekt pozivom tog konstruktora te ispisati vrijednosti članova.


        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            // TODO: U strukturi Udaljenost promijeniti prazan konstruktor tako da prima dva argumenta ("broj" i "jedinica") kojima se inicijaliziraju članovi. 
            // TODO: Stvoriti objekt pozivom tog konstruktora te ispisati vrijednosti članova.


        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            // TODO: U definiciji strukture Udaljenost dodati konstruktor koji prima samo argument "broj", a član "Jedinica" će konstruktor postaviti na JedinicaDuljine.Metar.
            // TODO: Stvoriti objekt pozivom tog konstruktora te ispisati vrijednosti članova.


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
