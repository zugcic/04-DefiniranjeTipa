using System;
using System.IO;

namespace Vsite.CSharp
{
    class RadSDatotekom : IDisposable
    {
        public RadSDatotekom(string imeFajla)
        {
            m_sw = new StreamWriter(imeFajla);
            Console.WriteLine("Konstruktor klase 'RadSDatotekom'");
        }

        // Dispose(bool disposing) može biti pozvana iz Dispose
        // metode; tada je disposing = true. Ako se poziva iz
        // destruktora, tada je disposing = false - jer se ne 
        // smije se dozvoliti oslobađanje upravljanih objekata 
        // koji su pod kontrolom GC-a
        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                if (disposing)
                {
                    // ovdje oslobađa upravljane resurse...
                    m_sw.Close();
                }
                // ovdje oslobađa neupravljane resurse...
                m_disposed = true;
            }
        }

        // Ovaj destruktor će biti pozvan samo ako nije 
        // eksplicitno pozvana Dispose metoda.
        // Izvedeni tipovi ne smiju imati destruktor
        ~RadSDatotekom()
        {
            Dispose(false);
            Console.WriteLine("Pozvan destruktor klase 'RadSDatotekom'");
        }

        // implementacija IDisposable.Dispose
        // nije virtualna jer ju izvedeni tip ne smije pregaziti.
        public void Dispose()
        {
            Dispose(true);
            // Nakon ovog poziva, objekt možemo maknuti iz 
            // liste sustava za skupljanje smeća
            GC.SuppressFinalize(this);
        }

        private StreamWriter m_sw;

        private bool m_disposed = false;
    }
}
