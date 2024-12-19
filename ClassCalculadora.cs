using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class ClassCalculadora
    {
        private double n1;
        private double n2;

        public void SetN1(double numero)
        {
            this.n1 = numero;
        }

        public double GetN1()
        {
            return this.n1;
        }

        public void SetN2(double numero)
        {
            this.n2 = numero;
        }

        public double GetN2()
        {
            return this.n2;
        }



        public double Somar()
        {
            return (this.n1 + this.n2);
        }

        public double Subtrair()
        {
            return (this.n1 - this.n2);
        }

        public double Multiplicar()
        {
            return (this.n1 * this.n2);
        }

        public double Dividir()
        {
            return (this.n1 / this.n2);
        }


        public double QuantDivisores()
        {
            int i, contR = 0;

            for (i = 1; i <= this.n1; i++)
            {
                if (this.n1 % i == 0)
                {
                    contR++;
                }
            }

            return contR;
        }

        public double Fatoracao()
        {
            double i, resultado = 1;

            for (i = this.n1; i >= 1; i--)
            {
                resultado *= i;
            }

            return resultado;
        }

        public bool Primos()
        {
            if (QuantDivisores() == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
