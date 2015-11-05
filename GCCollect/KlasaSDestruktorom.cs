using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class KlasaSDestruktorom
    {
        public KlasaSDestruktorom()
        {
            m_redniBroj = m_brojač++;
            Console.WriteLine("Konstruktor klase 'KlasaSDestruktorom' br. {0}", m_redniBroj);
            Debug.WriteLine(string.Format("Konstruktor klase 'KlasaSDestruktorom' br. {0}", m_redniBroj));
        }

        ~KlasaSDestruktorom()
        {
            Console.WriteLine("Pozvan destruktor klase 'KlasaSDestruktorom' br. {0}", m_redniBroj);
            Debug.WriteLine(string.Format("Pozvan destruktor klase 'KlasaSDestruktorom' br. {0}", m_redniBroj));
        }

        private readonly int m_redniBroj;

        private static int m_brojač = 0;

    }
}
