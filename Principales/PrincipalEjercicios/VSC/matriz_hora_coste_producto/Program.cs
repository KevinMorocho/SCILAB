using System;
namespace proManu
{
    class proManu
    {
        private int[,] manufactura;
        public int fil, col;
        public void llenar()
        {
            string linea;
            fil = 4;
            col = 4;
            manufactura = new int[fil, col];
            for (int a = 0; a < fil; a++)
            {
                Console.Write("\nPROCESO: " + (a + 1));
                for (int b = 0; b < col; b = b + 1)
                {
                    
                    if (a==0)
                    {
                        Console.Write("\nCOSTE/HORA " + (b + 1) + ": ");
                    }
                    else
                    {
                        Console.Write("\nPRODUCTO    " + (b + 1) + ": ");
                    }
                    linea = Console.ReadLine();
                    manufactura[a, b] = int.Parse(linea);
                }
            }
        }
        public void mostrar()
        {
            Console.WriteLine("\n\n");
            for (int a = 0; a < fil; a++)
            {
                for (int b = 0; b < col; b = b + 1)
                {
                    Console.Write(manufactura[a, b] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void CostoUni()
        {
            int  a,aux1,aux2;
            for (a = 0; a < fil; a++)
            {
                aux1 = manufactura[a, 1];
                for (int b = 1; b < col; b = b + 1)
                {
                    aux2 = manufactura[a, b]*aux1;
                    Console.Write("\nCOSTO UNITARIO PROCESO "+(a+1)+" PRODUCTO "+(b+1)+" COSTE ES: "+aux2);
                }                
            }
            Console.Write("\n\n");
        }

        public void totalPro()
        {
            int aux1 = 0;
            int aux2 = 0;
            for (int a = 0; a < col; a++)
            {
                aux1 = manufactura[a, 1];
                for (int b = 1; b < fil; b = b + 1)
                {
                    if (b == 1)
                    {
                        aux2 = manufactura[a, b] * aux1 * 10;
                        Console.Write("\nPRODUCCION DE 10 UNIDADES COSTE TOTAL ES " + aux2);
                    }
                    if (b == 2)
                    {
                        aux2 = manufactura[a, b] * aux1 * 5;
                        Console.Write("\nPRODUCCION DE 5 UNIDADES COSTE TOTAL ES " + aux2);
                    }
                    if (b == 1)
                    {
                        aux2 = manufactura[a, b] * aux1 * 7;
                        Console.Write("\nPRODUCCION DE 7 UNIDADES COSTE TOTAL ES " + aux2);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            proManu manuObj = new proManu();
            manuObj.llenar();
            manuObj.mostrar();
            manuObj.CostoUni();
            manuObj.totalPro();
            Console.ReadKey();
        }
    }
}