using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        
        int broj = 5;   //ako se ne navede pravo pristupa je private

      
        public void IspišiČlan()
        {
            Console.WriteLine(this.broj);
        }
    }


    struct MojaStruktura
    {
        
        private string tekst; //struktura nemože imati inicijalizaciju, pravo pristupa kod strukutre je private

        public MojaStruktura(string tekst) {
            this.tekst = tekst;
        }
      
        public void IspišiČlan()
        {
            Console.WriteLine(this.tekst);
        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa mk = new MojaKlasa();
            mk.IspišiČlan();
           
        }

        public static void IspišiČlanStrukture()
        {
            MojaStruktura ms = new MojaStruktura("MojaStruktura");
            ms.IspišiČlan();
            MojaStruktura ms2 = new MojaStruktura();
            ms2.IspišiČlan();
           

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
