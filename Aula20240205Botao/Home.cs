using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240205Botao
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            cont = int.Parse(lblContador.Text);
            cont++;

            lblContador.Text = cont.ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            cont = int.Parse(lblContador.Text);
            cont--;

            lblContador.Text = cont.ToString();
        }

        private void bg3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Plum;
        }

        private void bg2_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
        }

        private void bg1_Click(object sender, EventArgs e)
        {
            BackColor = Color.IndianRed;
        }
    }
}
