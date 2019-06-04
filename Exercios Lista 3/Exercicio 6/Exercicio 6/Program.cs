using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int coordenadaX;
            int coordenadaY;
            int quadrante;

            Console.Write("Digite o valor da coordenada X: ");
            coordenadaX = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da coordenada Y: ");
            coordenadaY = int.Parse(Console.ReadLine());
            quadrante = LocalizarQuadrante(coordenadaX, coordenadaY);
            Console.Write("Quadrante: " + quadrante);

            Console.ReadKey();
        }
        static int LocalizarQuadrante(int coordenadaX, int coordenadaY)
        {
            int quadrante = 0;
            if (coordenadaX > 0 && coordenadaY > 0)
            {
                quadrante = 1;
            }
            if (coordenadaX < 0 && coordenadaY > 0)
            {
                quadrante = 2;
            }
            if (coordenadaX < 0 && coordenadaY < 0)
            {
                quadrante = 3;
            }
            if (coordenadaX > 0 && coordenadaY < 0)
            {
                quadrante = 4;
            }
            return quadrante;
        }
    }
}
