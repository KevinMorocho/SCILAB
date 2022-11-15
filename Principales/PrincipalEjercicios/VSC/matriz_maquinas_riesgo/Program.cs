using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace principal
{
    class principal
    {
        private float[,] matriz;        
        private float[] tabla;
        public int clasi, maq;
        public void llenar()
        {
            string linea;
            clasi = 5;
            Console.Write("Total de riesgos en las maquinas: ");
            linea = Console.ReadLine();
            maq = int.Parse(linea); 
            tabla = new float[maq];
            matriz = new float[maq, clasi];
            for (int a = 0; a < maq; a++)
            {
                for (int j = 0; j < clasi; j = j + 1)
                {
                    Random ale = new Random();
                    matriz[a, j] = ale.Next(1, 10);
                }
            }
        }
        public void imprimir()
        {
            Console.WriteLine("\nMatriz ingresada");
            for (int a = 0; a < maq; a++)
            {
                for (int j = 0; j < clasi; j = j + 1)
                {
                    Console.Write(matriz[a, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void lit_A()
        {
            Console.Write("\nLiteral A");            
            float suma = 0;
            for (int a = 0; a < clasi; a++)
            {
                for (int j = 0; j < maq; j = j + 1)
                {
                    suma = suma + matriz[j, a];
                }
                float pro = suma / 4;
                Console.Write("\nPromedio Calificacion "+ (a + 1) + " es: " + (pro));
                suma = 0;
            }
        }

        public void lit_B()
        {
            Console.Write("\n\nLiteral B");
            float may = matriz[1, 1];
            float men = matriz[1, 1];
            int posmay = 0;
            int posmen = 0;            
            for (int a = 0; a < maq; a++)
            {
                for (int j = 0; j < clasi; j = j + 1)
                {                    
                    if (matriz[a, j] > may)
                    {
                        may = matriz[a, j];
                        posmay = j;
                    }
                    if (matriz[a, j]< men)
                    {
                        men = matriz[a, j];
                        posmen = j;
                    }
                }               
            }
            Console.Write("\nLa mayor clasificacion es la #: " + (posmay + 1));
            Console.Write("\nLa menor clasificacion es la #: " + (posmen + 1));
            Console.WriteLine();
        }

        public void lit_C()
        {
            Console.Write("\nLiteral C");
            int a, i, j;
            float aux;
            for ( a = 1; a < 2; a++)
            {
                for ( j = 0; j < clasi; j = j + 1)
                {                    
                    tabla[j]= matriz[a,j];
                }               
            }           
            //ordenar
            for (i = 0; i < clasi; ++i)
            {
                for (j = i + 1; j < clasi; ++j)
                {
                    if (tabla[i] > tabla[j])
                    {
                        aux = tabla[i];
                        tabla[i] = tabla[j];
                        tabla[j] = aux;
                    }
                }
            }
            
            for (a = 1; a < 2; a++)
            {
                for (j = 0; j < clasi; j = j + 1)
                {                   
                     matriz[a, j]= tabla[j];
                }
            }

            Console.WriteLine("\nMatriz ordenada (riesgos de ruptura de maq. \n");
            for ( a = 0; a < maq; a++)
            {
                for (j = 0; j < clasi; j = j + 1)
                {
                    Console.Write(matriz[a, j] + "  ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            principal obj = new principal();
            obj.llenar();
            obj.imprimir();
            obj.lit_A();
            obj.lit_B();
            obj.lit_C();
            Console.ReadKey();
        }
    }
}