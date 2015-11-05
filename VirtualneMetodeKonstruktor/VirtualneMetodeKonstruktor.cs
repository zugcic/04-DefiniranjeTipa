using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna()
        {
            Inicijalizacija();
        }

        protected virtual void Inicijalizacija()
        {
            // TODO: dodati kod za inicijalizaciju članova bazne
        }

        public int a;
        public string b;
    }

    class Izvedena : Bazna
    {
        public Izvedena()
        {
        }

        protected override void Inicijalizacija()
        {
            // TODO: dodati kod za inicijalizaciju članova izvedene klase
        }

        public double c;
    }

    class VirtualneMetodeKonstruktor
    {
        static void Main(string[] args)
        {
            // TODO: stvoriti po jednu instancu bazne i izvedene klase i provjeriti jesu li inicijalizirani svi njihovi članovi. Napraviti potrebne promjene.


            Console.ReadKey();
        }
    }
}
