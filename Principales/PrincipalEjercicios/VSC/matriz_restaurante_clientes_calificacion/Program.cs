using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matriz_restaurante_clientes_calificacion
{
    class prueba1
    {
        private int[,] matriz;        
        private float[] vpro;
        private int[] pos;
        public int n, calificar;

        public void ingresarmatriz()
        {
            string linea;
            Console.Write("Total de clientes: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            calificar = 5;
            matriz = new int[n, calificar];
            int valor;
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nCLIENTE : " + (i + 1));
                for (int j = 0; j < calificar; j = j + 1)
                {
                    if (j == 0)
                    {
                        Console.Write("\nAtencion por parte de los empleados : " + (j + 1) + ": ");
                    }
                    if (j == 1)
                    {
                        Console.Write("\nCalidad de comida : " + (j + 1) + ": ");
                    }
                    if (j == 2)
                    {
                        Console.Write("\nProtocolo de seguridad : " + (j + 1) + ": ");
                    }
                    if (j == 3)
                    {
                        Console.Write("\nJusticia del precio : " + (j + 1) + ": ");
                    }
                    if (j == 4)
                    {
                        Console.Write("\nAmbiente : " + (j + 1) + ": ");
                    }
                    /*linea = Console.ReadLine();
                    valor= int.Parse(linea);
                    while (valor <1  || valor > 10)
                    {
                        Console.Write("\nNOTA: Ingrese nuevamente un valor (1-10):  ");
                        linea = Console.ReadLine();
                        valor = int.Parse(linea);
                    }*/
                    //matriz[i, j] = valor;
                    Random r = new Random();
                    matriz[i, j] = r.Next(1, 10);
                }
            }
        }
        public void imprirmirmatriz()
        {
            Console.WriteLine();
            Console.WriteLine("\nMatriz cliente - calificacion");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < calificar; j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void proCali()
        {
            float pro;
            int suma;
            int i, j;
            vpro = new float[calificar];
            pos = new int[calificar];
            for (i = 0; i < calificar; i++)
            {
                suma = 0;
                for (j = 0; j < n; j = j + 1)
                {
                    suma = suma + matriz[j, i];
                }
                float auxn = n;
                pro = (float)(suma / auxn);
                if (i == 0)
                {
                    Console.Write("\nPromedio Atencion por parte de los empleados : " + pro + " posicion "+j);
                }
                if (i == 1)
                {
                    Console.Write("\nPromedio Calidad de comida : " + pro);
                }
                if (i == 2)
                {
                    Console.Write("\nPromedio  Protocolo de seguridad : " + pro);
                }
                if (i == 3)
                {
                    Console.Write("\nPromedio Justicia del precio : " + pro);
                }
                if (i == 4)
                {
                    Console.Write("\nPromedio Ambiente : " + pro);
                }
                vpro[i] = pro;
                //Console.Write("\nsuma es :" + suma + " Promedio # " + pro);
            }
        }

        public void ordenCali()
        {
            Console.WriteLine();
            int i, j;            
            Console.Write("\n\nOrdenado");
            for (i = 0; i < calificar ; i++)
            {
                for (j = i + 1; j < calificar; j++)
                {
                    if (vpro[i] < vpro[j])
                    {
                        float aux = vpro[i];
                        vpro[i] = vpro[j];
                        vpro[j] = aux;
                        //int k = i;
                        //pos[i] = pos[j];
                        //pos[i] = i;                        
                        Console.WriteLine("   "+ vpro[i]);

                        if (i == 0)
                        {
                            Console.Write("\nAtencion por parte de los empleados ");
                        }
                        if (i == 1 )
                        {
                            Console.Write("\nCalidad de comida ");
                        }
                        if (i == 2 )
                        {
                            Console.Write("\nProtocolo de seguridad ");
                        }
                        if (i == 3 )
                        {
                            Console.Write("\nJusticio del precio ");
                        }
                        if (i == 4)
                        {
                            Console.Write("\nAmbiente ");
                        }
                    }
                }
            }

            //for (i = 0; i < calificar; i++)
            //{
              //  Console.Write(vpro[i] + "   ");
           // }


            
            for (i = 0; i < calificar; i++)
            {
                
            }

        }
        public void proTotal()
        {
            float pro;
            int suma;
            int i, j;
            float proT = 0;
            float sumaPro=0;
            for (i = 0; i < calificar; i++)
            {
                suma = 0;
                for (j = 0; j < n; j = j + 1)
                {
                    suma = suma + matriz[j, i];
                }
                float auxn = n;
                pro = (float)(suma / auxn);
                sumaPro = sumaPro + pro;                
            }
            proT = sumaPro / 5;
            Console.Write("\n\nPromedio total del experimento es " + proT);
        }

        static void Main(string[] args)
        {
            prueba1 pie_sucu = new prueba1();
            pie_sucu.ingresarmatriz();
            pie_sucu.imprirmirmatriz();
            pie_sucu.proCali(); 
            pie_sucu.ordenCali();
            pie_sucu.proTotal();            
            Console.ReadKey();
        }
    }
}


   