using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2;
            float num1, num2;
            float resultadofinal;
            aritmetica calcsuma= new aritmetica();
            Console.Write("Digite el valor1 = ");
            cadena1 = Console.ReadLine();
            Console.Write("Digite el valor2 = ");
            cadena2 = Console.ReadLine();
            if (float.TryParse(cadena1, out num1)) 

            {
                if (float.TryParse(cadena2, out num2))
                {
                    resultadofinal = calcsuma.Suma(num1, num2);
                    Console.WriteLine($"el resultado es =  {resultadofinal} ");
                    Console.ReadLine();

                }
            }

                    
            

        }

    }
}
