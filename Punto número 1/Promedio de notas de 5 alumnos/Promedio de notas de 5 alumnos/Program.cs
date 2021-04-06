using System;

namespace Promedio_de_notas_de_5_alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombremayo = null, nombremeno = null;
            Double nota = 0, mayor = 0, menor = 10;
            string[] nombres;
            nombres = new string[5];
            string nombre;
            Double[] promedios;
            promedios = new double[5];
            Double[] notas;
            notas = new double[5];
            for (int i=0;i<=4;i=i+1)
            {
                Console.WriteLine("Ingrese el nombre del alumno (" + (i+1) + ")");
                nombre = Console.ReadLine();
                nombres[i] = nombre;
                
                for(int j=0;j<=4;j=j+1)
                {
                    
                    Console.WriteLine("Ingrese la nota número " + (j+1));
                    
                    nota = Double.Parse(Console.ReadLine());
                    
                    if (nota<0 || nota>10)
                    {
                        Console.WriteLine("Usted a ingresado un valor erroneo, vuelva a intentarlo.");
                        
                        j = j - 1;
                    }
                    else
                    {
                        notas[i] = notas[i] + nota;
                    }
                    

                    
                    
                }
                Console.Clear();
                
                
            }
            for (int ii = 0; ii <= 4; ii = ii + 1)
            {
                promedios[ii] = notas[ii] / 5;
                if (promedios[ii] < 4)
                {
                    Console.WriteLine("Alumno: " + nombres[ii] + " (Reprobado)");
                    Console.WriteLine("Promedio: " + promedios[ii]);
                }
                if (promedios[ii] >= 4 && promedios[ii] < 7)
                {
                    Console.WriteLine("Alumno: " + nombres[ii] + " (Regular)");
                    Console.WriteLine("Promedio: " + promedios[ii]);
                }
                if (promedios[ii] >= 7)
                {
                    Console.WriteLine("Alumno: " + nombres[ii] + " (Aprobado)");
                    Console.WriteLine("Promedio: " + promedios[ii]);
                }
                if (mayor<promedios[ii])
                {
                    mayor = promedios[ii];
                    nombremayo = nombres[ii];
                }
                
                if (menor > promedios[ii])
                {
                    menor = promedios[ii];
                    nombremeno = nombres[ii];
                }
                
            }
            Console.WriteLine("\t");
            Console.WriteLine("El mayor promedio es: " + mayor+" de "+nombremayo);
            Console.WriteLine("\t");
            Console.WriteLine("El menor promedio es: " + menor+" de "+nombremeno);
            
        }
    }
}
