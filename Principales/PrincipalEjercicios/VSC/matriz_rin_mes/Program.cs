using System;
namespace ejercicio1
{
    class ejercicio1
    {
        private int[,] matriz;
        private float[] vec;
        public int r, m,cont;
        public void ingresarmatriz()
        {
            string linea;
            Console.Write("Total de rin : ");
            linea = Console.ReadLine();
            r = int.Parse(linea);
            Console.Write("Total de meses: ");
            linea = Console.ReadLine();
            m= int.Parse(linea);
            matriz = new int[r, m];
            for (int x = 0; x < r; x++)
            {
                Console.Write("\nRin: " + (x + 1));
                for (int z = 0; z < m; z = z + 1)
                {
                    Console.Write("\nMes : " + (z + 1) + ": ");
                    linea = Console.ReadLine();
                    matriz[x, z] = int.Parse(linea);
                }
            }
        }
        public void imprirmirmatriz()
        {
            Console.WriteLine("\nMatriz de datos ingresados");
            for (int x = 0; x < r; x++)
            {
                for (int z = 0; z < m; z = z + 1)
                {
                    Console.Write(matriz[x, z] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void lita()
        {
            int suma, x;            
            for (x = 0; x < r; x++)
            {
                suma = 0;
                for (int z = 0; z < m; z = z + 1)
                {
                    suma = suma + matriz[x, z];
                }
                if (suma>100 & suma<250)
                {
                    Console.Write("\nEl rin que vente 100 y 250 es rin #" + (x+1));
                }
                suma = 0;
            }            
        }

        public void litb()
        {
            float suma = 0;
            float sumat = 0;
            float promedio = 0;
            int x = 0;
            for (x = 0; x < r; x++)
            {
                for (int z = 0; z < m; z = z + 1)
                {
                    sumat = sumat + matriz[z, x];
                }                
            }
            vec = new float[m];
            cont = 0;
            for ( x = 0; x < r; x++)
            {
                for (int z = 0; z < m; z = z + 1)
                {
                    suma = suma + matriz[z, x];
                }                
                promedio = (suma / sumat)*100;
                vec[cont]= promedio;
                cont = cont + 1;
                Console.Write("\n\nPromedio venta del mes " + (x + 1) + " es " + promedio.ToString("N2")+"%");
                suma = 0;
            }            
        }

        public void litc()
        {
            int i, j;
            float aux;            
            for (i = 0; i < cont; ++i)
            {
                for (j = i + 1; j < cont; ++j)
                {
                    if (vec[i] > vec[j])
                    {
                        aux = vec[i];
                        vec[i] = vec[j];
                        vec[j] = aux;
                    }
                }
            }
            Console.WriteLine("\nPromedio ordenados \n");
            for (i = 0; i < cont; ++i)
            {                
             Console.WriteLine( vec[i]+"%");                
            }

        }

        static void Main(string[] args)
        {
            ejercicio1 Obj = new ejercicio1();
            Obj.ingresarmatriz();
            Obj.imprirmirmatriz();
            Obj.lita();
            Obj.litb();
            Obj.litc();
            Console.ReadKey();
        }
    }
}