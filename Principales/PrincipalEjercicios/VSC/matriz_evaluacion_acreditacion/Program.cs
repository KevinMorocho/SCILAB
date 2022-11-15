using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace app
{
    class app
    {
        private int[,] mat;
        private int n;        
        public void ingresarMatriz()
        {                      
            mat = new int[7, 4];
            n = 7;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Random ra = new Random();
                    mat[i, j] = ra.Next(1, 10);
                }
            }
        }
        public void mostraMatriz()
        {
            Console.WriteLine(" Datos alamcenados...");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j = j + 1)
                {
                    Console.Write(mat[i, j] + "   ");
                }
                Console.Write("\n");
            }
        }
        public void prgun1()
        {
            float sumatoria = 0;
            float sumatoriaT = 0;           

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j = j + 1)
                {
                    sumatoriaT = sumatoriaT + mat[j, i];
                }
            }
            

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j = j + 1)
                {
                    sumatoria = sumatoria + mat[j, i];
                }                
                float pro1 = sumatoria / 7;
                sumatoriaT = sumatoriaT + pro1;
                Console.WriteLine("Promedio carrera " + i + " es " + pro1);
                pro1 = 0;
            }
            float pro = (sumatoriaT/8);
            Console.WriteLine("Promedio total es:"+ pro);



        }


        static void Main(string[] args)
        {
            app objm = new app();
            objm.ingresarMatriz();
            objm.mostraMatriz();
            objm.prgun1();            
            Console.ReadKey();
        }
    }
}