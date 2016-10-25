using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrtanjeLikova.GeometrijskiLikovi
{
    class Elipsa : GeometrijskiLik
    {
        public Elipsa(float x, float y, float širina, float visina)
        {
            this.x = x;
            this.y = y;
            this.širina = širina;
            this.visina = visina;
        }

        public override void Nacrtaj(Graphics g)
        {
            using (Pen pero = new Pen(Color.Red))
            {
                g.DrawEllipse(pero, x, y, širina, visina);
            }
        }

        public override void Pomakni(float deltaX, float deltaY)
        {
            x += deltaX;
            y += deltaY;
        }

        public override void Uvećaj(float faktor)
        {
            širina *= faktor;
            visina *= faktor;
        }

        private float x;
        private float y;
        private float širina;
        private float visina;
    }
}
