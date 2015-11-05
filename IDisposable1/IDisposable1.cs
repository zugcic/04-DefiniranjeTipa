using System;
using System.IO;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Stvaram 'RadSDatotekom'.");
                RadSDatotekom rd = new RadSDatotekom("moj.txt");
                // eksplicitno uništavamo resurse:
                rd.Dispose();

                Console.WriteLine("Brišem 'moj.txt'.");
                File.Delete("moj.txt");

                // drugi način:
                using (RadSDatotekom rd2 = new RadSDatotekom("mojDrugi.txt"))
                {
                    //...
                }
                File.Delete("mojDrugi.txt");

                // treći pokušaj: ostavljamo GC-u da zatvori datoteku
                RadSDatotekom rd3 = new RadSDatotekom("moj.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
