using System;
namespace Matriz_platos_semana
{
    class PlatoEjercicio2
    {
        private int[,] plato_matriz;
        public int cantidad_platos,venta_miercoles,cantidad_dias,k,z;

        public void cantidadPlatos() 
        {
            Console.Write("Ingrese el numero de cantidad_platos ");
            cantidad_platos = Convert.ToInt32(Console.ReadLine());
        }

        public void ingresarPlatos()
        {
            cantidad_dias = 7;
            plato_matriz = new int[cantidad_platos, 7];
            for ( z = 0; z < cantidad_platos; z++)
            {
                Console.WriteLine("Plato #" + (z + 1));
                for ( k = 0; k < cantidad_dias; k = k + 1)
                {
                    Console.WriteLine("Dia #" + (k + 1));
                    plato_matriz[z, k] = Convert.ToInt32(Console.ReadLine());                    
                    //Random ra = new Random();
                    //plato_matriz[z, k] = ra.Next(1, 10);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matriz de dias y platos vendidos");            
            for ( z = 0; z < cantidad_platos; z++)
            {
                for ( k = 0; k < cantidad_dias; k = k + 1)
                {
                    Console.Write(plato_matriz[z, k] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public void platosSemana()
        {
            Console.WriteLine("\nVenta de la semana de los platos de comida:");
            for ( z = 0; z < cantidad_platos; z++)
            {
                venta_miercoles = 0;
                for ( k = 0; k < cantidad_dias; k = k + 1)
                {
                    venta_miercoles = venta_miercoles + plato_matriz[z, k];
                }
                Console.WriteLine("Venta del Plato ->" + (z+1) + " = " + venta_miercoles + "  ");
            }
        }

        public void suma_miercoles()
        {
            venta_miercoles = 0;
            int miercoles_venta = 3;            
            for ( z = 0; z < cantidad_platos; z++)
            {
                for ( k = 2; k < miercoles_venta; k++)
                {
                    venta_miercoles = venta_miercoles + plato_matriz[z, k];
                }
            }
            Console.WriteLine("\nEl dia miercoles en total se vendieron una cantidad ->" + venta_miercoles + " platos");
        }

        static void Main(string[] args)
        {
            PlatoEjercicio2 plato_matriz = new PlatoEjercicio2();
            plato_matriz.cantidadPlatos();   
            plato_matriz.ingresarPlatos();            
            plato_matriz.platosSemana();            
            plato_matriz.suma_miercoles();
            Console.ReadKey();
        }
    }
}