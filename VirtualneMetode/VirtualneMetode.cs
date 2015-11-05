using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        public virtual void IspisiImeVirtualno()
        {
            Console.WriteLine("Bazna Virtualno");
        }

        public void IspisiImeObicno()
        {
            Console.WriteLine("Bazna Obično");
        }
    }

    class Izvedena1 : Bazna
    {
        public override void IspisiImeVirtualno()
        {
            Console.WriteLine("Izvedena1 Virtualno");
        }

        // ključnom riječi new ćemo spriječiti upozorenje da
        // metoda IspisiImeObicno skriva istoimenu metodu bazne
        // klase:
        // public new void IspisiImeObicno() {
        public new void IspisiImeObicno()
        {
            Console.WriteLine("Izvedena1 Obično");
        }
    }

    class Izvedena2 : Bazna
    {
        public override void IspisiImeVirtualno()
        {
            Console.WriteLine("Izvedena2 Virtualno");
        }

        public new void IspisiImeObicno()
        {
            Console.WriteLine("Izvedena2 Obično");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bazna[] objekti = new Bazna[] { new Bazna(), new Izvedena2(), new Izvedena1() };

            foreach (Bazna o in objekti)
            {
                o.IspisiImeVirtualno();
            }

            foreach (Bazna o in objekti)
            {
                o.IspisiImeObicno();
            }

            Izvedena1 i1 = new Izvedena1();
            i1.IspisiImeObicno();

            Bazna biz1 = (Bazna)i1;
            biz1.IspisiImeObicno();
            biz1.IspisiImeVirtualno();

            Console.ReadKey();
        }
    }
}
