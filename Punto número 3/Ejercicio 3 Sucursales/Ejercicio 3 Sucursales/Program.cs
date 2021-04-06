using System;

namespace Ejercicio_3_Sucursales
{
    class Program
    {
        static void Main(string[] args)
        {
            int empleados=0, conp=0, conmaxp=0;
            double ganancia, total=0;
            string sucursaln;
            string[] sucursales;
            sucursales = new string[5];
            Double[] ganancias;
            ganancias = new double[5];
            int[] empleadosc;
            empleadosc = new int[5];
            
            for(int i=0;i<5;i=i+1)
            {
                Console.WriteLine("Ingrese el nombre de la sucursal "+ (i + 1));
                sucursaln = Console.ReadLine();
                sucursales[i] = sucursaln;
                for (int g=0;g<1;g=g+1)
                {
                    Console.WriteLine("Ingrese la ganancia de la sucursal "+(i + 1));
                    ganancia = Double.Parse(Console.ReadLine());
                    if (ganancia >= 1000 && ganancia<=50000)
                    {
                        ganancias[i] = ganancia;
                    }
                    else
                    {
                        Console.WriteLine("Valor ingresado no válido, intente de nuevo.");
                        g = g - 1;
                    }
                }
                for (int e=0;e<1;e=e+1)
                {
                    Console.WriteLine("Ingrese la cantidad de empleados de la sucursal " + (i + 1));
                    empleados = int.Parse(Console.ReadLine());
                    if (empleados >= 10 )
                    {
                        empleadosc[i] = empleados;
                    }
                    if (empleados<10)
                    {
                        Console.WriteLine("Valor ingresado no válido, intente de nuevo.");
                        e = e - 1;
                    }
                    
                    
                }
                
                Console.Clear();

            }
            for (int ii=0;ii<5;ii=ii+1)
            {
                
                if (ganancias[ii]>30000)
                {
                    Console.WriteLine("Nombre: " + sucursales[ii] + " (Bien hecho)");
                    Console.WriteLine("Ganancias: $" + ganancias[ii]);
                    Console.WriteLine("Empleados: " + empleadosc[ii]);
                    Console.WriteLine("*******************************************************");
                }
                else
                {
                    Console.WriteLine("Nombre: " + sucursales[ii] + " (Regular) ");
                    Console.WriteLine("Ganancias: $" + ganancias[ii]);
                    Console.WriteLine("Empleados: " + empleadosc[ii]);
                    Console.WriteLine("*******************************************************");
                }
                if(ganancias[ii]>=1000 && ganancias[ii]<=25000)
                {
                    conp = conp + 1;
                }
                if (ganancias[ii]>30000)
                {
                    conmaxp = conmaxp + 1;
                }
                
            }
            for (int iii = 0; iii < 5; iii = iii + 1)
            {
                total = ganancias[iii] + total;
            }
            Console.WriteLine("Sucursales con ganancias entre $1000 y $25000: " + conp + " sucursales." + "\n");
            Console.WriteLine("Sucursales con ganancias mayores a $30000: " + conmaxp + " sucursales." + "\n");
            Console.WriteLine("El total de ganancias con las 5 sucursales es de: $" + total);

            Console.ReadKey();
        }
    }
}
