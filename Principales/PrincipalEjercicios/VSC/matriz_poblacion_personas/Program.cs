using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m_parroquias
{
    class exa
    {
        private int[,] matriz;
        public void ingresarmatriz()
        {
            string linea;                        
            matriz = new int[4, 3];
            int valor;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\nParroquia : " + (i + 1));
                for (int j = 0; j < 3; j = j + 1)
                {
                    if (j == 0)
                    {
                        Console.Write("\nNinios : " + (j + 1) + ": ");
                    }
                    if (j == 1)
                    {
                        Console.Write("\nAdultos : " + (j + 1) + ": ");
                    }
                    if (j == 2)
                    {
                        Console.Write("\nAdultos mayores : " + (j + 1) + ": ");
                    }                    
                    linea = Console.ReadLine();
                    valor= int.Parse(linea);
                    while (valor <1  || valor > 100)
                    {
                        Console.Write("\nNota: Ingrese nuevamente un valor (1-100):  ");
                        linea = Console.ReadLine();
                        valor = int.Parse(linea);
                    }
                    matriz[i, j] = valor;
                    
                }
            }
        }
        public void imprirmirmatriz()
        {
            Console.WriteLine();
            Console.WriteLine("\nMatriz parroquia - segmento");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void literaA()
        {
            float pro;
            float suma;
            int pos = 0;
            int i, j;
            float may = 10;
            for (i = 0; i < 4; i++)
            {
                suma = 0;
                for (j = 0; j < 3; j = j + 1)
                {
                    suma = suma + matriz[i,j];
                }                
                pro = (suma / 3); 
                if (pro > may)
                {
                    may = pro;
                    pos = i;
                }                
            }
            Console.Write("\nPromedio con mejor califiacion tiene la parroquia: " + (pos+1));
        }
        public void literaB()
        {            
            int pos = 0;
            int i, j;
            float menor = 50;
            for (i = 1; i < 4; i++)
            {                
                for (j = 0; j < 3; j = j + 1)
                {
                    if (matriz[i,j]< menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }
            Console.Write("\n\nEl segmentos con menor califiacion de la parroquia Maldonado es el:  " + (pos + 1));
        }

        public void literaC()
        {
            float pro;
            float suma;            
            int i, j;            
            suma = 0;
            for (i = 1; i < 4; i++)
            {                
                for (j = 0; j < 3; j = j + 1)
                {                                       
                    suma=suma+matriz[i, j];
                }
            }
            pro = (suma) / (2 * 3);
            Console.Write("\n\nEl promedio de califiacion del servicio en todala ciudad es de: " + (pro));
        }

        static void Main(string[] args)
        {
            exa parrObj = new exa();
            parrObj.ingresarmatriz();
            parrObj.imprirmirmatriz();
            parrObj.literaA();            
            parrObj.literaB();            
            parrObj.literaC();            
            Console.ReadKey();
        }
    }
}


