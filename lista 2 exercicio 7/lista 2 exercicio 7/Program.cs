using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;

            Console.Write("digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("digite o terceiro numero: ");
            n3 = double.Parse(Console.ReadLine());

            if (n1 + n2 > n3)
            {
                if (n1 + n3 >  n2)
                {
                    if (n2 + n3 > n1)
                    {
                        if (n1 == n2)
                        {
                            if (n2 == n3)
                            {
                                Console.WriteLine("triangulo equilatero");

                            }
                            else
                            {
                                Console.WriteLine("triangulo isoceles");
                            }
                        }
                        else
                        {
                            if (n1 != n3)
                            {
                                if (n2 != n3)
                                {
                                    Console.WriteLine("triangulo escaleno");
                                }
                                else
                                {
                                    Console.WriteLine("triangulo isoceles");
                                }
                            }
                            else
                            {
                                Console.WriteLine("triangulo isoceles");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("não é um triangulo");
                    }

                }
                else
                {
                    Console.WriteLine("não é um triangulo");
                }

            }
            else
            {
                Console.WriteLine("não é um triangulo");
            }
































                
                
               
                   
            
                    

           
                
                    
                    
                     
                    


                

            
        }
    }
}
