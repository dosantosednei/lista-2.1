using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_exercicio_2
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

            if (valor2 < valor1)
            {
                Console.WriteLine("valor 1 maior ");

            
            } 
            else
            {
                if (valor2 > valor1)
                {
                    Console.WriteLine("valor 2 maior ");
                }
                else
                {
                    if (valor1 == valor2)
                    {
                        Console.WriteLine("VALORES IGUAIS");
                    }
                }
            }
               
                
                    
                    
                       
                    

                
                
                
   

                



                
                   
                    
                     
                    

                
                
               
                
                 


                
            
           
            {
          




            }

        }
    }
}
