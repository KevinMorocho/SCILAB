using System;
namespace mater
{
    class mater
    {
        private int[,] mat1;
        private int[,] mat2;
        private int[] vec1;
        private int[] vec2;
        public int productos, meses;
        public int mayEx,sum1,sum2;
        public void insertarDatos1()
        {
            meses = 12;
            productos = 5;
            mat1 = new int[productos, meses];
            for (int i = 0; i < productos; i++)
            {   
                for (int j = 0; j < meses; j = j + 1)
                {
                    Random ra = new Random();
                    mat1[i, j] = ra.Next(1, 99);
                }
            }
        }

        public void mostrarDatos1()
        {
            Console.WriteLine("\nmatriz 1 generada");
            for (int i = 0; i < productos; i++)
            {
                for (int j = 0; j < meses; j++)
                {
                    Console.Write(mat1[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void insertarDatos2()
        {
            meses = 12;
            productos = 5;
            mat2 = new int[productos, meses];
            for (int i = 0; i < productos; i++)
            {
                for (int j = 0; j < meses; j = j + 1)
                {
                    Random ra = new Random();
                    mat2[i, j] = ra.Next(1, 99);
                }
            }
        }


        public void mostrarDatos2()
        {
            Console.WriteLine("\n\nmatriz 2 generada");
            for (int i = 0; i < productos; i++)
            {
                for (int j = 0; j < meses; j++)
                {
                    Console.Write(mat2[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void lita()
        {
           sum1 = 0;
           sum2 = 0;
            for (int i = 0; i < productos; i++)
            {
                for (int j = 0; j < meses; j++)
                {
                    sum1=sum1+mat1[i, j];
                    sum2=sum2+mat2[i, j];
                }                
            }

            //Console.WriteLine("Suma 1 es "+sum1);
            //Console.WriteLine("Suma 2 es "+sum2);

            if (sum1>sum2)
            {
                mayEx = 1;
            }
            else
            {
                mayEx = 2;
            }
            Console.WriteLine("\nEl anio con mayor exportaciones es el: " + mayEx);
        }
        public void litb()
        {
            float mSeptiembre = 0;
            for (int i = 0; i < productos; i++)
            {
                for (int j = 8; j < 9; j++)
                {                    
                    mSeptiembre = mSeptiembre + mat2[i, j];
                }
            }
            //Console.WriteLine("Suma de septiembre es: "+mSeptiembre);
            float por=(mSeptiembre/sum2)*100;
            Console.WriteLine("\nEl mes de septiembre se exporto "+por+"% de producto");

        }

        public void litc()
        {
            vec1 = new int[5];
            vec2 = new int[5];
            
            for (int i = 0; i < productos; i++)
            {
                int suma = 0;
                for (int j = 0; j < meses; j++)
                {
                    suma = suma + mat2[i, j];
                }
                vec1[i] = i;
                vec2[i] = suma;
            }
           
        }

        static void Main(string[] args)
        {
            mater obj = new mater();
            obj.insertarDatos1();
            obj.mostrarDatos1();
            obj.insertarDatos2();
            obj.mostrarDatos2();
            obj.lita();            
            obj.litb();
            obj.litc();
            Console.ReadKey();
        }
    }
}