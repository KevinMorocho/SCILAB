using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace empresa
{
    class empresa
    {
        private float[,] matriz;
        private float[] vecAux;
        private int[] vecPos;
        private float[] vecCosto;
        public int caracteristicas, proveedores;
        public void insertarDatos()
        {
            caracteristicas = 5;
            string linea;
            Console.Write("Total de proveedores: ");
            linea = Console.ReadLine();
            proveedores = int.Parse(linea);
            matriz = new float[caracteristicas, proveedores];
            vecAux = new float[proveedores];
            vecCosto = new float[proveedores];
            vecPos = new int[proveedores];
            for (int g = 0; g < caracteristicas; g++)
            {
                for (int k = 0; k < proveedores; k = k + 1)
                {
                    Random ale = new Random();
                    matriz[g, k] = ale.Next(1, 100);
                }
            }
        }
        public void mostrarDatos()
        {
            Console.WriteLine("\nMatriz con datos llenos");
            for (int g = 0; g < caracteristicas; g++)
            {
                for (int k = 0; k < proveedores ; k = k + 1)
                {
                    Console.Write(matriz[g, k] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void proceso1()
        {
            Console.WriteLine("\nItem 1");
            float suma;
            for (int g = 0; g < proveedores; g++)
            {
                suma = 0;
                for (int k = 0; k < caracteristicas; k = k + 1)
                {
                    suma = suma + matriz[k,g];
                }
                float pro = suma / caracteristicas;
                suma = 0;
                vecPos[g] = g;
                vecAux[g] = pro;
                Console.WriteLine("Promedio proveedor: " + (g + 1) + " es " + pro);
            }
            Console.WriteLine();
        }

        public void proceso2()
        {
            Console.Write("\nItem 2 \n");
            int g, k, i,aux1;
            float aux;
            for (g = 0; g < proveedores; g++)
            {
                //Console.WriteLine( vecAux[g]);
            }

            for (i = 0; i < proveedores; ++i)
            {
                for (k = i + 1; k < proveedores; ++k)
                {
                    if (vecAux[i] < vecAux[k])
                    {
                        aux = vecAux[i];
                        vecAux[i] = vecAux[k];
                        vecAux[k] = aux;
                        ////////
                        aux1 = i;
                        vecPos[i] = k;
                        vecPos[k] = aux1;
                    }
                }
            }
            Console.WriteLine("Mejores promedios de proveedores es: ");
            for (g = 0; g < 2; g++)
            {
                Console.WriteLine("Proveedor "+(g+1)+" con "+vecAux[g]);
            }

        }

        public void proceso3()
        {
            Console.Write("\nItem 3");
            int g, k,i;
            float aux;
            for (g = 3; g < 4; g++)
            {
                for (k = 0; k < proveedores; k = k + 1)
                {
                    vecCosto[k] = matriz[g, k];
                }
            }

            for (i = 0; i < proveedores; ++i)
            {
                for (k = i + 1; k < proveedores; ++k)
                {
                    if (vecCosto[i] > vecCosto[k])
                    {
                        aux = vecCosto[i];
                        vecCosto[i] = vecCosto[k];
                        vecCosto[k] = aux;
                    }
                }
            }

            for (g = 3; g < 4; g++)
            {
                for (k = 0; k < proveedores; k = k + 1)
                {
                    matriz[g, k] = vecCosto[k];
                }
            }
            Console.Write("\nDatos ordenado por costo\n");
            for (g = 0; g < caracteristicas; g++)
            {
                for (k = 0; k < proveedores; k = k + 1)
                {
                    Console.Write(matriz[g, k] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            empresa obj = new empresa();
            obj.insertarDatos();
            obj.mostrarDatos();
            obj.proceso1();
            obj.proceso2();
            obj.proceso3();
            Console.ReadKey();
        }
    }
}