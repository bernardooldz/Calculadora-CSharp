using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClassCalculadora objC = new ClassCalculadora();

        private void Limpar()
        {
            txtN1.Clear();
            txtN2.Clear();
            Resultado.Clear();
        }

        private void ArmazenarDados()
        {
            objC.SetN1(double.Parse(txtN1.Text));
            if (txtN2.Text != "")
            {
                objC.SetN2(double.Parse(txtN2.Text));
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            Resultado.Text = objC.Somar().ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            Resultado.Text = objC.Subtrair().ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            Resultado.Text = objC.Multiplicar().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            if (objC.GetN2() != 0)
            {
                Resultado.Text = objC.Dividir().ToString();
            }
            else
            {
                Resultado.Text = "Não existe.";
            }
        }

        private void btnQuantDivisores_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtN1.Text);
            Resultado.Text = objC.QuantDivisores().ToString();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtN1.Text);

            if (objC.Primos() == false)
            {
                Resultado.Text = "O número " + numero + " não é primo";
            }
            else
            {
                Resultado.Text = "O número " + numero + " é primo";
            }
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            Resultado.Text = objC.Fatoracao().ToString();
        }
    }
}
