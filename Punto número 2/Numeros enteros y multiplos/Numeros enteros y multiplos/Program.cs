using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_enteros_y_multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numero, mulcinc = 0, multres = 0, duomul = 0;
            
            Console.WriteLine("Digite 10 números enteros entre el 0 y el 500.");
            
            for(int i=0;i<=9;i=i+1)
            {
                Console.WriteLine("Digite su numero (" + (i + 1) + ")...");
                numero = Double.Parse(Console.ReadLine());
                
                if (Math.Round(numero) >= 0 && Math.Round(numero) <= 500)
                {
                    if (Math.Round(numero) % 3 == 0 )
                    {
                        multres = multres + 1;
                    }
                    if (Math.Round(numero) % 5 == 0 )
                    {
                        mulcinc = mulcinc + 1;
                    }
                    if (Math.Round(numero) % 3 == 0 && numero % 5 == 0)
                    {
                        duomul = duomul + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Numero ingresado no válido, vuelva a intentarlo.");
                    i = i - 1;
                }

            }
           
            Console.WriteLine("La cantidad de multiplos de 5 es de " + mulcinc);
            Console.WriteLine("La cantidad de multiplos de 3 es de " + multres);
            Console.WriteLine("La cantidad de multiplos de 3 y 5 es " + duomul);
            Console.ReadKey();

            
            
        }
    }
}
