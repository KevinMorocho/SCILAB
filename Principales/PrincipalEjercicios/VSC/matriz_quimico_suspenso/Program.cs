using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace gases
{
    class gases
    {
        private float[,] matriz;
        private float[] tabla;        
        public int propiedad, producto;
        public void insertarDatos()
        {            
            propiedad = 4;         
            producto = 7;
            matriz = new float[producto, propiedad];
            tabla = new float[producto];
            for (int a = 0; a < producto; a++)
            {
                for (int j = 0; j < propiedad; j = j + 1)
                {
                    Random ale = new Random();
                    matriz[a, j] = ale.Next(1, 9);
                }
            }
        }
        public void mostrarDatos()
        {
            Console.WriteLine("\nMatriz producto - propiedad");
            for (int a = 0; a < producto; a++)
            {
                for (int j = 0; j < propiedad; j = j + 1)
                {
                    Console.Write(matriz[a, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void lit_A()
        {
            Console.WriteLine("\nLiteral A");
            float suma;
            suma = 0;
            for (int a = 0; a < propiedad; a++)
            {
                for (int j = 0; j < producto; j = j + 1)
                {
                    suma = suma + matriz[j, a];
                }
                float pro = suma / producto;
                suma = 0;
                Console.WriteLine("Promedio Propiedad: "+(a+1)+" es "+pro);
            }
            Console.WriteLine();
        }

        public void lit_B()
        {
            Console.WriteLine("\n\nLiteral B");
            int a, j,i;
            float aux;
            for (a = 0; a < producto; a++)
            {
                for (j = 1; j < 2; j = j + 1)
                {
                    tabla[a] = matriz[a, j];
                   // Console.Write(tabla[a] + "  ");
                }
            }
            //ordenar
            for (i = 0; i < producto; ++i)
            {
                for (j = i + 1; j < producto; ++j)
                {
                    if (tabla[i] > tabla[j])
                    {
                        aux = tabla[i];
                        tabla[i] = tabla[j];
                        tabla[j] = aux;
                    }
                }
            }
            for (a = 0; a < producto; a++)
            {
                for (j = 1; j < 2; j = j + 1)
                {
                   matriz[a, j]=tabla[a];
                }
            }
            Console.WriteLine("\nDatos ordenados constantes r");
            for ( a = 0; a < producto; a++)
            {
                for ( j = 0; j < propiedad; j = j + 1)
                {
                    Console.Write(matriz[a, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void lit_C()
        {
            Console.WriteLine("\n\nLiteral c");
            float may = matriz[5, 0];
            int pos = 0;
            for (int a = 5; a < 6; a++)
            {
                for (int j = 0; j < propiedad; j = j + 1)
                {
                    if (matriz[a, j] < may)
                    {
                        may = matriz[a, j];
                        pos = j;
                    }
                }
            }
            Console.Write("\nLa propiedad con menor valor en nitrogeno es la propiedad #: " + (pos + 1));
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            gases obj = new gases();
            obj.insertarDatos();
            obj.mostrarDatos();
            obj.lit_A();
            obj.lit_B();
            obj.lit_C();
            Console.ReadKey();
        }
    }
}