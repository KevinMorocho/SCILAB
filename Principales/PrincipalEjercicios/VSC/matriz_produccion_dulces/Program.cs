using System;
namespace matPro
{
    class matPro
    {
        private float[,] matriz;
        public int meses, dulces;

        public void ingresarmatriz()
        {
            string linea;
            meses = 12;
            dulces = 3;
            matriz = new float[meses, dulces];
            for (int q = 0; q < meses; q++)
            {
                Console.Write("\nDepartamento : " + (q + 1));
                for (int w = 0; w < dulces; w = w + 1)
                {
                    Console.Write("\nMes : " + (w + 1) + ": ");
                    //linea = Console.ReadLine();
                    //matriz[q, w] = int.Parse(linea);
                    Random ra = new Random();
                    matriz[q, w] = ra.Next(1, 9);
                }
            }
        }
        public void mostrarMAtriz()
        {
            Console.WriteLine("\n\n\nMatriz resultante");
            for (int q = 0; q < meses; q++)
            {
                for (int w = 0; w < dulces; w = w + 1)
                {
                    Console.Write(matriz[q, w] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void masProduccion()
        {
            float acum;
            int pos = 0;
            float may = 0;
            for (int q = 0; q < meses; q = q + 1)
            {
                acum = 0;
                for (int w = 0; w < dulces; w = w + 1)
                {
                    acum = acum + matriz[q, w];
                }
                if (acum > may)
                {
                    may = acum;
                    pos = q;
                }
            }
            Console.Write("\nEl mayor mes donde hay produccion es el mes #" + (pos + 1));
        }
        public void promedioAnual()
        {
            float acum = 0;
            float pro = 0;
            int q = 0;
            for (q = 0; q < meses; q = q + 1)
            {

                for (int w = 1; w < 2; w = w + 1)
                {
                    acum = acum + matriz[q, w];
                }
            }
            pro = acum / 12;
            Console.WriteLine("\n\nPromedio anual de venta en bebida es: " + pro);
        }

        public void menorCostoBebida()
        {
            float men = matriz[0, 2];
            int pos = 0;
            for (int q = 0; q < meses; q = q + 1)
            {
                for (int w = 1; w < 2; w = w + 1)
                {
                    if (matriz[q, w] < men)
                    {
                        men = matriz[q, w];
                        pos = q;
                    }
                }
            }
            Console.WriteLine("\nEl mes " + (pos + 1) + " es el mens con menos costo de produccion ");
        }

        static void Main(string[] args)
        {
            matPro almacen = new matPro();
            almacen.ingresarmatriz();
            almacen.mostrarMAtriz();
            almacen.masProduccion();
            almacen.promedioAnual();
            almacen.menorCostoBebida();
            Console.ReadKey();
        }
    }
}