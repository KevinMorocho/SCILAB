using System;
namespace vacas_m
{
    class vacas_m
    {
        private int n;
        private int[,] matriz;
        private float[] vec;
        public void insertar()
        {
            string linea;
            Console.Write("\nTotal de vacas?: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            matriz = new int[7, n];
            for (int a = 0; a < 7; a++)
            {
                Console.Write("\nDia " + (a + 1) + "\n");
                for (int b = 0; b < 5; b++)
                {
                    Console.Write("Vaca  " + (b + 1) + ": ");
                    //linea = Console.ReadLine();
                    //matriz[a, b] = int.Parse(linea);
                    Random aleatorio = new Random();
                    matriz[a, b]=aleatorio.Next(1, 5);
                }
            }
        }
        public void mostrar()
        {
            Console.WriteLine("\nMatriz ");
            for (int a = 0; a < 7; a++)
            {
                for (int b = 0; b < n; b = b + 1)
                {
                    Console.Write(matriz[a, b] + "    ");
                }
                Console.WriteLine();
            }
        }
        public void literal1()
        {
            float sumaT=0;
            
            for (int a = 0; a < 7; a++)
            {                
                for (int b = 0; b < 5; b = b + 1)
                {
                    sumaT=sumaT+ + matriz[a, b];
                }
                Console.WriteLine("\ndia :"+(a+1)+" total de produccion es: "+sumaT);
                sumaT = 0;
            }
        }

        public void literal2()
        {            
           
        }
        public void literal3()
        {
            
            float sumatotal = 0;
            for (int a = 0; a < 7; a++)
            {
                for (int b = 1; b < n; b = b + 1)
                {
                    sumatotal = sumatotal + matriz[a, b];
                }
            }

            float diavaca = 0;
            for (int a = 0; a < 7; a++)
            {
                diavaca = 0;
                for (int b = 1; b < n; b = b + 1)
                {
                    diavaca=diavaca+ matriz[a, b];
                }

                float pro = (diavaca / sumatotal) * 100;
                Console.WriteLine("dia "+a+" tiene de prodccion el "+pro+"% ");
            }
        }

        static void Main(string[] args)
        {
            vacas_m vacas = new vacas_m();
            vacas.insertar();
            vacas.mostrar();
                   
            vacas.literal1();
            vacas.literal2();
            vacas.literal3();
            Console.ReadKey();
        }
    }
}