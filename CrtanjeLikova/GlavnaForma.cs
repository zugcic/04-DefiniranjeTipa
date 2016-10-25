using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrtanjeLikova
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void ButtonUlijevo_Click(object sender, EventArgs e)
        {
            panelZaCrtanje.PomakniLikove(-10, 0);
        }

        private void ButtonPremaGore_Click(object sender, EventArgs e)
        {
            panelZaCrtanje.PomakniLikove(0, -10);
        }

        private void ButtonPremaDolje_Click(object sender, EventArgs e)
        {
            panelZaCrtanje.PomakniLikove(0, 10);
        }

        private void ButtonUdesno_Click(object sender, EventArgs e)
        {
            panelZaCrtanje.PomakniLikove(10, 0);
        }

        private void ButtonUvećaj_Click(object sender, EventArgs e)
        {
            panelZaCrtanje.UvećajLikove(2.0f);
        }

        private void ButtonUmanji_Click(object sender, EventArgs e)
        {
            panelZaCrtanje.UvećajLikove(0.5f);
        }
    }
}
