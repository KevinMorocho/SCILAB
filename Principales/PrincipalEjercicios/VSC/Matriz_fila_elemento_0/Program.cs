using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace console1
{
    class console1
    {
        private float[,] matriz;
        public int fila, col, aux1;
        public int aux2, aux3;
        public void insertar()
        {            
            string linea;
            Console.Write("Elementos de filas: ");
            linea = Console.ReadLine();
            fila = int.Parse(linea);
            Console.Write("Elementos de columnas: ");
            linea = Console.ReadLine();
            col = int.Parse(linea);
            matriz = new float[fila, col];
            for (int a = 0; a < fila; a++)
            {
                Console.Write("\nFila : "+ a );
                for (int b = 0; b < col; b = b + 1)
                {
                    Console.Write("\nColumna : " + b+": ");
                    linea = Console.ReadLine();
                    matriz[a, b] = int.Parse(linea);                    
                }
            }
        }
        public void mostrar()
        {         
            for (int a = 0; a < fila; a++)
            {
                for (int b = 0; b < col; b = b + 1)
                {
                    Console.Write(matriz[a, b] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void cumple()
        {
            int a = 0;
            while(a < fila)
            {
                aux1 = 0;
                aux2 = 0;
                aux3 = 0;
                for (int b = 0; b < col; b++)
                {
                    if (matriz[a, b] == 0)
                    {
                        aux1 = aux1 + 1;
                        aux3 = b;
                    }
                }
                if (aux1 == 1)
                { 
                    aux1 = 0;
                    for (int u = 0; u < fila; u++)
                    {
                        if (matriz[u, aux3] == 0)
                        {
                            aux2 = aux2 + 1;
                        }
                    }
                    if (aux2 == 1)
                    {
                        Console.WriteLine("\nCumple la posicion fila " + a + " columna " + aux3);
                        aux2 = 0;
                    }
                }
                a++;
            }
        }
        
        static void Main(string[] args)
        {
            console1 ejer1 = new console1();
            ejer1.insertar();
            Console.WriteLine("\nDatos ingresados");
            ejer1.mostrar();
            Console.WriteLine("\nResultados");
            ejer1.cumple();            
            Console.ReadKey();
        }
    }
}