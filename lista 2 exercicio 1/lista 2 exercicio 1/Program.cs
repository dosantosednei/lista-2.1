using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.Write("digite o primeiro valor: "); 
                
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            if (valor1 > valor2)
            { 
                Console.WriteLine("valor1 maior");
            }
            else
            {
                Console.WriteLine("valor2 maior");
            }



           
          


            




        }
    }
}
