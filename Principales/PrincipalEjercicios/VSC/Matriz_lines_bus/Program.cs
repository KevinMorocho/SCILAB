using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ejercicio1
{
    class ejercicio1
    {
        private int[,] matriz;
        private int[] vec;
        public int l, b, cont;
        public void ingresarmatriz()
        {
            string linea;
            Console.Write("Total de linea : ");
            linea = Console.ReadLine();
            l = int.Parse(linea);
            Console.Write("Total de buses: ");
            linea = Console.ReadLine();
            b = int.Parse(linea);
            matriz = new int[l, b];
            for (int x = 0; x < l; x++)
            {
                Console.Write("\nLinea : " + (x + 1));
                for (int z = 0; z < b; z = z + 1)
                {
                    Console.Write("\nBus : " + (z + 1) + ": ");
                    linea = Console.ReadLine();
                    matriz[x, z] = int.Parse(linea);
                }
            }
        }
        public void imprirmirmatriz()
        {
            Console.WriteLine("\nMatriz de datos ingresados");
            for (int x = 0; x < l; x++)
            {
                for (int z = 0; z < b; z = z + 1)
                {
                    Console.Write(matriz[x, z] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void lita()
        {
            int suma, x;
            suma = 0;
            for (x = 3; x < 4; x++)
            {                
                for (int z = 0; z < b; z = z + 1)
                {
                    suma = suma + matriz[x, z];
                }                
            }
            Console.Write("\nRecaudacion total de la carta linea es: " + suma);
        }

        public void litb()
        {            
            float sumat = 0;
            float promedio;
            int x;
            for (x = 0; x < b; x++)
            {
                for (int z = 0; z < l; z = z + 1)
                {
                    sumat = sumat + matriz[z, x];
                }
                promedio = sumat / b;
                Console.Write("\nPromedio de la recaudacion del bus #" +(x+1)+" es "+ promedio+" planillas");
                sumat = 0;
            }           
        }

        public void litc()
        {
            int i, j,x,suma;
            int aux;

            vec = new int[100];
            cont = 0;
            suma = 0;
            for (x = 0; x < l; x++)
            {                
                    vec[cont]= matriz[x,5];
                    cont = cont + 1;             
            }

            for (i = 0; i < cont; ++i)
            {
                for (j = i + 1; j < cont; ++j)
                {
                    if (vec[i] > vec[j])
                    {
                        aux = vec[i];
                        vec[i] = vec[j];
                        vec[j] = aux;
                    }
                }
            }
            Console.WriteLine("\nRecaudacion de sexto bus ordenada \n");
            for (i = 0; i < cont; ++i)
            {
                Console.WriteLine(vec[i]);
            }
        }

        static void Main(string[] args)
        {
            ejercicio1 b_recorrido = new ejercicio1();
            b_recorrido.ingresarmatriz();
            b_recorrido.imprirmirmatriz();
            b_recorrido.lita();
            b_recorrido.litb();
            b_recorrido.litc();
            Console.ReadKey();
        }
    }
}