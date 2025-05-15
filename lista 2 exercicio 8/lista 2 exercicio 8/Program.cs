using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;

            Console.Write("digite o valor A: ");
            A = double.Parse(Console.ReadLine());


            Console.Write("digite o valor B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("digite o valor C: ");
            C = double.Parse(Console.ReadLine());

            if (A * A == B * B + C * C)
            {
                Console.WriteLine("é um triangulo retangulo");
            }
            else
            {
                if (B * B == A * A + C * C)
                {
                    Console.WriteLine("é um triangulo retangulo");
                }
                else
                {
                    if (C * C == A * A + B * B)
                    {
                        Console.WriteLine("é um triangulo retangulo");
                    }
                    else
                    {
                        Console.WriteLine("não é um triangulo retangulo");
                    }
                }
            }


            



        }



        
    }
}
