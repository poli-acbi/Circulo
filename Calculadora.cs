using System;
using System.Collections.Generic;
using System.Text;

namespace calculoCircunferencia
{
    public class Calculadora

    {
        //valor de Pi
        public double Pi = 3.14;

        //calculo da circunferencia
        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        //calculo do volume
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
