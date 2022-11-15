using System;
namespace Matriz_simetrica
{
    class Eje3
    {
        private int[,] ma_datos;
        public int total_elementos, diagonal1, diagonal2,k,z;

        public void cantidadElementos() 
        {
            Console.Write("\nCuantas columnas y filas va a ma_datos ingresar? ");
            total_elementos = Convert.ToInt32(Console.ReadLine());
        }
        public void matrizIngresar()
        {                        
            ma_datos = new int[total_elementos, total_elementos];
            for (int k = 0; k < total_elementos; k++)
            {                
                for (int z = 0; z < total_elementos; z ++)
                {
                    Console.Write("\nPosicion : " + (k + 1)+"," +(z+1)+ ": ");
                    ma_datos[k, z] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void matrizimprimir()
        {
            Console.WriteLine("\n");
            for (int k = 0; k < total_elementos; k++)
            {
                for (int z = 0; z < total_elementos; z++)
                {
                    Console.Write(ma_datos[k, z] + "       ");
                }
                Console.WriteLine();
            }
        }
        public void calculosFilas()
        {
            diagonal1 = 0;
            int sumador_elementos = 0;
            int ax = 2;
            for (int k = 0; k < total_elementos; k++)
            {
                for (int z = 0; z < total_elementos; z++)
                {
                    ax = ax + 1;
                }
                if (ma_datos[k, sumador_elementos] == ma_datos[sumador_elementos, k])
                {
                    diagonal1 = diagonal1 + 1;
                }
                sumador_elementos = sumador_elementos + 1;
            }


            sumador_elementos = total_elementos - 1;
            diagonal2 = 0;
            for (int k = 0; k < total_elementos; k++)
            {
                for (int z = 0; z < total_elementos; z++)
                {
                    ax = ax + 1;
                }
                if (ma_datos[sumador_elementos, total_elementos - 1] == ma_datos[total_elementos - 1, sumador_elementos])
                {
                    diagonal2 = diagonal2 + 1;
                }
                sumador_elementos = sumador_elementos - 1;
            }            
       }
    
        public void calculosFC()
        {
            if (diagonal1 == total_elementos & diagonal2 == total_elementos)
            {
                Console.WriteLine("\n\n->La matriz no tiene simetria");
            }
            else
            {
                Console.WriteLine("\n\n->La matriz no tiene simetria");
            }
        }

        static void Main(string[] args)
        {
            Eje3 SiEjercicio3 = new Eje3();
            SiEjercicio3.cantidadElementos();
            SiEjercicio3.matrizIngresar();            
            SiEjercicio3.matrizimprimir();
            SiEjercicio3.calculosFilas();            
            SiEjercicio3.calculosFC();
            Console.ReadKey();
        }
    }
}

