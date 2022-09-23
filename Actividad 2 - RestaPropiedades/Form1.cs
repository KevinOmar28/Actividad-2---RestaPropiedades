using System.Security.Cryptography;

namespace Actividad_2___RestaPropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Resta RESTA = new Resta();
            RESTA.Num1 = int.Parse(Valor1.Text);
            RESTA.Num2 = int.Parse(Valor2.Text);

            Resultado.Text = RESTA.restar().ToString();
        }
    }
}