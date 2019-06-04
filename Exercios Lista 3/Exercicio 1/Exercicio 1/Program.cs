using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            
            int fatorado = 0;

            Console.Write("Digite  o valor a se fatorado: ");
            fatorado = int.Parse(Console.ReadLine());
            Console.Write("A fatoração é: " + CalcularFatorial(fatorado));
            Console.ReadKey();
        }
        public static int CalcularFatorial(int fatorado)
        {
            int c;

            for (c = 1; fatorado >= 1; fatorado--)
            {
                c = c * fatorado;
            }
            return c;
        }
    }
}
