using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAPP
{
   public class Calculadora
    {
       
        public double Somar(double valor01, double valor02)
        {
            return valor01 + valor02;
        }

        public double Subtrair(double valor01, double valor02)
        {
            return valor01 - valor02;
        }

        public double Dividir(double valor01, double valor02)
        {
            return valor01 / valor02;
        }

        public double Multiplicar(double valor01, double valor02)
        {
            return valor01 * valor02;
        }
    }

}
