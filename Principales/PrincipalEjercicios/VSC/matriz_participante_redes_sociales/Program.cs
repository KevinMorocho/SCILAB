using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aaaa
{
    class prueba1
    {
        private int[,] matriz;
        private float[] vpro;        
        public int n, redes;
        private int posicion;
        private float sumaTotal;

        public void ingresarmatriz()
        {
            string linea;
            Console.Write("PARTICIPANTE A INGRESAR ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.Write("RED SOCIAL: ");
            linea = Console.ReadLine();
            redes = int.Parse(linea);
            matriz = new int[n, redes];
            int valor;
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n PARTICIPANTE: " + (i));
                for (int j = 0; j < redes; j = j + 1)
                {
                    Console.Write("\n RED SOCIAL: " + (j));
                    linea = Console.ReadLine();
                    valor= int.Parse(linea);                   
                    matriz[i, j] = valor;                    
                }
            }
        }
        public void imprirmirmatriz()
        {
            Console.WriteLine();
            Console.WriteLine("\nDATOS DE LOS PARTICIPANTES Y REDES SOCIALES");
            sumaTotal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < redes; j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                    sumaTotal = sumaTotal + matriz[i, j];
                }
                Console.WriteLine();
            }
        }

        public void mayuso()
        {            
            float suma;
            int i, j;
            vpro = new float[redes];            
            for (i = 0; i < redes; i++)
            {
                suma = 0;
                for (j = 0; j < n; j = j + 1)
                {
                    suma = suma + matriz[j, i];
                }                
                vpro[i] = (suma / sumaTotal)*100;                
            }
            posicion = 0;
            float may = vpro[0];
            for (i = 0; i < redes; i++)
            {
                if (vpro[i] > may) {
                    may = vpro[i];
                    posicion = i;
                }
            }
            Console.WriteLine("\nLA RED SOCIAL DE MAYOR CONSUMO ES: " + posicion + " CON EL "+may+"%");            
        }

        public void mayConsumo()
        {
            int may = 0;
            int i, j,pos;
            pos = 0;
            for (i = 0; i < n; i++)
            {                
                for (j = 2; j <= 2; j++)
                {
                    if (matriz[i,j]>may)
                    {
                        may = matriz[i, j];
                        pos = i;
                    }                        
                }                
            }
            Console.WriteLine("\nPARTICIPANTE CON MAYOR CONSUMO DE WHATSAPP ES EL #: "+pos );
        }        
        public void proParticipante()
        {
            float pro;
            int suma;
            int i, j;            
            for (i = 0; i < n; i++)
            {
                suma = 0;
                for (j = 0; j < redes; j = j + 1)
                {
                    suma = suma + matriz[i,j];
                }                
                pro = (float)(suma / redes);
                Console.WriteLine("PARTICIPANTE "+i+" PROMEDIO DE CONSUMO ES: "+pro+" DIAS");   
            }
        }

        static void Main(string[] args)
        {
            prueba1 psicologo = new prueba1();
            psicologo.ingresarmatriz();
            psicologo.imprirmirmatriz();
            psicologo.mayuso();
            psicologo.mayConsumo();            
            psicologo.proParticipante();
            Console.ReadKey();
        }
    }
}


