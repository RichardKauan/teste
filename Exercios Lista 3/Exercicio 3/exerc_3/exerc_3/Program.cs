using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double primeiroLadoTriangulo;
            double segundoLadoTriangulo;
            double terceiroLadoTriangulo; 

            Console.Write("Digite o valor do primeiro lado do triângulo: ");
            primeiroLadoTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado do triângulo: ");
            segundoLadoTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado do triângulo: ");
            terceiroLadoTriangulo = double.Parse(Console.ReadLine());

            if ((primeiroLadoTriangulo < (segundoLadoTriangulo + terceiroLadoTriangulo)) && (segundoLadoTriangulo < (primeiroLadoTriangulo + terceiroLadoTriangulo)) && (terceiroLadoTriangulo < (primeiroLadoTriangulo + segundoLadoTriangulo))) 
            {
                if (verificarEquilatero(primeiroLadoTriangulo, segundoLadoTriangulo, terceiroLadoTriangulo)) 
                {
                    Console.Write("\nÉ equilátero!");
                }
                else if (verificarIsosceles(primeiroLadoTriangulo, segundoLadoTriangulo, terceiroLadoTriangulo))
                {
                    Console.Write("\nÉ isósceles!"); 
                }
                else if (verificarEscaleno(primeiroLadoTriangulo, segundoLadoTriangulo, terceiroLadoTriangulo))
                {
                    Console.Write("\nÉ escaleno!");
                }
            }
            else
            {
                Console.Write("\nErrados!");
            }

            Console.ReadKey();
        }
        static bool verificarEquilatero(double primeiroLadoTriangulo, double segundoLadoTriangulo, double terceiroLadoTriangulo)
        {
            if ((primeiroLadoTriangulo == segundoLadoTriangulo) && (primeiroLadoTriangulo == terceiroLadoTriangulo) && (segundoLadoTriangulo == terceiroLadoTriangulo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool verificarIsosceles(double primeiroLadoTriangulo, double segundoLadoTriangulo, double terceiroLadoTriangulo)
        {
            if ((primeiroLadoTriangulo == segundoLadoTriangulo) || (segundoLadoTriangulo == terceiroLadoTriangulo) || (terceiroLadoTriangulo == primeiroLadoTriangulo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool verificarEscaleno(double primeiroLadoTriangulo, double segundoLadoTriangulo, double terceiroLadoTriangulo)
        {
            if ((primeiroLadoTriangulo != segundoLadoTriangulo) && (segundoLadoTriangulo != terceiroLadoTriangulo) && (terceiroLadoTriangulo != primeiroLadoTriangulo))
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
