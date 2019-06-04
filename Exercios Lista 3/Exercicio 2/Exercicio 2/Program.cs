using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.Write("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A diferença entre os valores é de " + CalcularDiferenca(valor1, valor2));
            Console.ReadKey();
        }
        public static double CalcularDiferenca(double valor1,double valor2)
        {
            double aux = 0;
            double resultado = 0;

            if (valor1 < valor2)
            {
                aux = valor1;
                valor1 = valor2;
                valor2 = aux;
            }
            resultado = valor1 - valor2;
            return resultado;
        }
    }
}
