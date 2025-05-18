using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;

            Console.Write("digite o valor 1: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("digite o valor 2: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.Write("digite o valor 3 ");
            valor3 = double.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {


                if (valor1 > valor3)
                {
                    Console.WriteLine("valor 1 maior");
                }
            }
            else
            {
                if (valor2 > valor3)
                {
                    Console.WriteLine("valor 2 maior");
                }
                else
                {
                    if (valor3 > valor1)
                    {
                        Console.WriteLine("valor 3 maior");
                    }
                }
            }

        }

    }


}
            
    

