using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace console3
{
    class console3
    {
        private int[,] mat;
        private float[] vect;
        public int[] pos;
        public void ingresarMatriz()
        {
            string linea;

            mat = new int[4, 7];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Random ra = new Random();
                    mat[i, j] = ra.Next(0, 9);
                }
            }
        }
        public void mostraMatriz()
        {
            Console.WriteLine("MATRIZ GENERADA ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j = j + 1)
                {
                    Console.Write(mat[i, j] + "   ");
                }
                Console.Write("\n");
            }
        }
        public void almenos2dias()
        {

            int preci = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j = j + 1)
                {
                    if (mat[i, j] == 0)
                    {
                        preci++;
                    }
                }
                if (preci >= 2)
                {
                    Console.WriteLine("La region " + (i + 1) + " no representa precipitaciones al menos 2 dias a la semana");
                }
                preci = 0;
            }
        }

        public void porDia()
        {
            vect = new float[7];
            pos = new int[7];
            float totalsuma = 0;
            float preci = 0;
            Console.Write("\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j = j + 1)
                {
                    totalsuma = totalsuma + mat[i, j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j = j + 1)
                {
                    preci = preci + mat[j, i];
                }
                float diario = ((preci / totalsuma) * 100);
                Console.WriteLine("Día " + (i + 1) + " tiene " + diario + "% de precipitaciones ");
                vect[i] = diario;
                pos[i] = i;
                preci = 0;
            }
        }

        public void menores()
        {
            /*Console.WriteLine("MATRIZ sin ordenar ");
            for (int j = 0; j < 7; j = j + 1)
            {
                Console.WriteLine(vect[j]);
            }*/
            float aux = 0;
            int auxe = 0;
            Console.Write("\n");
            for (int i = 0; i < 7; ++i)
            {
                for (int j = i + 1; j < 7; ++j)
                {
                    if (vect[i] > vect[j])
                    {
                        aux = vect[i];
                        vect[i] = vect[j];
                        vect[j] = aux;

                        auxe = i;
                        pos[i] = j;
                        pos[j] = auxe;
                    }
                }
            }
            /* Console.WriteLine("vector ORDENADA ");
             for (int j = 0; j < 7; j = j + 1)
             {
                 Console.WriteLine(vect[j]);
             }*/
            Console.WriteLine("Dias menos lluviosos son ");
            Console.WriteLine("Dia " + (pos[0]+1));
            Console.WriteLine("Dia " + (pos[1]+1));
        }



        static void Main(string[] args)
        {
            console3 obj = new console3();
            obj.ingresarMatriz();
            obj.mostraMatriz();
            obj.almenos2dias();
            obj.porDia();
            obj.menores();
            Console.ReadKey();
        }
    }
}