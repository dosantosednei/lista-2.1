using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            
            double xis;

            Console.Write("digite a nota p 1: ");
            p1 = double.Parse(Console.ReadLine());

            xis = (15 - p1) / 2;

            Console.WriteLine("o aluno precisa tirar: {0} para ser aprovado", xis);




            

        }
    }
}
