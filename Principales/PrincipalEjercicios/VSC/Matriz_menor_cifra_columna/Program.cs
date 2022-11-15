using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Matriz_menor_cifra_columna
{
    class matC
    {
        private int[,] matriz;
        public int fila, col;
        public void ingresar_imprimir()
        {
            string linea;
            Console.Write("Numero de Filas ");
            linea = Console.ReadLine();
            fila = int.Parse(linea);
            Console.Write("Numero de Columnas ");
            linea = Console.ReadLine();
            col = int.Parse(linea);
            matriz = new int[fila, col];
            for (int c = 0; c < fila; c++)
            {
                Console.Write("\nFila -> " + c + "\n");
                for (int q = 0; q < col; q = q + 1)
                {
                    Console.Write("Columna -> " + q + " = ");
                    linea = Console.ReadLine();
                    matriz[c, q] = int.Parse(linea);
                }
            }
            
            Console.WriteLine("\n\nDatos de la matriz");            
            for (int c = 0; c < fila; c++)
            {
                for (int q = 0; q < col; q = q + 1)
                {
                    Console.Write(matriz[c, q] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        public void menor_C()
        {           
            int divi, u;            
            for (int c = 0; c < col; c++)
            {
                int men = 10;
                for (int q = 0; q < fila; q = q + 1)
                {                    
                    int t = matriz[q, c];
                    u = 0;
                    if (t != 0)
                    {
                        while (t != 0)
                        {
                            divi = t % 10;
                            t = t / 10;
                            u++;
                        }
                        if (u < men)
                        {
                            men = u;
                        }
                    }
                    else
                    {
                        men = 1;
                    }                    
                }
                Console.WriteLine("Columna " + c + " -> " + men );                
            }
        }
        static void Main(string[] args)
        {
            matC col_men = new matC();
            col_men.ingresar_imprimir();            
            col_men.menor_C();
            Console.ReadKey();
        }
    }
}
