using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace matR
{
    class matR
    {
        private int[,] m;
        private int[] vec;
        public int fila;
        public int col;
        public int cam;
        public void insertar()
        {            
            Console.Write("Numero de filas (n):  ");         
            fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero de columnas (n): ");            
            col = Convert.ToInt32(Console.ReadLine());
            m = new int[fila, col];
            for (int i = 0; i < fila; i++)
            {
                Console.Write("\nFila(s)" + i + "\n");
                for (int t = 0; t < col; t = t + 1)
                {
                    Console.Write("Columna(s)" + t + ": ");            
                    int aux= Convert.ToInt32(Console.ReadLine());
                    while(aux>50) 
                    {
                        Console.Write("Valor max 50 ");
                        Console.Write("Columna(s) " + t + ": ");
                        aux = Convert.ToInt32(Console.ReadLine());                        
                    }
                    m[i, t] = aux;
                }
            }
        }
        public void mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("m");
            for (int i = 0; i < fila; i++)
            {
                for (int t = 0; t < col; t = t + 1)
                {
                    Console.Write(m[i, t] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void promedio()
        {
            float sumaCol;
            float pro;
            Console.WriteLine("Promedio ");
            for (int i = 0; i < col; i++)
            {
                sumaCol = 0;
                for (int t = 0; t < fila; t = t + 1)
                {
                    sumaCol = sumaCol + m[t,i];
                }
                pro = (sumaCol / col) ;                
                Console.WriteLine("Columna " + i + ": "+ pro);
            }
            Console.WriteLine();
        }

        public void reemplazo()
        {
            int desglo;
            cam = 0; 
            for (int i = 0; i < fila; i++)
            {                
                for (int t = 0; t < col; t = t + 1)       
                {
                    int x = m[i, t];                
                    int numI = 0;
                    int numN = 0;
                    while (x != 0)
                    {
                        desglo = x % 10;                        
                        numI = numI * 10 + desglo;
                        x = x / 10;
                    }
                    x = numI;
                    int aux = 0;
                    while (x != 0)
                    {
                        desglo = x % 10;                        
                        if (desglo==3) 
                        {
                            numN = (numN * 10) + 1;
                            aux++;
                        }
                        else
                        {
                            numN = numN * 10 + desglo;
                        }
                        x = x / 10;
                    }
                    if (aux > 0) 
                    {
                        numN = numN * -1;
                        cam++;
                    }
                    m[i, t] = numN;                    
                }                                
            }
            Console.WriteLine();
        }

        public void cambios()
        {
            Console.WriteLine("Se realizaron " + cam + " cambios");
        }
        public void mostrarN()
        {
            
            Console.WriteLine("m datos reemplazados");
            for (int i = 0; i < fila; i++)
            {
                for (int t = 0; t < col; t = t + 1)
                {
                    Console.Write(m[i, t] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matR mCambios = new matR();
            mCambios.insertar();            
            mCambios.mostrar();            
            mCambios.promedio();            
            mCambios.reemplazo();
            mCambios.cambios();
            mCambios.mostrarN();            
            Console.ReadKey();
        }
    }
}