using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace console2
{
    class console2
    {
        private float[,] matriz;        
        public void insertar()
        {
            string linea;
            matriz = new float[11, 3];
            for (int a = 0; a < 12; a++)
            {
                Console.Write("\nMaterial " + (a + 1) + "\n");
                for (int b = 0; b < 3; b++)
                {
                    Console.Write("Fractura  " + (b + 1) + ": ");
                    linea = Console.ReadLine();
                    matriz[a, b] = int.Parse(linea);
                }
            }
        }
        
        public void mostrar()
        {
            Console.WriteLine("\nDatos ingresados");
            for (int a = 0; a < 12; a++)
            {
                for (int b = 0; b <3; b = b + 1)
                {
                    Console.Write(matriz[a, b] + "    ");
                }
                Console.WriteLine();
            }
        }
        public void numero1()
        {
            float men1 = matriz[0,1];
            float men2 = matriz[0,1];

            for (int a = 0; a < 12; a++)
            {
                for (int b = 1; b < 2; b = b + 1)
                {
                    if (matriz[a, b] <men1) {
                        men1 = matriz[a, b];
                        men2 = matriz[a, b];
                    }
                }                
            }
            Console.WriteLine("\n Elemento menor de tension plana es: "+men1);
            Console.WriteLine("\n Elemento menor de tension plana es: " + men2);
        }

        
        static void Main(string[] args)
        {
            console2 eje1 = new console2();
            eje1.insertar();
            eje1.mostrar();            
            eje1.numero1();            
            Console.ReadKey();
        }
    }
}