using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraViajes
{
    public partial class CalcularViajes : Form
    {
        public CalcularViajes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = double.Parse(origen.Text);
            double d2 = double.Parse(destino.Text);
            double velocidadConstante = double.Parse(velocidad.Text);

            double resultado = (d2 - d1) / velocidadConstante;

            MessageBox.Show(resultado.ToString());

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void velocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void destino_TextChanged(object sender, EventArgs e)
        {

        }

        private void origen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
