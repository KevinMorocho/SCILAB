using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ejercicio1
{
    class ejercicio1
    {
        private int[,] matriz;
        public int obr, pro;
        public void ingresarmatriz()
        {
            string linea;
            Console.Write("Total de obrero: ");
            linea = Console.ReadLine();
            obr = int.Parse(linea);
            Console.Write("Total de proyecto: ");
            linea = Console.ReadLine();
            pro = int.Parse(linea);
            matriz = new int[obr, pro];
            for (int x = 0; x < obr; x++)
            {
                Console.Write("\nObrero: " + (x + 1));
                for (int z = 0; z < pro; z = z + 1)
                {
                    Console.Write("\nProyecto : " + (z + 1) + ": ");
                    linea = Console.ReadLine();
                    matriz[x, z] = int.Parse(linea);
                }
            }
        }
        public void imprirmirmatriz()
        {
            Console.WriteLine("\nMatriz de datos ingresados");
            for (int x = 0; x < obr; x++)
            {
                for (int z = 0; z < pro; z = z + 1)
                {
                    Console.Write(matriz[x, z] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void literal1()
        {
            int suma,x;
            int men = 10;
            int pos=0;
            for ( x = 0; x < obr; x++)
            {
                suma = 0;
                for (int z = 0; z < pro; z = z + 1)
                {
                    suma = suma + matriz[x, z];
                }
                if (suma<men)
                {
                    men = suma;
                    pos = x;    
                }
                suma = 0;
            }
            Console.Write("\nEl obrero que menos herramientas tiene a cargo es el #" + (pos+1));
        }

        public void literal2()
        {            
            float suma = 0;
            float promedio = 0;
            for (int x = 0; x < pro; x++)
            {                
                for (int z = 0; z < obr; z = z + 1)
                {
                    suma = suma + matriz[z,x];                    
                }
                promedio = suma / obr;
                Console.Write("\n\nPromedio de herramientas del proyecto " + (x + 1) + " es " + promedio.ToString("N2"));
                suma = 0;
            }                        
        }

        static void Main(string[] args)
        {
            ejercicio1 obj_suspenso = new ejercicio1();
            obj_suspenso.ingresarmatriz();
            obj_suspenso.imprirmirmatriz();            
            obj_suspenso.literal1();            
            obj_suspenso.literal2();
            Console.ReadKey();
        }
    }
}