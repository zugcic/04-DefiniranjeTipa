using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UgnjezdjenaKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Gnijezdo.UgnjezdjenaZasticena uk = new Gnijezdo.UgnjezdjenaZasticena();
        }
    }

    class Gnijezdo
    {
        protected class UgnjezdjenaZasticena
        {
            public void JavnaMetoda()
            {
            }

            protected void ZasticenaMetoda()
            {
            }
        }

        private class UgnjezdjenaPrivatna : UgnjezdjenaZasticena
        {
        }

        public void GnMetoda1()
        {
            UgnjezdjenaZasticena ukz = new UgnjezdjenaZasticena();
            ukz.JavnaMetoda();

            UgnjezdjenaPrivatna ukp = new UgnjezdjenaPrivatna();
            ukp.JavnaMetoda();
        }
    }

    class DrugoGnijezdo : Gnijezdo
    {
        public void GnMetoda2()
        {
            UgnjezdjenaZasticena ukz = new UgnjezdjenaZasticena();
            ukz.JavnaMetoda();

            UgnjezdjenaPrivatna ukp = new UgnjezdjenaPrivatna();
            ukp.JavnaMetoda();
        }
    }

}
