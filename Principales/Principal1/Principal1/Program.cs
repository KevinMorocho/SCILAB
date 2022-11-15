	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	
	namespace Principal1
	{
	    class Program
	    {
	        private double[,] mat;
	        private double[] vec;
	        public int c, f;
	
	        public void ingresarMat()
	        {
	            Console.WriteLine("Ingrese total de vehiculos");
	            string n = Console.ReadLine();
	            f = int.Parse(n);
	
	            Console.WriteLine("Ingrese total de caracteristicas");
	            n = Console.ReadLine();
	            c = int.Parse(n);
	
	            mat = new double[f, c];
	
	            for (int i = 0; i<f; i++)
	            {
	                for (int j = 0; j<c; j = j + 1)
	                {
	                    Random aleto = new Random();
	                    mat[i, j] = aleto.Next(1, 99);
	                }
	            }
	        }
	        public void mostrarMatriz()
	        {
	            for (int i = 0; i < f; i++)
	            {
	                for (int j = 0; j < c; j = j + 1)	                {
	                    Console.Write(mat[i, j] + "  ");
	                }
	                Console.WriteLine();
	            }
	        }
	        public void literal1()
	        {
	            Console.WriteLine("\nLiteral a");
	            double may = 0;
	            double men = 999;
	            int posmay = 0;
	            int posmen = 0;
	            double sumamay = 0;
	            double sumamen = 0;
	                for (int j = 0; j < f; j = j + 1)
	                {
	                    sumamay = sumamay + mat[j, 3];
	                    sumamen = sumamen + mat[j, 3];
	                }
	                if (sumamay > may)
	                {
	                    may = sumamay;
	                    posmay = f;
	                }
	                if (sumamen < men)
	                {
	                    men = sumamen;
	                    posmen = f;
	                }
	                sumamay = 0;
	                sumamen = 0;
	            Console.WriteLine("El dia de mayor consumo es el dia " + posmay);
	            Console.WriteLine("El dia de menor consumo es el dia " + posmen);
	
	        }
	        public void literal2()
	        {
	            Console.WriteLine("\nLiteral b");
	            
	            double suma = 0;
	            double sumaT = 0;
	            for (int j = 0; j < f; j = j + 1)
	            {
	                suma = suma + mat[j, 1];
	            }
	            sumaT = suma / f;
	            Console.WriteLine("El promedio es " + sumaT);
	
	        }
	        public void literal3()
	        {
	            Console.WriteLine("\nLiteral c");
	
	            int suma = 0;
	            for (int i = 0; i < f; i = i + 1)
	            {
	                for (int j = 0; j < c; j = j + 1)
	                {
	                    if (mat[i, j] >= 50 && mat[i, j] <= 70)
	                    {
	                        suma = suma + 1;
	                    }
	                }
	            }
	            Console.WriteLine("La cantidad entre 50 y 70 es " + suma);
	
	        }
	
	
	
	        static void Main(string[] args)
	        {
	            Program ob = new Program();
	            ob.ingresarMat();
	            Console.WriteLine("Datos");
	            ob.mostrarMatriz();
	            ob.literal1();
	            ob.literal2();
	            ob.literal3();
	            Console.ReadKey();
	        }
	    }
	}
