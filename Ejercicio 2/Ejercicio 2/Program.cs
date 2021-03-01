using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numero1 = 0;
            do
            {
                if (numero1 < 1 || numero1 > 15)
                {
                    Console.WriteLine("Ingrese un numero del 1 al 15");
                }
                numero1 = Double.Parse(Console.ReadLine());
            } while (numero1 > 15 || numero1 < 1);
            for (int x = 0; x < numero1; x++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();
        }
    }
}
