using System;
namespace partidosMat
{
    class totalPartidos
    {
        private int[,] mat_pg;
        public int total_equi, total_mes;
        public void llenar()
        {
            Console.Write("Total de equipos : ");
            total_equi = Convert.ToInt32(Console.ReadLine());            
            total_mes = 12;
            mat_pg = new int[total_equi, total_mes];
            for (int t = 0; t < total_equi; t++)
            {
                Console.Write("\n\nEquipo: # " + (t + 1));
                for (int u = 0; u < total_mes; u = u + 1)
                {
                    if (u == 0)
                    {
                        Console.Write("\nEnero: ");
                    }
                    if (u == 1)
                    {
                        Console.Write("\nFebrero: ");
                    }
                    if (u == 2)
                    {
                        Console.Write("\nMarzo: ");
                    }
                    if (u == 3)
                    {
                        Console.Write("\nAbril: ");
                    }
                    if (u == 4)
                    {
                        Console.Write("\nMayo: ");
                    }
                    if (u == 5)
                    {
                        Console.Write("\nJunio: ");
                    }
                    if (u == 6)
                    {
                        Console.Write("\nJulio: ");
                    }
                    if (u == 7)
                    {
                        Console.Write("\nAgosto: ");
                    }
                    if (u == 8)
                    {
                        Console.Write("\nSeptiembre: ");
                    }
                    if (u == 9)
                    {
                        Console.Write("\nOctubre: ");
                    }
                    if (u == 10)
                    {
                        Console.Write("\nNoviembre: ");
                    }
                    if (u == 11)
                    {
                        Console.Write("\nDiciembre: ");
                    }
                    //mat_pg[t, u] = Convert.ToInt32(Console.ReadLine());                    
                    Random naa = new Random();
                    mat_pg[t, u] = naa.Next(1, 9);
                }
            }
        }
        public void visualizar()
        {
            Console.WriteLine("\n\nMatriz de datos ingresados");
            for (int t = 0; t < total_equi; t++)
            {
                for (int u = 0; u < total_mes; u = u + 1)
                {
                    Console.Write(mat_pg[t, u] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void partidoGanado()
        {
            int vence = 0;
            int may = 0;
            int pos = 0;
            for (int t = 0; t < total_equi; t++)
            {
                vence = 0;
                for (int u = 0; u < total_mes; u = u + 1)
                {                    
                    vence = vence + mat_pg[t,u];                    
                }
                if (vence>may)
                {
                    may = vence;
                    pos = t;
                }
                           
            }
            Console.Write("\nEquipo ganador es el #" + (pos + 1) + " y ganó " + may + " partidos");
        }
        public void masGanador()
        {
            int mes = 1;
            int mayor = 0;
            int contador = 0;
            for (int t = 0; t < total_mes; t++)
            {
                contador = 0;
                for (int u = 0; u < total_equi; u = u + 1)
                {                    
                    contador = contador + mat_pg[u,t];                 
                }
                
                if (contador > mayor)
                {
                    mayor = contador;
                    mes = t;
                }
            }
            Console.Write("\n\nEl mes con mas victorias tiene es ");
            if (mes == 0)
            {
                Console.Write(" Enero: ");
            }
            if (mes == 1)
            {
                Console.Write(" Febrero: ");
            }
            if (mes == 2)
            {
                Console.Write(" Marzo: ");
            }
            if (mes == 3)
            {
                Console.Write(" Abril: ");
            }
            if (mes == 4)
            {
                Console.Write(" Mayo: ");
            }
            if (mes == 5)
            {
                Console.Write(" Junio: ");
            }
            if (mes == 6)
            {
                Console.Write(" Julio: ");
            }
            if (mes == 7)
            {
                Console.Write(" Agosto: ");
            }
            if (mes == 8)
            {
                Console.Write(" Septiembre: ");
            }
            if (mes == 9)
            {
                Console.Write(" Octubre: ");
            }
            if (mes == 10)
            {
                Console.Write(" Noviembre: ");
            }
            if (mes == 11)
            {
                Console.Write(" Diciembre: ");
            }
        }


        static void Main(string[] args)
        {
            totalPartidos partidosObj = new totalPartidos();
            partidosObj.llenar();
            partidosObj.visualizar();
            partidosObj.partidoGanado();
            partidosObj.masGanador();
            Console.ReadKey();
        }
    }
}
