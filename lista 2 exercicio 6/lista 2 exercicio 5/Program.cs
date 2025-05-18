using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double R;

            Console.Write("digite o peso : ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            R = peso / (altura * altura);

            Console.WriteLine("A relação é {0}", R);

            if (R < 20)
            {
                Console.WriteLine("abaixo do peso");

            }
            else
            {


                if (20 <= R)
                {


                    if (R < 25)
                    {
                        Console.WriteLine("peso ideal");

                    }
                    else
                    {
                        Console.WriteLine("acima do peso");
                    }

                }





            }
        }
    }
}
