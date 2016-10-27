using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    
    class MojaKlasa
    {

      public  int broj = 5;   //ako se ne navede pravo pristupa je private


        public void IspišiČlan()
        {
            Console.WriteLine(this.broj);
        }
    }

    
    struct MojaStruktura
    {

        public string tekst; //struktura nemože imati inicijalizaciju, pravo pristupa kod strukutre je private

        public MojaStruktura(string tekst)
        {
            this.tekst = tekst;
        }

        public void IspišiČlan()
        {
            Console.WriteLine(this.tekst);
        }
    }


    public class ClassStruct
    {
        public static void IspišiKlase()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            //  Napisati naredbe koje pozivaju metodu IspišiČlan za obje instance.
            Console.WriteLine(mk1.broj);
            Console.WriteLine(mk2.broj);

            Console.WriteLine();
            // TODO: Otkomentirati donju naredbu.
            mk2.broj = 2;
            //  Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            Console.WriteLine(mk1.broj);
            Console.WriteLine(mk2.broj);

        }

        public static void IspišiStrukture()
        {
            /*Objekti se alociraju na heapu a na stacku se nalaaze adrese objekata, a strukture se kompletno alociraju na stacku*/

            // TODO: Promijeniti poziv konstruktora tako da ispis bude "MojaStruktura"
            MojaStruktura ms1 = new MojaStruktura("MojaStruktura");
            MojaStruktura ms2 = ms1;
            // TODO: Pozvati metodu IspišiČlan za obje instance
            Console.WriteLine(ms1.tekst);
            Console.WriteLine(ms2.tekst);

            Console.WriteLine();
            // TODO: Otkomentirati donju naredbu.
            ms2.tekst = "MyStruct";
            // TODO: Ponovno pozvati metodu IspišiČlan za obje instance te obrazložiti rezultat.
            Console.WriteLine(ms1.tekst);
            Console.WriteLine(ms2.tekst);

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
