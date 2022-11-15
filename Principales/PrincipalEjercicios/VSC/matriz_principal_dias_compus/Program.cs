using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace carbon
{
    class carbon
    {
        private float[,] matriz;
        private float[] tabla;
        public int dias, producto;
        public void insertarDatos()
        {
            dias = 7;

            Console.WriteLine("Ingrese total de dispositivos"); //Escribir
            string n = Console.ReadLine(); 
            producto = int.Parse(n);

            matriz = new float[producto, dias];
           
            for (int a = 0; a < producto; a++)
            {
                for (int j = 0; j < dias; j = j + 1)
                {
                    Random aleto = new Random();
                    matriz[a, j] = aleto.Next(1, 99);
                }
            }
        }
        public void mostrarDatos()
        {
            Console.WriteLine("\nMatriz dispositivos - dias");
            for (int a = 0; a < producto; a++)
            {
                for (int j = 0; j < dias; j = j + 1)
                {
                    Console.Write(matriz[a, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void lit_A()
        {
            Console.WriteLine("\nLiteral A");
            float stotal;
            stotal = 0;
            for (int a = 0; a < producto; a=a+1) //a++
            {
                for (int j = 0; j < dias; j++) //j++
                {
                    stotal = stotal + matriz[a,j];
                }               
            }
            Console.WriteLine("\nsumatoria total"+stotal);

            float por;
            float sumaF = 0;
            for (int a = 0; a < producto; a++)
            {
                for (int j = 0; j < dias; j = j + 1)
                {
                    sumaF = sumaF + matriz[a,j];
                }
                por = (sumaF / stotal)*100;                
                Console.WriteLine("Porcentaje dispositivos: " + (a + 1) + " es " + por+"%");
                sumaF = 0;
            }
            
        }


        public void lit_B()
        {
            Console.WriteLine("\nLiteral b");
            float may = 0;
            float men = 999;
            int posmay =0;
            int posmen =0;
            float sumamay = 0;
            float sumamen = 0;
            for (int a = 0; a < dias; a++)
            {
                for (int j = 0; j < producto; j = j + 1)
                {
                    sumamay = sumamay + matriz[j, a];
                    sumamen = sumamen + matriz[j, a];
                }
                //
                if (sumamay>may) {
                    may = sumamay;
                    posmay = a;
                }
                if (sumamen < men)
                {
                    men = sumamen;
                    posmen = a;
                }
                sumamay = 0;
                sumamen = 0;
            }
            Console.WriteLine("El dia de mayor consumo es el dia "+posmay);
            Console.WriteLine("El dia de menor consumo es el dia "+posmen);
        }

        public void lit_C()
        {
            tabla = new float[dias];
            Console.WriteLine("\nLiteral C");
            int a, j, i;
            float aux;
            for (a = 3; a < 4; a++)
            {
                for (j = 0; j < dias; j = j + 1)
                {
                    tabla[j] = matriz[a, j];
                    // Console.Write(tabla[a] + "  ");
                }
            }
            //ordenar
            for (i = 0; i < dias; ++i)
            {
                for (j = i + 1; j < dias; ++j)
                {
                    if (tabla[i] > tabla[j])
                    {
                        aux = tabla[i];
                        tabla[i] = tabla[j];
                        tabla[j] = aux;
                    }
                }
            }
            for (a = 3; a < 4; a++)
            {
                for (j = 0; j < dias; j = j + 1)
                {
                    matriz[a, j] = tabla[j];
                }
            }

            Console.WriteLine("\nDatos ordenados por plotters");
            for (a = 0; a < producto; a++)
            {
                for (j = 0; j < dias; j = j + 1)
                {
                    Console.Write(matriz[a, j] + "  ");
                }
                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            carbon obj = new carbon();
            obj.insertarDatos();
            obj.mostrarDatos();
            obj.lit_A();
            obj.lit_B();
            obj.lit_C();
            Console.ReadKey();
        }
    }
}