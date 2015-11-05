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
                {
                    Console.WriteLine("Stvaram 'RadSDatotekom'");
                    RadSDatotekom rd = new RadSDatotekom("moj.txt");

                    Console.WriteLine("Brišem 'moj.txt'");
                }
                File.Delete("moj.txt");
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
