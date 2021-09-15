using System;
using System.Globalization;

namespace calculoCircunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            //pede o valor do raio
            Console.WriteLine("Insira o valor do raio");
            //armazena o valor do raio
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //chama os metodos para o calculo da circunferência e volume
            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            //exibe os resultados
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
