using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexoUsuario;
            double alturaUsuario;

            Console.Write("Digite o seu sexo: ");
            sexoUsuario = (Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            alturaUsuario = double.Parse(Console.ReadLine());

            if (sexoUsuario == "feminino")
            {
                Console.WriteLine("O peso ideal é " + calcularPesoFeminino(alturaUsuario, sexoUsuario));
            }
            else if (sexoUsuario == "masculino")
            {
                Console.WriteLine("O peso ideal é " + calcularPesoMasculino(alturaUsuario, sexoUsuario));
            }
            Console.ReadKey();
        }
            public static double calcularPesoFeminino(double alturaUsuario, string sexoUsuario)
                {
                    double contaAlturaFeminino;
                    contaAlturaFeminino = (62.1 * alturaUsuario) - 44.7;
                    return contaAlturaFeminino;
                }

        public static double calcularPesoMasculino(double alturaUsuario, string sexoUsuario)
                {
                    double contaAlturaMasculino;
                    contaAlturaMasculino = (72.7 * alturaUsuario) - 58;
                    return contaAlturaMasculino;
                }
    }
}
