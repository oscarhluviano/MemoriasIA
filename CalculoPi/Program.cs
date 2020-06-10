using System;

namespace CalculoPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temas Selectos de Programación 2");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Grupo: 7");
            Console.WriteLine("Tema: Cálculo de pi");
            Console.WriteLine("Ibáñez López Lena Alonso");
            Console.WriteLine("---------------------------------");


            double aux = 0;
            double error = 0;
            for (int i = 0; i < 100000; i++)
            {
                aux = Math.Pow(-1,i)*4 / (2 * i + 1)+aux;
                error = 100000*Math.Abs((Math.PI - aux) / Math.PI);
                Console.WriteLine("Pi="+aux+" Error="+error);
            }
            Console.Read();
        }
    }
}
