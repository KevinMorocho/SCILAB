using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace console3
{
    class console3
    {
        private int[,] mat;
        public int sucur;
        public void ingresarMatriz()
        {
            string linea;
            Console.Write("Total de sucursales a ingresar? ");
            linea = Console.ReadLine();
            sucur = int.Parse(linea);
            mat = new int[sucur, 12];
            for (int i = 0; i < sucur; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Random ra = new Random();
                    mat[i, j] = ra.Next(1, 20);
                }
            }
        }
        public void mostraMatriz()
        {
            Console.WriteLine(" ");
            for (int i = 0; i < sucur; i++)
            {
                for (int j = 0; j < 12; j = j + 1)
                {
                    Console.Write(mat[i, j] + "    ");
                }
                Console.Write("\n    ");
            }
        }
        public void totalCompania()
        {
            int total = 0;
            Console.Write("\n    ");
            for (int i = 0; i < sucur; i++)
            {
                for (int j = 0; j < 12; j = j + 1)
                {
                    total = total + mat[i, j];
                }
            }
            Console.WriteLine("\nVenta total es: "+total);
        }
        public void sucursalVentas()
        {
            int total = 0;
            Console.Write("\n    ");
            for (int i = 0; i < sucur; i++)
            {
                for (int j = 0; j < 12; j = j + 1) 
                {
                    total = total + mat[i, j];
                }
                Console.WriteLine("Sucursal " + (i + 1) + " la venta es $" + total);
                total = 0;
            }
        }

        public void SucursalMasVendida()
        {            
            int totalidad = 0;
            int minimo = 99999;
            int pos_men = 0;
            int total = 0;
            int maximo = 0;
            int pos_may = 0;
            Console.Write("\n    ");
            for (int i = 0; i < sucur; i++)
            {
                for (int j = 0; j < 12; j = j + 1)
                {
                    total = total + mat[i, j];
                }
                if (total > maximo)
                {
                    maximo = total;
                    pos_may = i + 1;
                }
                total = 0;
            }
            Console.WriteLine("Sucursal que mas vendió durante el año es la sucursal#" + pos_may);
            Console.Write("\n    ");
            total = 0;            
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < sucur; j = j + 1)
                {
                    total = total + mat[j, i];
                    totalidad = totalidad + mat[j, i];
                }
                if (total < minimo)
                {
                    minimo = total;
                    pos_men = i + 1;
                }
                total = 0;
            }
            float por = (minimo * 100) / totalidad;
            Console.WriteLine("Mes menos vendió es " + pos_men + " y tiene " + por + "% de venta durante todo el año");
        }
       

        static void Main(string[] args)
        {
            console3 obj = new console3();
            obj.ingresarMatriz();
            obj.mostraMatriz();
            obj.totalCompania();
            obj.sucursalVentas();
            obj.SucursalMasVendida();            
            Console.ReadKey();
        }
    }
}