using System;

namespace Vsite.CSharp
{
    public class JavnaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("JavnaBazna");
        }
    }

    public class Bazna  //ako ništa ne navedemo klasi je pravo pristupa internal znači da se može koristi unutar modula
    {
        public void IspišiMe()
        {
            Console.WriteLine("???Bazna");
        }
    }
}
