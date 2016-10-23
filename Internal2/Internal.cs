using System;

namespace Vsite.CSharp
{
    class Internal
    {
        static void Main(string[] args)
        {
            // TODO: Prevedite kod i popravite pogreške koje prevoditelj prijavljuje

            IzvedenaIzJavneBazne izvedenaIzJavne = new IzvedenaIzJavneBazne();
            izvedenaIzJavne.IspišiMe();

            IzvedenaIzBazne izvedenaIzBazne = new IzvedenaIzBazne();
            izvedenaIzBazne.IspišiMe();


            // TODO: U klasi IzvedenaIzInterneBazneLokalne treba na neki način omogućiti poziv metode IspišiMe iz klase InternaBaznaLokalna ali bez promjene koda klase InternaBaznaLokalna!

            IzvedenaIzInterneBazne izvedenaIzInterne = new IzvedenaIzInterneBazne();
            izvedenaIzInterne.IspišiMe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
