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
            double alt;
            double area;

            Console.Write("digite a base do retangulo: ");
            baze = double.Parse(Console.ReadLine());

            Console.Write("digite a altura do retangulo: ");
            alt = double.Parse(Console.ReadLine());

            area = (baze *  alt);

            Console.WriteLine("a area do terreno é: {0}", area);

            if (area > 100)
            {
                Console.WriteLine("terreno grande");
            }
            else
            {
                Console.WriteLine("terreno pequeno");
            }



            
               

        }
    }
}
