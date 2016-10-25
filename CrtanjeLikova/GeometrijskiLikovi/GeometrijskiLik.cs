using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrtanjeLikova.GeometrijskiLikovi
{
    abstract class GeometrijskiLik
    {
        public abstract void Nacrtaj(System.Drawing.Graphics g);

        public abstract void Pomakni(float deltaX, float deltaY);

        public abstract void Uvećaj(float faktor);
    }
}
