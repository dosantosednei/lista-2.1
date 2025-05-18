using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double media;

            Console.Write("digite a nota p1: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("digite a nota p2: ");
            p2 = double.Parse(Console.ReadLine());

            media = (p1 + 2 * p2) / 3;

            if (media >= 5)
            {
                Console.WriteLine("aprovado");
            }
            else
            {
                Console.WriteLine("reprovado");
            }

        }
    }
}
