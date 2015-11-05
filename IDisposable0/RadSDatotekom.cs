using System;
using System.IO;

namespace Vsite.CSharp
{
    class RadSDatotekom
    {
        public RadSDatotekom(string imeFajla)
        {
            m_sw = new StreamWriter(imeFajla);
            Console.WriteLine("Konstruktor klase 'RadSDatotekom'");
        }

        // destruktor zatvara datoteku (tok)
        ~RadSDatotekom()
        {
            m_sw.Close();
            Console.WriteLine("Pozvan destruktor klase 'RadSDatotekom'");
        }

        private StreamWriter m_sw;
    }
}
