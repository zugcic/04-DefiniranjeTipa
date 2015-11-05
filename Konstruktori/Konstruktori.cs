using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Bazna
    {
        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
        }

        public readonly int A;
    }

    class Izvedena : Bazna
    {
        public Izvedena()
            : this(0, 0)
        {
        }

        public Izvedena(int a, int b)
            : base(a)
        {
            B = b;
        }

        public readonly int B;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // nije moguće stvoriti instancu klase jer je konstruktor zaštićen
            //Bazna b = new Bazna(3);

            Izvedena i1 = new Izvedena();
            Console.WriteLine("A={0} B={1}", i1.A, i1.B);

            Izvedena i2 = new Izvedena(2, 3);
            Console.WriteLine("A={0} B={1}", i2.A, i2.B);
        }
    }

}
