using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Vectores
{
    class vectorclass
    {
        private int[] vector; //Declaramos un vector de tipo entero 
           //procedimiento para llenar un vector
        public void Cargar()
        {
           // Random rnd = new Random();//para generar los valores aleatorios
            string linea;
            Console.Write("Dimensión del vector: ");
            linea=Console.ReadLine();
            int n=int.Parse(linea);
            vector = new int[n];
           
            //llenar el vector
            for (int f = 0; f < n; f++)
            {
                Console.Write("Ingrese el valor de la posicion "+(f+1)+": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
                //int r  = rnd.Next(1, 13);  //aleatorios de 1 a 12
                //vector[f]=r;
            }
        }
        
        public float promedio()
         {
              int sum =0;
              for(int i=0; i<vector.Length;i++)
                   sum=sum+vector[i];
                float prom=sum/vector.Length;
                return(prom);              
        }
        public double varianzafun(float p)
        {
           double x=0;
           for(int i=0; i<vector.Length;i++)
              {
                  x=x+Math.Pow((vector[i]-p),2);
               }
                
               double y=(x/vector.Length);
               return(y);
           
         }
        
        //procedimiento para visualizar el contenido del vector
        public void visualizar()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.WriteLine("El valor de la posicion "+(f+1)+": "+vector[f]);  
            }
 
            Console.ReadKey();
        }
        //programa principal
        static void Main(string[] args)
        {
            vectorclass pv = new vectorclass();
            pv.Cargar();
            pv.visualizar();
            float t=pv.promedio();
            double x1=pv.varianzafun(t);
            Console.WriteLine("Varianza: "+x1);
            double desv=Math.Sqrt(x1);
            Console.WriteLine("Desviasión estandar: "+desv);
        }
    }
}
