using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ejer3
{
    class ejer3
    {
        private int[,] matDatos;
        public int m,nn;

        public void insertar1()
        {         
            Console.Write("Cantidad filas: ");
            nn = Convert.ToInt32(Console.ReadLine());                        
        }

        public void insertar2()
        {
            Console.Write("Cantidad columnas: ");
            m = Convert.ToInt32(Console.ReadLine());
        }

        public void insertar3()
        {           
            
            matDatos = new int[nn, m];
            for (int u = 0; u < nn; u++)
            {                
                for (int k = 0; k < m; k++)
                {
                    //Console.Write("\nPosicion ("+(u+1)+","+ (k + 1) + "): ");                    
                    //matDatos[u, k] = Convert.ToInt32(Console.ReadLine());
                    Random rand = new Random();
                    matDatos[u, k] = rand.Next(1, 1000);
                }
            }
        }
        public void visualizarDatos()
        {
            Console.WriteLine("\n\n");
            for (int u = 0; u < nn; u++)
            {
                for (int k = 0; k < m; k = k + 1)
                {
                    Console.Write(matDatos[u, k] + "    ");
                }
                Console.WriteLine();
            }
        }
        public void proceso()
        {   
            for (int u = 0; u < m; u++)
            {
                int maximo = 0;
                for (int k = 0; k < nn; k = k + 1)
                {
                    if (matDatos[k,u]>maximo)
                    {
                        maximo = matDatos[k, u];
                    }
                }                
                int entero = maximo;
                int acumulador = 0;
                int digi;
                while (entero > 0 )
                {
                    digi = entero % 10;                    
                    entero = entero / 10;
                    acumulador++;
                }                
                Console.WriteLine("-Columna " +u+" = "+acumulador);
            }
        }       
        static void Main(string[] args)
        {
            ejer3 objM = new ejer3();
            objM.insertar1();
            objM.insertar2();
            objM.insertar3();
            objM.visualizarDatos();            
            objM.proceso();                     
        }
    }
}