namespace WinFormsApp1
{
    public partial class ConsumoCombustible : Form
    {
        public ConsumoCombustible()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {




        }

        private void calculo_Click(object sender, EventArgs e)
        {
            double Galones = double.Parse(galones.Text);
            double Kilometros = double.Parse(kilometros.Text);
            double resultado = Galones / Kilometros;

            result.Text = resultado.ToString();
        }
    }
}
