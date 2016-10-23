using System;

namespace Vsite.CSharp
{
    public class Gnijezdo
    {
        class Ugnježđena
        {
            public void IspišiMe()
            {
                Console.WriteLine("Ugnježđena");
            }

            public void PredstaviSe()
            {
                Console.WriteLine("Ja sam klasa Ugnježđena");
            }

            public void PredstaviSeNeposredno()
            {
                Console.WriteLine("Ja sam klasa Ugnježđena, neposredno");
            }
        }

        // TODO: Napisati implementaciju metode IspišiMe koja će pozvati metodu IspišiMe iz klase Ugnježđena
        public void IspišiMe()
        {
        }
    }


    public class IzvedenoGnijezdo : Gnijezdo
    {
        // TODO: Napisati implementaciju metode PredstaviSe koja će pozvati metodu PredstaviSe iz klase Ugnježđena
        public void PredstaviSe()
        {

        }
    }
}
