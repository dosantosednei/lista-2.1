using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baze;
            double altura;
            double area;

            Console.Write("digite a largura do terreno: ");
            baze = double.Parse(Console.ReadLine());

            Console.Write("digite o comprimento do terreno: ");
            altura = double.Parse(Console.ReadLine());

            area = baze * altura;

            Console.WriteLine("A area do terreno é:  {0}", area);

            if (area > 100)
            {
                Console.WriteLine("TERRENO GRANDE");
            }

        }
    }
}
