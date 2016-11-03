﻿using System;
using System.IO;

namespace Vsite.CSharp
{
    public class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            StreamWriter sw = new StreamWriter(imeDatoteke);   //otvara datoteku pod nekim imenom
            sw.WriteLine("Ovo je moj upis");
            //  Pokrenuti program i pogledati ispis.

            //  Dodati poziv metode StreamWriter.Dispose (ili StreamWriter.Close) te ponovno pokrenuti program.
            //sw.Dispose();//kada je pozovemo zatvaramo datoteku i oslobađmo memoriju
            //  Preraditi kod metode tako da se umjesto metode Dispose koristi blok using
            sw.Close(); //svaki puta kad želimo osloboditi resurse kosristimo dispose metodu
        }

        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }


        static void Main(string[] args)
        {
            try
            {
                StvaranjeIPisanjeUDatoteku("moj.txt");
                Console.WriteLine("Brišem datoteku");
                BrisanjeDatoteke("moj.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
