using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("Escolha a operacao desejada: ");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtracao");
            Console.WriteLine("3-Divisao");
            Console.WriteLine("4-Multiplicacao");
            Console.WriteLine("5-Resto da divisao");
            Console.WriteLine("6-Dobro");
            Console.WriteLine("7-Quadrado");
            Console.WriteLine("8-Cubo");
            Console.WriteLine("9-Raiz Quadrada");
            Console.WriteLine("0-Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    operacaoSoma();
                    break;
                case 2:
                    operacaoSubtracao();
                    break;
                case 3:
                    operacaoDivisao();
                    break;
                case 4:
                    operacaoMultiplicacao();
                    break;
                case 5:
                    operacaoRestoDivisao();
                    break;
                case 6:
                    operacaoDobro();
                    break;
                case 7:
                    operacaoQuadrado();
                    break;
                case 8:
                    operacaoCubo();
                    break;
                case 9:
                    operacaoRaizQuadrada();
                    break;

            }
        }

        static void operacaoSoma()
        {

            int numero1 = 0;
            int numero2 = 0;

            Console.Clear();
            Console.WriteLine("Soma");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 + numero2));
            Console.ReadKey();
        }

        static void operacaoSubtracao()
        {

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Subtraçao");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 - numero2));
            Console.ReadKey();

        }

        static void operacaoDivisao()
        {

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Divisao ");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 / numero2));
            Console.ReadKey();

        }
        static void operacaoMultiplicacao()
        {

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Multiplicaçao!");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 * numero2));
            Console.ReadKey();

        }

        static void operacaoRestoDivisao()
        {

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Resto da Divisão !!");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 % numero2));
            Console.ReadKey();


        }

        static void operacaoDobro()
        {

            int numero1 = 0;


            Console.WriteLine("Dobro!!");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 + numero1));
            Console.ReadKey();


        }

        static void operacaoQuadrado()
        {

            int numero1 = 0;


            Console.WriteLine("Quadrado");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 * numero1));
            Console.ReadKey();


        }

        static void operacaoCubo()
        {

            int numero1 = 0;


            Console.WriteLine("Ao Cubo");
            Console.WriteLine("Digite o primeiro valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + (numero1 * 3));
            Console.ReadKey();


        }

        static void operacaoRaizQuadrada()
        {

            int numero1 = 0;


            Console.WriteLine("Raiz Quadrada ");
            Console.WriteLine("Digite o valor: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é = " + Math.Sqrt(numero1));
            Console.ReadKey();
        }
    }
}
