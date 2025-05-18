using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double sexo;
            double R;

            Console.Write(" digite o peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write(" digite a altura");
            altura = double.Parse(Console.ReadLine());

            Console.Write("digite o sexo 1 para masculino e 2 para feminino");
            sexo = double.Parse(Console.ReadLine());

            R = peso / (altura * altura);

                
              




        }
    }
}
