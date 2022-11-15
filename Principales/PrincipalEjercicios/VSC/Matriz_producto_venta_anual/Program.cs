using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace console2
{
    class console2
    {
        private int[,] matriz;        
        public int arti;
        public void insertar()
        {            
            string linea;
            Console.Write("Total de articulos articulos: ");
            linea = Console.ReadLine();
            arti= int.Parse(linea);                        
            matriz = new int [12,arti];            
            for (int a =0; a<12; a++)
            {
                Console.Write("\nFila - mes " + (a+1) +"\n");
                for (int b=0; b<arti; b++)                 
                {
                    Console.Write("Columna - articulo  "+(b+1)+": " );                    
                    linea = Console.ReadLine(); 
                    matriz[a,b] = int.Parse(linea);            
                }
            }
        }
        public void mostrar()
        {
            Console.WriteLine("\nDatos ingresados");
            for (int a = 0; a < 12; a++)
            {
                for (int b = 0; b < arti; b = b + 1)
                {
                    Console.Write(matriz[a, b] + "    ");
                }
                Console.WriteLine();
            }
        }
        public void ventasarti()
        {
            float aniomes;
            Console.WriteLine("\nVenta mensual:");
            for (int a = 0; a < 12; a++)
            {
                aniomes = 0;
                for (int b = 0; b < arti; b = b + 1)
                {
                    aniomes = aniomes + matriz[a, b];
                }
                Console.Write("mes #" + (a + 1) + " = $" + aniomes);
                Console.WriteLine();
            }

            int anual;
            Console.WriteLine("\nVenta anual de cada producto:");
            for (int a = 0; a < arti; a++)
            {
                anual = 0;
                for (int b = 0; b < 12; b = b + 1)
                {
                    anual = anual + matriz[b,a];
                }
                Console.Write("Producto # " + (a + 1) + " = $" + anual);
                Console.WriteLine();
            }
        }

        public void ventapor()
        {
            int aux1=0;
            int a;
            Console.WriteLine("\nPorcentaje mensual de forma descente:");
            for (a = 0; a < 12; a++)
            {                
                for (int b = 0; b < arti; b=b+1)
                {
                    aux1 = aux1 + matriz[a,b];
                }                
            }

            float aux3;
            float aux2;
            a = 11;            
            while ( a >=0 )
            {
                aux2 = 0;
                for (int b = 1; b <arti ; b++)
                {
                    aux2 = aux2 + matriz[a, b];
                }
                aux3 = (float)(aux2 / aux1) * 100;                
                Console.Write("mes #"+(a+1));               
                Console.WriteLine(" = "+aux3.ToString("N2")+"%");
                aux2 = 0;
                a--;
            }
        }

        static void Main(string[] args)
        {
            console2 eje1 =new console2();
            eje1.insertar();
            eje1.mostrar();
            Console.WriteLine("\nResultados");
            Console.WriteLine("\nVentas");
            eje1.ventasarti();
            eje1.ventapor();
            Console.ReadKey();
        }     
    }
}