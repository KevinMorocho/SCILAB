using System;

namespace Recuperacion
{
    class examen_sus
    {
        private float[,] mundo;
    public int c, f;
    public void llenarMatriz()
    {
        Console.WriteLine("Cuantos materiales son");
        string to = Console.ReadLine();
        f = int.Parse(to);
        Console.WriteLine("Cuantas caracteristicas");
        to = Console.ReadLine();
        c = int.Parse(to);
        mundo = new float[f, c];
        for (int x = 0; x < f; x++)
        {
            for (int w = 0; w < c; w++)
            {
                Random aleto = new Random();
                mundo[x, w] = aleto.Next(1, 99);
            }
        }
        Console.WriteLine("Datos almacenados");
        for (int x = 0; x < f; x++)
        {
            for (int w = 0; w < c; w++)
            {
                Console.Write(mundo[x, w] + "     ");
            }
            Console.WriteLine();
        }
    }

    public void literalA()
    {
        float promedio = 0;
        float sc = 0;
        Console.WriteLine("\nRESPUESTA 1");
        for (int x = 0; x < c; x = x + 1)
        {
            for (int w = 0; w < f; w++)
            {
                sc = sc + mundo[w, x];
            }
            promedio = sc / c;
            sc = 0;
            Console.WriteLine("Promedio " + (x + 1) + " es " + promedio);
            promedio = 0;
        }
    }

    public void literalB()
    {

        Console.WriteLine("\nRESPUESTA 2");
        float s = 0;
        float may = 0;
        float pos = 0;
        for (int x = 0; x < f; x = x + 1)
        {
            for(int w=2; w <3; w = w + 1)
                {
                    s = mundo[x, w];
                    
                }
                if (s > may)
                {
                    may = s;
                    pos = x;
                }

                s = 0;
        }
            Console.WriteLine("Valor mayor está en la posicion " + (pos + 1) +"es el valor "+may);
        }

    public void literalC()
    {
        Console.WriteLine("\nRESPUESTA 3");
            float suma = 0;
            float div, promedio;
        for (int x = 0; x < f; x = x + 1)
        {
            for (int w = 0; w < c; w++)
            {
                suma = mundo[x, w];
            }
        }

             div = f * c;
             promedio = suma / div;

        Console.WriteLine("Promedio "+promedio);
       

    }

    static void Main(string[] args)
    {
        examen_sus obj = new examen_sus();
        obj.llenarMatriz();
        obj.literalA();
        obj.literalB();
        obj.literalC();
    }
}

}
